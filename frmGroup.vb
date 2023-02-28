Structure playerAttendance  'declaring structure which stores data for each recrord read/added
	<VBFixedString(8)> Dim group As String
	<VBFixedString(22)> Dim markDate As Date
	<VBFixedString(400)> Dim attendance As String

End Structure
Public Class frmGroup
	Public Shared memberID As Integer
	Private Sub cmbGroup_TextChanged(sender As Object, e As EventArgs) Handles cmbGroup.TextChanged
		Dim index As Integer
		Dim oneMember As memberInfo 'pointer to structure

		dgvMembers.Rows.Clear()
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords   'get each records and display in dgv
			FileGet(1, oneMember)

			If oneMember.groups.Contains(cmbGroup.Text) Then      'only displays members in selected group
				dgvMembers.Rows.Add(oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim())
			End If
		Next
		FileClose(1)

		If cmbGroup.Text = "Dep" Then       'don't need to mark attendance for deps so user doesn't need to see chart
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
			totalRecords = LOF(1) / Len(oneMember)
			For index = 1 To totalRecords
				FileGet(1, oneMember)

				If oneMember.role.Contains(cmbGroup.Text) Then      'only displays members in selected group
					dgvMembers.Rows.Add(oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim())
					colPresent.Visible = False
				End If
			Next
			dgvTotal.Enabled = False
			chtAttendance.Enabled = False
		End If
		FileClose(1)

		If cmbGroup.Text = "Committee" Then       'don't need to mark attendance for deps so user doesn't need to see chart
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
			totalRecords = LOF(1) / Len(oneMember)
			For index = 1 To totalRecords

				FileGet(1, oneMember)

				If oneMember.role.Contains("Conductor") Or oneMember.role.Contains("Librarian") Or oneMember.role.Contains("Instrument steward") Or oneMember.role.Contains("Event coordinator") Or oneMember.role.Contains("Committee member") Or oneMember.role.Contains("Treasurer") Then      'only displays members in selected group
					colRole.Visible = True
					colPresent.Visible = False
					dgvMembers.Rows.Add(oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim(), oneMember.role.Trim())
				End If
			Next
			dgvTotal.Enabled = False    'don't need to mark attendance so don't need to see chart
			chtAttendance.Enabled = False

		End If
		FileClose(1)
		If dgvMembers.RowCount = 0 Then
			MsgBox("No players in the system are in this group", vbInformation, "Group")
		End If

	End Sub
	Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim oneMark As playerAttendance 'pointer to structure
		Dim recorded As Boolean
		Dim readMarks As String
		Dim mark As Boolean
		Dim marks As String()
		Dim recordNumber As Integer
		Dim found As Boolean

		If cmbGroup.Text = "" Then
			MsgBox("A group must be selected to save attendance", vbExclamation, "Group")
			Exit Sub
		End If

		Dim totalRecords As Integer

		For rowNumber = 0 To dgvMembers.Rows.Count - 1  'for each row in dgv
			FileClose(1)
			FileOpen(1, "attendance.dat", OpenMode.Random,,, Len(oneMark))
			totalRecords = LOF(1) / Len(oneMark)
			'find record and get all data
			For records = 1 To totalRecords
				FileGet(1, oneMark)
				If oneMark.markDate = (dtpMarkDate.Text) Then
					If oneMark.group.Trim() = cmbGroup.Text Then
						readMarks = oneMark.attendance.Trim()
						marks = readMarks.Split(";")
						recordNumber = records
						found = True
						Exit For
					End If
				End If
			Next

			'saving mark in variable
			If dgvMembers.Rows(rowNumber).Cells(4).Value = Nothing Then
				mark = False
			Else
				mark = True
			End If

			'saving mark to array
			If marks IsNot Nothing Then
				For index = 0 To marks.Length - 1
					recorded = False
					If marks(index) <> "" Then
						If found = True Then
							If marks(index).Contains(dgvMembers.Rows(rowNumber).Cells(0).Value & "," & mark) = True Then
								'check if same mark already recorded
								MsgBox("Attendance has already been recorded for " & dtpMarkDate.Text & " for " & dgvMembers.Rows(rowNumber).Cells(1).Value.Trim(","), vbExclamation, "Group")
								recorded = True
								Exit For

							ElseIf marks(index).Contains(dgvMembers.Rows(rowNumber).Cells(0).Value & ",") = True Then
								'check if mark recorded, but different
								If MsgBox("Attendance for " & oneMark.markDate & " for " & dgvMembers.Rows(rowNumber).Cells(1).Value.Trim(",") & " is different to inputted reponse. Would you like to update it?", vbYesNo + vbInformation, "Group") = vbYes Then
									'update mark
									marks(index) = (dgvMembers.Rows(rowNumber).Cells(0).Value & "," & mark)

									Dim newMark As String = ""
									For i = 0 To marks.Length - 1
										newMark = newMark & marks(i) & ";"
									Next

									oneMark.attendance = newMark
									FilePut(1, oneMark, recordNumber)
									MsgBox("Attendance updated", vbInformation, "Group")
									recorded = True
									Exit For
								Else 'don't want to update attendance
									recorded = True
									Exit For
								End If
							End If
						End If
					End If
				Next
			End If

			If recorded = False Then
				If found = False Then    'no attendance has been recorded for this date yet so add to file
					oneMark.markDate = dtpMarkDate.Text
					oneMark.group = cmbGroup.Text
					oneMark.attendance = (dgvMembers.Rows(rowNumber).Cells(0).Value & "," & mark & ";")
					FilePut(1, oneMark, totalRecords + 1)

				ElseIf found = True Then 'if it is a new attendance mark for a recorded date
					Dim marksString As String = ""
					'put all array elements into a string so thay can be stored
					For marksElement = 0 To marks.Length - 1
						If marks(marksElement) <> "" Then
							If marksString = Nothing Then
								marksString = marks(marksElement) & ";"
							Else
								marksString = marksString & marks(marksElement) & ";"
							End If
						End If
					Next
					'add the new attendance to the string
					marksString = marksString & dgvMembers.Rows(rowNumber).Cells(0).Value & "," & mark & ";"
					'store the attendance
					oneMark.attendance = marksString
					FilePut(1, oneMark, recordNumber)
					recorded = True
				End If
			End If
		Next
		FileClose(1)
		MsgBox("Changes saved", vbInformation, "Group")
	End Sub

	Private Sub BtnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
		If cmbGroup.Text = "" Then
			MsgBox("A group must be selected to show attendance", vbExclamation, "Group")
			Exit Sub
		End If

		'displaying attendance in a chart
		Dim oneMark As playerAttendance 'pointer
		Dim percentage As Decimal
		Dim readDate As Date
		Dim dates() As String   'all dates that attendance recorded
		Dim counts() As String  'number present on each date
		Dim totalRead() As String   'total number of players in group on each date

		Dim readMarks As String
		Dim marks As String()

		dgvTotal.Rows.Clear()

		'setting up the chart
		chtAttendance.Series.Clear()
		chtAttendance.Series.Add("Date")
		chtAttendance.Series("Date").ChartType = DataVisualization.Charting.SeriesChartType.Column
		chtAttendance.Series("Date").Points.Clear()
		chtAttendance.ChartAreas("ChartArea1").AxisX.Interval = 1 'so all point labels are shown

		'axis labels
		chtAttendance.ChartAreas("ChartArea1").AxisX.Title = "Dates"
		chtAttendance.ChartAreas("ChartArea1").AxisY.Title = "Percentage present"

		Try
			FileOpen(1, "attendance.dat", OpenMode.Random,,, Len(oneMark))          'getting data
			Dim recordCount As Integer = LOF(1) / Len(oneMark)

			If recordCount = 0 Then
				FileClose(1)
				Exit Sub
			End If

			ReDim dates(recordCount - 1)
			ReDim counts(recordCount - 1)
			ReDim totalRead(recordCount - 1)

			For recordLoop = 0 To recordCount - 1
				FileGet(1, oneMark)
				If oneMark.group.Trim().Contains(cmbGroup.Text.Trim()) Then 'show attendance for selected group
					readDate = FormatDateTime(oneMark.markDate, DateFormat.ShortDate)

					'get the attendance
					readMarks = oneMark.attendance.Trim()
					marks = readMarks.Split(";")
					dates(recordLoop) = readDate

					totalRead(recordLoop) = marks.Length - 1

					'find number of people at rehearsal
					For mark = 0 To marks.Length - 1
						If marks(mark).Contains(vbNullChar) = False Then
							If marks(mark).Contains("True") Then
								counts(recordLoop) += 1
							End If
						End If
					Next
				End If
			Next
			FileClose(1)

			'bubble sort on dates so they are in descending order
			Dim swapped As Boolean = True
			Dim temp As String
			Dim n As Integer = recordCount - 1
			'Dim day As String()
			'Dim month As String()
			'Dim year As String()
			'Dim dateSplit As String()
			Dim current As String
			Dim index As Integer

			While swapped = True
				swapped = False
				For index = 0 To n - 1
					If DateDiff(DateInterval.DayOfYear, CDate(dates(index)), CDate(dates(index + 1))) > 0 Then
						'If dates(index) - dates(index + 1) < 0 Then
						temp = dates(index)
						dates(index) = dates(index + 1)
						dates(index + 1) = temp

						temp = counts(index)
						counts(index) = counts(index + 1)
						counts(index + 1) = temp

						temp = totalRead(index)
						totalRead(index) = totalRead(index + 1)
						totalRead(index + 1) = temp

						swapped = True
					End If
				Next
			End While

			Dim numToShow As Integer
			If txtRehearsals.Text < dates.Length Then
				numToShow = txtRehearsals.Text - 1
			Else
				numToShow = dates.Length - 1
			End If

			For index = 0 To numToShow      'calculate percentage
				If dates(index) <> Nothing Then
					percentage = (counts(index) / totalRead(index)) * 100
					dgvTotal.Rows.Add(dates(index), counts(index), percentage)
				End If
			Next

			'sort datagridview into ascending order
			swapped = True
			While swapped = True
				swapped = False
				For index = 0 To dgvTotal.Rows.Count - 2
					If DateDiff(DateInterval.DayOfYear, dgvTotal.Rows(index).Cells(0).Value, dgvTotal.Rows(index + 1).Cells(0).Value) < 0 Then
						temp = dgvTotal.Rows(index).Cells(0).Value
						dgvTotal.Rows(index).Cells(0).Value = dgvTotal.Rows(index + 1).Cells(0).Value
						dgvTotal.Rows(index + 1).Cells(0).Value = temp
						swapped = True
					End If
				Next
			End While

			For i = 0 To dgvTotal.Rows.Count - 1        'show data in chart
				chtAttendance.Series("Date").Points.AddXY(dgvTotal.Item(0, i).Value, dgvTotal.Item(2, i).Value)
			Next
		Catch ex As Exception
			MsgBox("Display failed", vbExclamation, "Group")
		End Try
	End Sub

	Private Sub group_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None

		dtpMarkDate.MaxDate = Date.Today    'validation

		Dim index As Integer
		Dim oneMember As memberInfo 'pointer to structure

		dgvMembers.Rows.Clear()
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords   'get each records and display in dgv
			FileGet(1, oneMember)

			If oneMember.groups.Contains(cmbGroup.Text) Then      'only displays members in selected group
				dgvMembers.Rows.Add(oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim())
			End If
		Next
		FileClose(1)
	End Sub
End Class