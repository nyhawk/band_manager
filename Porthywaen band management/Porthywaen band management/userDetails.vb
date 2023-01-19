Public Class userDetails
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Try
			players.btnUpdate_Click(sender, e)  'uses same data as players so players sub can be called
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
			players.btnClear_Click(sender, e) 'has same input fields as players so players sub can be called
		Catch ex As Exception   'if fails, ask to retry, else end execution of sub
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
			players.formChanged(sender, e)  'has same input fields as players so players sub can be called
		Catch ex As Exception 'if fails, ask to retry, else end execution of sub
			If MsgBox("Undo management failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.formChanged(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
		Try
			players.btnUndo_click(sender, e)    'has same input fields as players so players sub can be called
		Catch ex As Exception 'if fails, ask to retry, else end execution of sub
			If MsgBox("Undo failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				players.btnUndo_click(sender, e)
			Else
				Exit Sub
			End If
		End Try
	End Sub

	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click
		players.Show()
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