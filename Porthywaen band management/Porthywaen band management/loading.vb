Public Class loading
	Public count As Integer
	Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
		count += 1
		If count = 100 Then
			Me.Hide()
			login.Show()
			tmrLoading.Stop()
		End If
	End Sub


End Class