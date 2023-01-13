Structure playerAttendance
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim name As String
	<VBFixedString(22)> Dim markDate As Date
	<VBFixedString(5)> Dim mark As String
End Structure
Public Class group
	Public Shared memberID As Integer

	Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
		Dim index As Integer
		Dim oneMember As memberInfo 'pointer to structure

		dgvMembers.Rows.Clear()
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords
			FileGet(1, oneMember)

			If oneMember.groups.Contains(cmbGroup.Text) Then      'only displays members in selected group
				dgvMembers.Rows.Add(oneMember.id, oneMember.name, oneMember.instrument)
			End If
		Next
		FileClose(1)

		If cmbGroup.Text = "Dep" Then       'don't need to mark attendance for deps so user doesn't need to see chart
			For index = 1 To totalRecords
				FileGet(1, oneMember)

				If oneMember.role.Contains(cmbGroup.Text) Then      'only displays members in selected group
					dgvMembers.Rows.Add(oneMember.id, oneMember.name, oneMember.instrument)
				End If
			Next
			dgvTotal.Enabled = False
			Chart1.Enabled = False
		End If
	End Sub
	Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim index As Integer
		Dim oneMark As playerAttendance 'pointer to structure
		'Dim currentRecord As Integer
		'Dim row As DataGridViewRow = dgvMembers.CurrentRow
		'currentRecord = row.Index + 1
		FileOpen(1, "attendance.dat", OpenMode.Random,,, Len(oneMark))

		Dim totalRecords As Integer = LOF(1) / Len(oneMark)
		For index = 0 To dgvMembers.Rows.Count - 1
			'only stores name, id and date
			oneMark.id = dgvMembers.Rows(index).Cells(0).Value & ","
			oneMark.name = dgvMembers.Rows(index).Cells(1).Value & ","
			oneMark.markDate = dtpMarkDate.Text & ","

			If TypeOf dgvMembers.Rows(index).Cells(3) Is DataGridViewCheckBoxCell Then
				'store the mark
				Dim Checked As Boolean = dgvMembers.Rows(index).Cells(3).Value
				oneMark.mark = Checked
			End If
			FilePut(1, oneMark, totalRecords + 1 + index)
		Next
		FileClose(1)
		MessageBox.Show("Changes saved")
	End Sub
	Private Sub BtnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
		'displaying attendance in a chart
		Dim oneMark As playerAttendance 'pointer
		Dim weeks As Integer = txtWeeks.Text - 1
		Dim percentage As Decimal
		Dim readDate As String
		Dim dates(5) As String
		Dim counts(5) As String
		Dim totalRead(5) As String

		dgvTotal.Rows.Clear()

		Chart1.Series.Clear()       'setting up the chart
		Chart1.Series.Add("Week")
		Chart1.Series("Week").ChartType = DataVisualization.Charting.SeriesChartType.Column
		Chart1.Series("Week").Points.Clear()

		FileOpen(1, "attendance.dat", OpenMode.Random,,, Len(oneMark))          'getting data
		Dim recordCount As Integer = LOF(1) / Len(oneMark)

		For i = 0 To recordCount - 1
			FileGet(1, oneMark)
			readDate = oneMark.markDate.ToString(Format(oneMark.markDate, "dd.MM")) 'change date format so it is shown
			For j = 0 To 5      'for each possible date stored in the array
				If dates(j) = readDate Then     'if date found at location, +1 to count
					totalRead(j) += 1
					If oneMark.mark.Contains("True") Then
						counts(j) += 1
					End If
					Exit For
				ElseIf dates(j) = "" Then       'if date is not in array, add it to array and +1 to count if true
					totalRead(j) += 1
					dates(j) = readDate
					If oneMark.mark.Contains("True") Then
						counts(j) += 1
					End If
					Exit For
				End If
			Next
		Next
		FileClose(1)

		For i = 0 To weeks      'calculate percentage
			If dates(i) <> "" Then
				percentage = (counts(i) / totalRead(i)) * 100
				dgvTotal.Rows.Add(dates(i), counts(i), percentage)
			End If
		Next

		For i = 0 To dgvTotal.Rows.Count - 1        'show data in chart
			Chart1.Series(0).Points.AddXY(dgvTotal.Item(0, i).Value, dgvTotal.Item(2, i).Value)
		Next
	End Sub
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		Form1.Show()
		Me.Hide()
	End Sub

	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click
		players.Show()
		Me.Hide()
	End Sub
	Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
		viewEvents.Show()
		Me.Hide()
	End Sub

	Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click
		viewMusic.Show()
		Me.Hide()
	End Sub

	Private Sub InstrumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentsToolStripMenuItem.Click
		viewInstrument.Show()
		Me.Hide()
	End Sub
End Class