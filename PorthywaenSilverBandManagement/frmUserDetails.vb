Public Class frmUserDetails
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim oneMember As memberInfo 'pointer to structure
		'validation
		Dim validationFailed = frmPlayers.playersValidation("User details", txtID.Text.Trim(), txtName.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), cmbRole.Text.Trim(), cmbLevel.Text.Trim(),
					  cmbInstrument.Text.Trim(), txtContName.Text.Trim(), txtContPhone.Text.Trim(), dtpDOB.Text.Trim())
		If validationFailed = True Then
			Exit Sub
		End If
		'converting checkboxes to a string - groups validated in function
		Dim groups As String = groupInput.groups("User details", chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)
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
		FilePut(1, oneMember, frmLogin.userRecord)
		FileClose(1)
		MsgBox("Your details have updated", vbInformation, "User details")
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear all inputs
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



	Private Sub userDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Shown
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None

		dtpDOB.MaxDate = Date.Today

		Dim oneMember As memberInfo

		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords
			FileGet(1, oneMember)

			'find member in file
			If oneMember.id.Contains(frmLogin.userID) Then
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
					MsgBox("Display failed", vbExclamation, "User details")
				End If
			End If
		Next
		FileClose(1)
	End Sub
End Class