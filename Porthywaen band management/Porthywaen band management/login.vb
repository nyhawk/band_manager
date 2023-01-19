Public Class login
	Public Shared role As String = ""
	Public Shared userID As String = ""
	Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		Dim oneMember As memberInfo
		Dim found As Boolean

		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords
			FileGet(1, oneMember)

			'find member in file
			If oneMember.id = txtID.Text Then
				If oneMember.name.Contains(txtName.Text) Then
					found = True
					userID = oneMember.id

					'find member access
					If oneMember.role.Contains("Conductor") Then
						role = "conductor"

					ElseIf onemember.role.Contains("Librarian") Then
						role = "librarian"

					ElseIf onemember.role.Contains("Instrument steward") Then
						role = "instruments"

					ElseIf onemember.role.Contains("Event coordinator") Then
						role = "events"

					ElseIf onemember.role.Contains("Committee member") Then
						role = "committee member"

					ElseIf onemember.role.Contains("Treasurer") Then
						role = "treasurer"

					ElseIf oneMember.role.Contains("Player") Then
						role = "player"
					End If
				End If
			End If
		Next

		If found = False Then
			MsgBox("Incorrect ID")
		Else
			home.Show()
			Me.Hide()
		End If

		FileClose(1)
	End Sub
End Class