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
	<VBFixedString(20)> Dim password As String
End Structure
Public Class frmPlayers
	Shared memberID As String
	Shared currentRecord As Integer = 0
	Sub dgvRefresh()
		Dim index As Integer
		Dim oneMember As memberInfo 'pointer to structure

		dgvPlayers.Rows.Clear()
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))       'open file

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)       'add all detalis in file to dataGridView
		For index = 1 To totalRecords
			FileGet(1, oneMember)
			dgvPlayers.Rows.Add(oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim(), oneMember.phone.Trim())
		Next
		FileClose(1)
	End Sub
	Function playersValidation(form, id, name, email, phone, role, level, instrument, contName, contPhone, dob)
		Dim emailFormat As String = "^[A-Za-z0-9._%-]+\@[A-Za-z0-9_%-]+\.+[A-Za-z0-9_%-]+([\s]+)?$"
		Dim emailMatch As Match = Regex.Match(email, emailFormat)
		Dim validationFailed As Boolean
		'validation
		If id.length <> 5 Then
			MsgBox("ID is not in the correct format", vbExclamation, form)
			validationFailed = True

		ElseIf name = "" Then
			MsgBox("Enter a name", vbExclamation, form)
			validationFailed = True

		ElseIf email = "" Then
			MsgBox("Enter an email address", vbExclamation, form)
			validationFailed = True

		ElseIf instrument = "" Then
			MsgBox("Enter an instrument", vbExclamation, form)
			validationFailed = True

		ElseIf level = "" Then
			MsgBox("Enter a level", vbExclamation, form)
			validationFailed = True

		ElseIf contName = "" Then
			MsgBox("Enter the name of the emergency contact", vbExclamation, form)
			validationFailed = True

		ElseIf role = "" Then
			MsgBox("Enter a role", vbExclamation, form)
			validationFailed = True

		ElseIf emailMatch.Success = False Then
			MsgBox("The email address is in an incorrect format", vbExclamation, form)
			validationFailed = True

		ElseIf phone.length <> 11 Or contPhone.length <> 11 Then
			MsgBox("Enter a valid phone number", vbExclamation, form)
			validationFailed = True


		ElseIf Year(dob) < 1900 Or Year(dob) > Year(Today) Then
			MsgBox("DOB is outside an acceptable range", vbExclamation, form)
			validationFailed = True
		End If
		Return validationFailed
	End Function
	Private Sub players_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None

		'set maximum date that can be entered as today - no extra validation needed as within properties
		dtpDOB.MaxDate = Date.Today
		dtpDOB.Text = Today

		dgvRefresh() 'add data to dgv
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim oneMember As memberInfo 'pointer to structure
		'validation
		Dim validationFailed = playersValidation("Players", txtID.Text.Trim(), txtName.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), cmbRole.Text.Trim(), cmbLevel.Text.Trim(),
					  cmbInstrument.Text.Trim(), txtContName.Text.Trim(), txtContPhone.Text.Trim(), dtpDOB.Text.Trim())
		If validationFailed = True Then
			FileClose(1)
			Exit Sub
		End If
		'converting checkboxes to a string - groups validated in function
		Dim groups As String = groupInput.groups("Players", chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)

		If groups = "False" Then
			FileClose(1)
			Exit Sub
		End If
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
		oneMember.role = cmbRole.Text

		'storing structure in file
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
		FilePut(1, oneMember, currentRecord)
		FileClose(1)
		MsgBox("Player details updated", vbInformation, "Players")

		dgvRefresh() 'refresh the dgv
	End Sub
	Private Sub dgvPlayers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlayers.CellClick
		Dim row As DataGridViewRow = dgvPlayers.CurrentRow

		If e.RowIndex = -1 Then 'stops memberDetails from being displayed when column header clicked to sort dgv
			Return
		End If

		currentRecord = row.Index + 1   'save the record as the row selected

		memberID = row.Cells(0).Value.ToString()

		txtID.Clear()   'clear all inputs
		txtName.Clear()
		dtpDOB.ResetText()
		txtEmail.Clear()
		txtPhone.Clear()
		cmbInstrument.ResetText()
		cmbLevel.ResetText()
		chkPhotoPerm.Checked = False
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
				txtID.Text = String.Format(oneMember.id).Trim()
				txtName.Text = String.Format(oneMember.name).Trim()
				dtpDOB.Text = String.Format(oneMember.dob).Trim()
				txtEmail.Text = String.Format(oneMember.email).Trim()
				txtPhone.Text = String.Format(oneMember.phone).Trim()
				cmbInstrument.Text = String.Format(oneMember.instrument).Trim()
				cmbLevel.Text = String.Format(oneMember.level).Trim()
				txtContName.Text = String.Format(oneMember.contName).Trim()
				txtContPhone.Text = String.Format(oneMember.contPhone).Trim()
				cmbRole.Text = String.Format(oneMember.role).Trim()

				'checking checkboxes
				If oneMember.photoPerm = True Then
					'chkPhotoPerm.CheckState = CheckState.Checked
					chkPhotoPerm.Checked = True
				Else
					'chkPhotoPerm.CheckState = CheckState.Unchecked
					chkPhotoPerm.Checked = False
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
		'groupInput.checkboxes() 'add text to checkboxes
		Me.Refresh()
	End Sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If txtID.Text = "" Then
			MsgBox("Player cannot be deleted. No ID found")
			Exit Sub
		End If
		Dim oneMember As memberInfo 'pointer to structure

		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
		FileOpen(2, "tempPlayers.dat", OpenMode.Random,,, Len(oneMember))

		Do While Not EOF(1)
			'if place in file isn't the record number of the record to be deleted, add the record to the temp file
			If Loc(1) <> currentRecord - 1 Then
				FileGet(1, oneMember)
				FilePut(2, oneMember)
			Else
				'if it is the record number of the file to be deleted, skip the record and don't write it to temp file
				FileGet(1, oneMember)
			End If
		Loop
		FileClose(1)
		FileClose(2)

		Kill("players.dat")
		Rename("tempPlayers.dat", "players.dat")
		MsgBox("Player deleted", vbInformation, "Players")

		dgvRefresh() 'refresh the dgv
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
			If searchID <= oneMember.id.TrimStart("0") Then
				searchID = oneMember.id.TrimStart("0") + 1
			End If

		Next

		Dim idString As String = searchID.ToString().PadLeft(5, "0")
		txtID.Text = idString

		'validation
		Dim validationFailed = playersValidation("Players", txtID.Text.Trim(), txtName.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), cmbRole.Text.Trim(), cmbLevel.Text.Trim(),
						  cmbInstrument.Text.Trim(), txtContName.Text.Trim(), txtContPhone.Text.Trim(), dtpDOB.Text.Trim())
		If validationFailed = True Then
			FileClose(1)
			Exit Sub
		End If

		'convert groups checked into string so can be displayed in listView
		Dim groups As String = groupInput.groups("Players", chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)
		If groups = "False" Then
			FileClose(1)
			Exit Sub
		End If
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
		oneMember.role = cmbRole.Text
		oneMember.password = txtID.Text 'when member first added set password as id

		FilePut(1, oneMember, totalRecords + 1) '+1 append to file
		FileClose(1)
		MsgBox("Player added", vbInformation, "Players")

		dgvRefresh() 'refresh the dgv
	End Sub
	Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear all inputs
		txtContPhone.Clear()
		txtID.Clear()
		txtName.Clear()
		dtpDOB.Text = Today
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
	End Sub
End Class