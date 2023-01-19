Imports System.Text.RegularExpressions
Structure memberInfo 'declaring the structure
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim name As String
	<VBFixedString(50)> Dim dob As Date
	<VBFixedString(50)> Dim email As String
	<VBFixedString(11)> Dim phone As String
	<VBFixedString(14)> Dim instrument As String
	Dim level As Short
	<VBFixedString(1)> Dim photoPerm As Boolean
	<VBFixedString(50)> Dim contName As String
	<VBFixedString(11)> Dim contPhone As String
	<VBFixedString(24)> Dim groups As String
	<VBFixedString(20)> Dim role As String
End Structure
Public Class players
	Public Shared memberID As String
	Public Shared currentRecord As Integer = 0

	'declaring global variables to handle undo and redo
	Shared undo() As String
	Shared count As Integer = 0
	Shared pointer As Integer = 1
	Shared lengthCount As Integer = 0 'does not decrease so more elements are added to array if undo, input, undo occurs
	Private Sub players_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
		If MsgBox("Would you like to logout?", vbYesNo + vbQuestion, "Logout?") = vbYes Then
			Application.Exit()      'when the form is closed the exeution ends
		Else
			Exit Sub
		End If
	End Sub
	Sub dgvRefresh()
		Try
			Dim index As Integer
			Dim oneMember As memberInfo 'pointer to structure

			dgvPlayers.Rows.Clear()
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))       'open file

			Dim totalRecords As Integer = LOF(1) / Len(oneMember)       'add all detalis in file to dataGridView
			For index = 1 To totalRecords
				FileGet(1, oneMember)
				dgvPlayers.Rows.Add(oneMember.id, oneMember.name, oneMember.instrument, oneMember.phone)
			Next
			FileClose(1)
			groupInput.checkboxes() 'fills in the checkboxes
		Catch ex As Exception   'if fails, give option to retry, else end sub
			If MsgBox("Players failed to display", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				dgvRefresh()
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Shared Sub playersValidation(id, name, email, phone, role, level, instrument, photoPerm, contName, contPhone)
		Dim emailFormat As String = "^[A-Za-z0-9]+\@[A-Za-z0-9]+\.[A-Za-z0-9]+$"
		Dim emailMatch As Match = Regex.Match(email, emailFormat)

		'validation
		Try
			If Len(id) = 5 Then
			Else MsgBox("ID is not in the correct format")

				If name = "" Or email = "" Or instrument = "" Or level = "" Or contName = "" Or role = "" Then
				Else MsgBox("Enter details in all boxes")

					If emailMatch.Success = True Then
					Else MsgBox("Email address is in an incorrect format")

						If Len(phone) <> 11 Or Len(contPhone) <> 11 Then
						Else MsgBox("Enter a valid phone number")

							If photoPerm = True Or photoPerm = False Then
							Else MsgBox("Photograph permission is in the wrong format")
							End If
						End If
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox("Validation failed", vbExclamation, "Error")
			Exit Sub
		End Try
	End Sub
	Private Sub players_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'set maximum date that can be entered as today - no extra validation needed as within properties
		dtpDOB.MaxDate = Date.Today

		'disabling menu for different levels of access
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

		ReDim undo(1)      'set number of elements in dynamic arrays to avoid error
		dgvRefresh() 'add data to dgv
	End Sub
	Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Try
			Dim oneMember As memberInfo 'pointer to structure
			'validation
			playersValidation(txtID.Text, txtName.Text, txtEmail.Text, txtPhone.Text, cmbRole.Text, cmbLevel.Text,
						  cmbInstrument.Text, chkPhotoPerm.Checked, txtContName.Text, txtContPhone.Text)

			'converting checkboxes to a string - groups validated in function
			Dim groups As String = groupInput.groups(chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)

			oneMember.id = txtID.Text       'storing inputs in structure
			oneMember.name = txtName.Text
			oneMember.dob = dtpDOB.Text.ToString
			oneMember.email = txtEmail.Text
			oneMember.phone = txtPhone.Text
			oneMember.instrument = cmbInstrument.Text
			oneMember.level = cmbLevel.Text
			oneMember.photoPerm = chkPhotoPerm.Checked
			oneMember.groups = groups
			oneMember.contName = txtContName.Text
			oneMember.contPhone = txtContPhone.Text

			'storing structure in file
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
			FilePut(1, oneMember, currentRecord)
			FileClose(1)
			MsgBox("Player details updated")

			dgvRefresh() 'refresh the dgv

		Catch ex As Exception   'if fails, give option to retry, else end sub
			If MsgBox("Player update failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnUpdate_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub dgvPlayers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlayers.CellClick
		Dim row As DataGridViewRow = dgvPlayers.CurrentRow

		If e.RowIndex = -1 Then 'stops memberDetails from being displayed when column header clicked to sort dgv
			Return
		End If

		currentRecord = row.Index + 1   'save the record as the row selected

		Try
			memberID = row.Cells(0).Value.ToString()

			txtID.Clear()   'clear all inputs
			txtName.Clear()
			dtpDOB.ResetText()
			txtEmail.Clear()
			txtPhone.Clear()
			cmbInstrument.ResetText()
			cmbLevel.ResetText()
			chkPhotoPerm.ResetText()
			txtContName.Clear()
			txtContPhone.Clear()
			chkPSB.Checked = False
			chkPYTB.Checked = False
			chkPBB.Checked = False
			chkStarters.Checked = False
			cmbRole.ResetText()

			'display details
			Dim oneMember As memberInfo 'pointer to structure
			Dim index As Integer
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

			Dim totalRecords As Integer = LOF(1) / Len(oneMember)
			For index = 1 To totalRecords
				FileGet(1, oneMember)
				If oneMember.id = memberID Then     'if read id matches id selected in dgv display structure
					txtID.Text = String.Format(oneMember.id)
					txtName.Text = String.Format(oneMember.name)
					dtpDOB.Text = String.Format(oneMember.dob)
					txtEmail.Text = String.Format(oneMember.email)
					txtPhone.Text = String.Format(oneMember.phone)
					cmbInstrument.Text = String.Format(oneMember.instrument)
					cmbLevel.Text = String.Format(oneMember.level)
					txtContName.Text = String.Format(oneMember.contName)
					txtContPhone.Text = String.Format(oneMember.contPhone)

					'checking checkboxes
					If oneMember.photoPerm = True Then
						chkPhotoPerm.CheckState = CheckState.Checked
					Else
						chkPhotoPerm.CheckState = CheckState.Unchecked
					End If

					'convert stored string into boolean so checkboxes can be ticked
					Dim psb As Boolean = groupInput.tickPSB(oneMember.groups)
					If psb = True Then
						chkPSB.CheckState = CheckState.Checked
					End If

					Dim pytb As Boolean = groupInput.tickPYTB(oneMember.groups)
					If pytb = True Then
						chkPYTB.CheckState = CheckState.Checked
					End If

					Dim pbb As Boolean = groupInput.tickPBB(oneMember.groups)
					If pbb = True Then
						chkPBB.CheckState = CheckState.Checked
					End If

					Dim starters As Boolean = groupInput.tickStarters(oneMember.groups)
					If starters = True Then
						chkStarters.CheckState = CheckState.Checked
					End If

					If txtID.Text = "" Then
						MessageBox.Show("Display failed")
					End If
				End If
			Next
			FileClose(1)
		Catch ex As Exception   'if fails, give option to retry, else end sub
			If MsgBox("Member details display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				dgvPlayers_CellClick(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Try
			Dim oneMember As memberInfo 'pointer to structure
			Dim recordNumber As Integer = txtID.Text

			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
			FileOpen(2, "tempPlayers.dat", OpenMode.Random,,, Len(oneMember))

			Do While Not EOF(1)
				'if place in file isn't the record number of the record to be deleted, add the record to the temp file
				If Loc(1) <> recordNumber - 1 Then
					FileGet(1, oneMember)
					FilePut(2, oneMember)
				Else
					'if it is the record number of the file to be deleted, skip the record and dno't write it to temp file
					FileGet(1, oneMember)
				End If
			Loop
			FileClose(1)
			FileClose(2)

			Kill("players.dat")
			Rename("tempPlayers.dat", "players.dat")
			MsgBox("Player deleted")

			dgvRefresh() 'refresh the dgv

		Catch ex As Exception   'if fails, give option to retry, else end sub
			If MsgBox("Member details display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnDelete_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Try
			Dim oneMember As memberInfo 'pointer to structure
			Dim index As Integer
			FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

			'automatic id creation by searching file for last id
			Dim totalRecords As Integer = LOF(1) / Len(oneMember)
			Dim searchID As Integer = "00001"
			'if not records in the file, new id must be the first possible id
			If totalRecords = 0 Then
				txtID.Text = "00001"
			End If
			'search for available id
			For index = 1 To totalRecords
				FileGet(1, oneMember)
				If searchID = oneMember.id Then
					searchID += 1 'if the id is found, +1 to id
				End If
			Next

			Dim idString As String = searchID.ToString()
			Dim idLen As Integer = Len(idString)
			Dim finalID As String

			'pad out start of id with 0's
			For i = 1 To 5 - idLen
				finalID = "0" & finalID
			Next
			txtID.Text = finalID

			'validation
			playersValidation(txtID.Text, txtName.Text, txtEmail.Text, txtPhone.Text, cmbRole.Text, cmbLevel.Text,
							  cmbInstrument.Text, chkPhotoPerm.Checked, txtContName.Text, txtContPhone.Text)

			'convert groups checked into string so can be displayed in listView
			Dim groups As String = groupInput.groups(chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)

			'populate structure
			oneMember.id = txtID.Text
			oneMember.name = txtName.Text
			oneMember.dob = dtpDOB.Text
			oneMember.email = txtEmail.Text
			oneMember.phone = txtPhone.Text
			oneMember.instrument = cmbInstrument.Text
			oneMember.level = cmbLevel.Text
			oneMember.photoPerm = chkPhotoPerm.Checked
			oneMember.contName = txtContName.Text
			oneMember.contPhone = txtContPhone.Text
			oneMember.groups = groups

			FilePut(1, oneMember, totalRecords + 1) '+1 append to file
			FileClose(1)
			MsgBox("Player added")

			dgvRefresh() 'refresh the dgv

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("New player failed to add to system", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnAdd_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear all inputs
		txtID.Clear()
		txtName.Clear()
		dtpDOB.ResetText()
		txtEmail.Clear()
		txtPhone.Clear()
		cmbInstrument.ResetText()
		cmbLevel.ResetText()
		chkPhotoPerm.CheckState = False
		cmbRole.ResetText()
		chkPSB.CheckState = False
		chkPYTB.CheckState = False
		chkPBB.CheckState = False
		chkStarters.CheckState = False
		txtContName.Clear()
		txtContPhone.Clear()
		groupInput.checkboxes()
	End Sub
	'if any input is changed, the changes are stored so the can be undone if needed
	Sub formChanged(sender As Object, e As EventArgs) Handles txtName.Leave, txtPhone.Leave,
	txtEmail.Leave, cmbInstrument.Leave, cmbLevel.Leave, cmbRole.Leave, chkPhotoPerm.Leave, chkPBB.Leave,
	chkPSB.Leave, chkPYTB.Leave, chkStarters.Leave, txtContName.Leave, txtContPhone.Leave, dtpDOB.Leave
		Try
			'if a button has been clicked execute code for the button
			If ActiveControl.Name = "btnUndo" Then
				btnUndo_click(sender, e)
			ElseIf ActiveControl.Name = "btnAdd" Then
				btnAdd_Click(sender, e)
			ElseIf ActiveControl.Name = "btnClear" Then
				btnClear_Click(sender, e)
			ElseIf ActiveControl.Name = "btnDelete" Then
				btnDelete_Click(sender, e)
			ElseIf ActiveControl.Name = "btnUpdate" Then
				btnUpdate_Click(sender, e)

			Else
				'saves the data in the form to a dynamic array so changes can be restored when btnUndo clicked
				Dim changeRecorded As Boolean = False

				For i = pointer To undo.Length
					If changeRecorded = False Then 'only store if a change has been made
						If undo.Length - 1 - (lengthCount * 13) < 14 Then 'if no empty space, add more elements to the array
							ReDim Preserve undo(UBound(undo) + 14)
						End If
						If undo(i) = Nothing And i > 0 Then ' search for empty place in array that is not the first
							Try 'store form data in array
								undo(i) = txtName.Text
								undo(i + 1) = dtpDOB.Text
								undo(i + 2) = txtEmail.Text
								undo(i + 3) = txtPhone.Text
								undo(i + 4) = cmbInstrument.Text
								undo(i + 5) = cmbLevel.Text
								undo(i + 6) = chkPhotoPerm.Checked
								undo(i + 7) = chkPSB.Checked
								undo(i + 8) = chkPYTB.Checked
								undo(i + 9) = chkPBB.Checked
								undo(i + 10) = chkStarters.Checked
								undo(i + 11) = cmbRole.Text
								undo(i + 12) = txtContName.Text
								undo(i + 13) = txtContPhone.Text

								pointer += 14
								count += 1
								lengthCount += 1
								changeRecorded = True

							Catch ex As Exception  'if fails, give option to reset undo management
								If MsgBox("Undo management failed", MsgBoxStyle.OkOnly + vbExclamation, "Error") = vbOK Then
									For j = 0 To undo.Length - 1
										undo(j) = Nothing
									Next
									count = 0
									lengthCount = 0
									pointer = 1
									formChanged(sender, e)
									MsgBox("Undo reset", vbOKOnly + vbInformation)
								End If
							End Try
						End If
					End If
				Next
			End If

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Undo management error", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				formChanged(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Sub btnUndo_click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUndo.Click
		Try
			Dim startLocation As Integer = pointer - 28     ' find the last item that was added to array
			If count = 1 Then 'if only one change has been saved, the form must have been blank previously
				txtName.Clear()
				dtpDOB.ResetText()
				txtPhone.Clear()
				cmbInstrument.ResetText()
				cmbLevel.ResetText()
				chkPhotoPerm.CheckState = CheckState.Unchecked
				chkPSB.CheckState = CheckState.Unchecked
				chkPYTB.CheckState = CheckState.Unchecked
				chkPBB.CheckState = CheckState.Unchecked
				chkStarters.CheckState = CheckState.Unchecked
				cmbRole.ResetText()
				txtContName.Clear()
				txtContPhone.Clear()

				count = 0
				pointer = 0
			ElseIf count = 0 Then
				MsgBox("No changes made to be undone")

			Else 'if more than 1 change
				txtName.Text = undo(startLocation)
				dtpDOB.Text = undo(startLocation + 1)
				txtEmail.Text = undo(startLocation + 2)
				txtPhone.Text = undo(startLocation + 3)
				cmbInstrument.Text = undo(startLocation + 4)
				cmbLevel.Text = undo(startLocation + 5)

				'checking checkboxes
				If undo(startLocation + 6) = True Then
					chkPhotoPerm.CheckState = CheckState.Checked
				Else
					chkPhotoPerm.CheckState = CheckState.Unchecked
				End If
				If undo(startLocation + 7) = True Then
					chkPSB.CheckState = CheckState.Checked
				Else
					chkPSB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 8) = True Then
					chkPYTB.CheckState = CheckState.Checked
				Else
					chkPYTB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 9) = True Then
					chkPBB.CheckState = CheckState.Checked
				Else
					chkPBB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 10) = True Then
					chkStarters.CheckState = CheckState.Checked
				Else
					chkStarters.CheckState = CheckState.Unchecked
				End If

				cmbRole.Text = undo(startLocation + 11)
				txtContName.Text = undo(startLocation + 12)
				txtContPhone.Text = undo(startLocation + 13)

				count = count - 1
				pointer = pointer - 28
			End If

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Undo failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnUndo_click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		If MsgBox("Logout?", MsgBoxStyle.YesNo + vbExclamation) = vbYes Then
			Application.Exit()
		End If
	End Sub
	'opening forms when menu clicked
	Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
		userDetails.Show()
		Me.Hide()
	End Sub
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		home.Show()
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

	Private Sub InstrumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentsToolStripMenuItem.Click
		viewInstrument.Show()
		Me.Hide()
	End Sub
End Class