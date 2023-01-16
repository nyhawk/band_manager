Public Class userDetails

	Private Sub userDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Try
			players.btnUpdate_Click(sender, e)
		Catch ex As Exception
			If MsgBox("Update failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.btnUpdate_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		Try
			players.btnClear_Click(sender, e)
		Catch ex As Exception
			If MsgBox("Clear failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.btnClear_Click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub formChanged(sender As Object, e As EventArgs) Handles txtName.Leave, txtPhone.Leave,
	txtEmail.Leave, cmbInstrument.Leave, cmbLevel.Leave, cmbRole.Leave, chkPhotoPerm.Leave, chkPBB.Leave,
	chkPSB.Leave, chkPYTB.Leave, chkStarters.Leave, txtContName.Leave, txtContPhone.Leave, dtpDOB.Leave
		Try
			players.formChanged(sender, e)
		Catch ex As Exception
			If MsgBox("Undo management failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.formChanged(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
		Try
			players.btnUndo_click(sender, e)
		Catch ex As Exception
			If MsgBox("Undo failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.btnUndo_click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub


End Class