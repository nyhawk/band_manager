Public Class frmLogin
	Public Shared role As String = ""
	Public Shared userID As String = ""
	Public Shared userRecord As Integer
	Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		If txtName.Text = "" Then
			MsgBox("Enter your name", vbExclamation, "Login")
			txtPassword.Clear()
			Exit Sub
		ElseIf txtPassword.Text = "" Then
			MsgBox("Enter password", vbExclamation, "Login")
			Exit Sub
		End If
		Dim oneMember As memberInfo
		Dim found As Boolean

		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		Dim index As Integer
		For index = 1 To totalRecords
			FileGet(1, oneMember)

			'find member in file
			If oneMember.password.Contains(txtPassword.Text) Then
				If oneMember.name.Contains(txtName.Text) Then
					found = True
					userID = oneMember.id
					userRecord = index

					If Trim(oneMember.password) = Trim(oneMember.id) Then
						frmChangePassword.Show()
						Me.Close()
						FileClose(1)
						Exit Sub
					End If

					'find member access
					If oneMember.role.Contains("Conductor") Then
						role = "conductor"

					ElseIf oneMember.role.Contains("Librarian") Then
						role = "librarian"

					ElseIf oneMember.role.Contains("Instrument steward") Then
						role = "instruments"

					ElseIf oneMember.role.Contains("Event coordinator") Then
						role = "events"

					ElseIf oneMember.role.Contains("Committee member") Then
						role = "committee member"

					ElseIf oneMember.role.Contains("Treasurer") Then
						role = "treasurer"

					ElseIf oneMember.role.Contains("Player") Then
						role = "player"

					ElseIf oneMember.role.Contains("Dep") Then
						role = "dep"
					End If
				End If
			End If
		Next

		FileClose(1)

		If found = False Then
			MsgBox("Incorrect login details.", vbExclamation, "Login")
			txtPassword.Clear()
		Else
			frmHome.Left = Me.Left
			frmHome.Top = Me.Top
			frmHome.Show()
			Me.Close()
		End If


	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		If txtName.Text = "" Then
			MsgBox("Name must be entered in order to reset password", vbExclamation, "Password reset")
			Exit Sub
		End If
		Dim oneMember As memberInfo 'pointer to structure
		Dim found = False
		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))
		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords
			FileGet(1, oneMember)
			If Trim(oneMember.name) = txtName.Text Then
				oneMember.password = oneMember.id   'save password
				FilePut(1, oneMember, index)  'update file
				FileClose(1)
				MsgBox("Password reset to ID", vbInformation)
				found = True
				Exit For
			End If
		Next
		FileClose(1)
		If found = False Then
			MsgBox("Name not found in file", vbExclamation, "Reset password")
		End If
	End Sub
End Class