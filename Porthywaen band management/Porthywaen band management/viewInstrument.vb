Structure instruments
	<VBFixedString(10)> Dim serialNumber As String
	<VBFixedString(30)> Dim name As String
	<VBFixedString(14)> Dim instrument As String
	<VBFixedString(5)> Dim holderID As String
	<VBFixedString(22)> Dim serviceDate As Date
End Structure
Public Class viewInstrument
	Public currentRecord As Integer = 0

	'declaring global variables to handle undo and redo
	Shared undo() As String
	Shared count As Integer = 0
	Shared pointer As Integer = 1
	Shared lengthCount As Integer = 0 'does not decrease so more elements are added to array if undo, input, undo occurs
	Sub colours(dgv)    'formats and displays data in dgv
		Try
			'colour variables to format service date colours
			Dim red = Date.Today.ToString("MM") - 11
			Dim yellow = Date.Today.ToString("MM") - 9
			Dim orange = Date.Today.ToString("MM") - 10
			Dim serviceDate As String
			Dim index As Integer
			Dim oneInstrument As instruments
			Dim oneMember As memberInfo     'called to get holderName from id

			dgvInstruments.Rows.Clear()
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneMember))

			Dim totalRecordsInstrument As Integer = LOF(1) / Len(oneInstrument)
			Dim totalRecordsMember As Integer = LOF(2) / Len(oneMember)

			'open file and display record in dgv
			For index = 1 To totalRecordsInstrument
				FileGet(1, oneInstrument)

				If oneInstrument.holderID = "" Or oneInstrument.holderID = vbNullChar Then
					dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
										oneInstrument.holderID, "", oneInstrument.serviceDate)
				Else
					Try
						For i = 1 To totalRecordsMember 'find holderName
							FileGet(2, oneMember)
							If oneMember.id.Contains(txtHolderID.Text) Then
								dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
												oneInstrument.holderID, oneMember.name, oneInstrument.serviceDate)

							End If
						Next
					Catch ex As Exception
						MsgBox("Holder ID does not match any member IDs", vbExclamation, "Error")
					End Try
				End If
				'format service dates
				serviceDate = oneInstrument.serviceDate.ToString("dd/MM/yyyy")
				If dgv.RowCount > 0 Then
					If serviceDate.Contains(red) Then
						dgv.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
						dgv.Rows(index - 1).Cells(5).Style.ForeColor = Color.White

					ElseIf serviceDate.Contains(yellow) Then
						dgv.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
						dgv.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

					ElseIf serviceDate.Contains(orange) Then
						dgv.Rows(index - 1).Cells(5).Style.BackColor = Color.Orange
						dgv.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

					Else
						dgv.Rows(index - 1).Cells(5).Style.BackColor = Color.LightGreen
						dgv.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
					End If
				End If
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				colours(dgv)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Sub validation(serialNo, name, instrument, holderID)
		Try
			If Len(serialNo) > 0 Or Len(name) > 0 Or Len(instrument) > 0 Then
			Else MsgBox("Enter data in all applicable fields")
				If Len(holderID) > 0 Then
					If Len(holderID) = 5 Then
					Else MsgBox("ID must be 5 characters long")
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("Validation failed", vbCritical, "Error")
			Exit Sub
		End Try
	End Sub
	Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
		Try
			Dim oneInstrument As instruments    'pointer to structure
			Dim quantity As Integer = 0
			Dim instrument As String
			Dim holder As String
			Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			While Not EOF(1)
				FileGet(1, oneInstrument)
				instrument = oneInstrument.instrument
				holder = oneInstrument.holderID

				If instrument.Contains(cmbInstrumentSearch.Text) Then   'search for the same instrument as selected
					If holder.Contains(empty) Then  'no id means the instrument is available
						quantity = quantity + 1
						dgvInstrumentSearch.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
													 oneInstrument.holderID)
					End If
				End If
			End While

			txtQuantity.Text = quantity
			FileClose(1)
			If quantity = 0 Then
				MsgBox("No available instruments found")
			End If
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Search failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnFind_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Try
			'set up pointer to record
			Dim oneInstrument As instruments
			Dim oneMember As memberInfo
			validation(txtSerialNo.Text, txtName.Text, cmbInstrument, txtHolderID.Text) 'validation

			'populate structure
			oneInstrument.serialNumber = txtSerialNo.Text
			oneInstrument.name = txtName.Text
			oneInstrument.instrument = cmbInstrument.Text
			oneInstrument.holderID = txtHolderID.Text
			oneInstrument.serviceDate = dtpServiceDate.Text

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
			FilePut(1, oneInstrument, totalRecords + 1) '+1 append to file
			FileClose(1)

			colours(dgvInstruments) 'display and format dgv
			MsgBox("Instrument added successfully")

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("new instrument failed to add to system", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnAdd_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Try
			'set up pointer to record
			Dim oneInstrument As instruments
			validation(txtSerialNo.Text, txtName.Text, cmbInstrument, txtHolderID.Text) 'validation

			Dim serviceMonth = oneInstrument.serviceDate.ToString("MM")
			Dim red = Date.Today.ToString("MM") - 11
			Dim yellow = Date.Today.ToString("MM") - 9
			Dim orange = Date.Today.ToString("MM") - 10

			'populate structure
			oneInstrument.serialNumber = txtSerialNo.Text
			oneInstrument.name = txtName.Text
			oneInstrument.instrument = cmbInstrument.Text
			oneInstrument.holderID = txtHolderID.Text
			oneInstrument.serviceDate = dtpServiceDate.Text

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			FilePut(1, oneInstrument, currentRecord)
			FileClose(1)

			colours(dgvInstruments) 'display and format dgv
			MsgBox("Instrument updated")
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Update failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnUpdate_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub dgvInstruments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstruments.CellClick
		Try
			Dim readSerialNo As String
			Dim row As DataGridViewRow = dgvInstruments.CurrentRow
			currentRecord = row.Index + 1

			'stops instruments from being diplayed when column header clicked to sort dgv
			If e.RowIndex = -1 Then
				Return
			End If

			Dim serialNo = row.Cells(0).Value.ToString()

			'clear all inputs
			txtSerialNo.Clear()
			txtHolderID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrument.ResetText()

			'display details
			Dim oneInstrument As instruments 'pointer to structure
			Dim oneMember As memberInfo
			Dim index As Integer
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecordsInstrument As Integer = LOF(1) / Len(oneInstrument)
			Dim totalRecordsMember As Integer = LOF(1) / Len(oneMember)

			For index = 1 To totalRecordsInstrument
				FileGet(1, oneInstrument)
				readSerialNo = oneInstrument.serialNumber

				'if read id matches id selected in dgv display structure 
				If readSerialNo.Contains(serialNo) Then
					If oneInstrument.holderID <> "" Then    'if holderID stored, find holderName in players file
						For i = 1 To totalRecordsMember
							If oneInstrument.holderID = oneMember.id Then
								txtHolderID.Text = String.Format(oneInstrument.holderID)
								txtName.Text = String.Format(oneInstrument.name)
								dtpServiceDate.Value = String.Format(oneInstrument.serviceDate)
								txtSerialNo.Text = String.Format(oneInstrument.serialNumber)
								txtHolderName.Text = String.Format(oneMember.name)
								cmbInstrument.Text = String.Format(oneInstrument.instrument)

								Exit For
							End If
						Next
					End If
				End If
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				dgvInstruments_CellClick(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub dgvInstrumentSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstrumentSearch.CellClick
		Try
			Dim readSerialNo As String
			Dim row As DataGridViewRow = dgvInstrumentSearch.CurrentRow
			Dim currentRecord As Integer = row.Index + 1

			'stops memberDetails from being diplayed when column header clicked to sort dgv
			If e.RowIndex = -1 Then
				Return
			End If

			Dim serialNo = row.Cells(0).Value.ToString()

			'clear all inputs
			txtSerialNo.Clear()
			txtHolderID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrumentSearch.ResetText()

			'display details
			Dim oneInstrument As instruments 'pointer to structure
			Dim index As Integer
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
			For index = 1 To totalRecords
				FileGet(1, oneInstrument)
				readSerialNo = oneInstrument.serialNumber

				'if read id matches id selected in dgv display structure 
				If readSerialNo.Contains(serialNo) Then
					txtHolderID.Text = String.Format(oneInstrument.holderID)
					txtName.Text = String.Format(oneInstrument.name)
					dtpServiceDate.Text = String.Format(oneInstrument.serialNumber)
					txtSerialNo.Text = String.Format(oneInstrument.serialNumber)
					'txtHolderName.Text = String.Format(oneInstrument.holderName)
					cmbInstrument.Text = String.Format(oneInstrument.instrument)

					If txtHolderID.Text = "" Then
						MessageBox.Show("Display failed")
					End If
				End If
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				dgvInstrumentSearch_CellClick(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub


	Private Sub ViewInstrument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		dtpServiceDate.MaxDate = Date.Today 'set max date as today so no need for range check on data

		If login.role = "player" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False

		ElseIf login.role = "librarian" Then
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False

		ElseIf login.role = "instruments" Then
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False
			MusicToolStripMenuItem.Enabled = False

		ElseIf login.role = "events" Or login.role = "admin" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False

			'conductor can see all so no menuItems are disabled
		End If

		'display members in dataGridView
		colours(dgvInstruments) 'display and format dgv
	End Sub
	Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Try
			Dim oneinstrument As instruments
			Dim recordNumber As Integer = txtHolderID.Text

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneinstrument))
			FileOpen(2, "tempInstruments.dat", OpenMode.Random,,, Len(oneinstrument))

			Dim reader As String
			Do While Not EOF(1)
				reader = Loc(1) 'testing
				If Loc(1) <> recordNumber - 1 Then
					FileGet(1, oneinstrument)
					FilePut(2, oneinstrument)
				Else
					FileGet(1, oneinstrument)
				End If
			Loop
			FileClose(1)
			FileClose(2)

			Kill("instruments.dat")
			Rename("tempInstruments.dat", "instruments.dat")

			MsgBox("Record deleted")

			colours(dgvInstruments) 'display and format dgv

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Delete failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				BtnDelete_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		Try
			'clear all inputs
			txtHolderID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrument.ResetText()
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Clear failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnClear_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub formChanged(sender As Object, e As EventArgs) Handles txtSerialNo.Leave, txtName.Leave,
	cmbInstrument.Leave, txtHolderID.Leave, dtpServiceDate.Leave
		Try
			'if a button has been clicked execute code for the button
			If ActiveControl.Name = "btnUndo" Then
				undo_click(sender, e)
			ElseIf ActiveControl.Name = "btnAdd" Then
				btnAdd_Click(sender, e)
			ElseIf ActiveControl.Name = "btnClear" Then
				btnClear_Click(sender, e)
			ElseIf ActiveControl.Name = "btnDelete" Then
				BtnDelete_Click(sender, e)
			ElseIf ActiveControl.Name = "btnUpdate" Then
				btnUpdate_Click(sender, e)

			Else
				'saves the data in the form to a dynamic array so changes can be restored when btnUndo clicked
				Dim changeRecorded As Boolean = False

				For i = pointer To undo.Length
					If changeRecorded = False Then
						If undo.Length - 1 - (lengthCount * 5) < 6 Then 'if no empty space, add more elements to the array
							ReDim Preserve undo(UBound(undo) + 6)
						End If
						If undo(i) = Nothing And i > 0 Then 'search for empty place in array that is not the first
							undo(i) = txtSerialNo.Text
							undo(i + 1) = txtName.Text
							undo(i + 2) = cmbInstrument.Text
							undo(i + 3) = txtHolderID.Text
							undo(i + 4) = cmbInstrument.Text
							undo(i + 5) = dtpServiceDate.Text

							pointer += 6
							count += 1
							lengthCount += 1
							changeRecorded = True
						End If
					End If
				Next
			End If
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Undo management failed", vbOKOnly + vbExclamation, "Error") = vbOK Then
				For j = 0 To undo.Length - 1
					undo(j) = Nothing
				Next
				count = 0
				lengthCount = 0
				pointer = 1
				formChanged(sender, e)
				MsgBox("Undo reset")

				Exit Sub
			End If
		End Try
	End Sub

	Private Sub undo_click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUndo.Click
		Try
			Dim startLocation As Integer = pointer - 28
			If count = 1 Then 'if only one change has been saved, the form must have been blank previously
				btnClear_Click(sender, e)

				count = 0
				pointer = 0
			ElseIf count = 0 Then
				MsgBox("No changes made to be undone")

			Else 'if more than 1 change
				txtSerialNo.Text = undo(startLocation)
				txtName.Text = undo(startLocation + 1)
				cmbInstrument.Text = undo(startLocation + 2)
				txtHolderID.Text = undo(startLocation + 3)
				cmbInstrument.Text = undo(startLocation + 4)

				count -= 1
				pointer -= 14
			End If
		Catch ex As Exception  'if fails, give option to retry, else end sub
			MsgBox("Undo failed", vbOKOnly + vbExclamation, "Error")
			Exit Sub
		End Try
	End Sub
	'opening forms when menu clicked
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		home.Show()
		Me.Hide()
	End Sub

	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click
		players.Show()
		Me.Hide()
	End Sub

	Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click
		group.Show()
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
	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			Application.Exit()
		End If
	End Sub

	Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
		userDetails.Show()
		Me.Hide()
	End Sub
End Class