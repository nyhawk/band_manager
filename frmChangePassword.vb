Public Class frmChangePassword
	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		If txtPassword.Text = "" Then
			MsgBox("New password must be entered", vbExclamation, "Change password")
			Exit Sub
		ElseIf txtConfirm.Text = "" Then
			MsgBox("New password must be entered twice", vbExclamation, "Change password")
			Exit Sub
		ElseIf txtPassword.text.Equals(txtConfirm.Text) = False Then
			MsgBox("Passwords entered do not match", vbExclamation, "Change password")
			Exit Sub
		ElseIf Len(txtPassword.text) < 8 Then
			MsgBox("Password must be at least 8 characters long", vbExclamation, "Change password")
			Exit Sub
		ElseIf Len(txtPassword.Text) > 20 Then
			MsgBox("Maximum password length is 20 characters", vbExclamation, "Change password")
			Exit Sub
		End If

		Dim oneMember As memberInfo 'pointer to structure
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
		FileGet(1, oneMember, frmLogin.userRecord)
		oneMember.password = txtPassword.Text   'save password

		'find member access
		If oneMember.role.Contains("Conductor") Then
			frmLogin.role = "conductor"

		ElseIf oneMember.role.Contains("Librarian") Then
			frmLogin.role = "librarian"

		ElseIf oneMember.role.Contains("Instrument steward") Then
			frmLogin.role = "instruments"

		ElseIf oneMember.role.Contains("Event coordinator") Then
			frmLogin.role = "events"

		ElseIf oneMember.role.Contains("Committee member") Then
			frmLogin.role = "committee member"

		ElseIf oneMember.role.Contains("Treasurer") Then
			frmLogin.role = "treasurer"

		ElseIf oneMember.role.Contains("Player") Then
			frmLogin.role = "player"

		ElseIf oneMember.role.Contains("Dep") Then
			frmLogin.role = "dep"
		End If

		FilePut(1, oneMember, frmLogin.userRecord)  'update file
		FileClose(1)
		MsgBox("Password updated", vbInformation, "Change password")

		frmHome.Left = Me.Left
		frmHome.Top = Me.Top
		frmHome.Show()
		Me.Close()
	End Sub
End Class