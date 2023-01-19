Public Class loading
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        Dim count As Integer
        count += 1
        If count = 50 Then
            Me.Hide()
            login.Show()
            tmrLoading.Stop()
        End If
    End Sub
End Class