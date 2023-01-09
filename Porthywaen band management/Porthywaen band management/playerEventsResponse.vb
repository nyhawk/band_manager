Public Class playerEventsResponse
	Private Sub playerEventsResponse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim oneEvent As calendarEvent
		Dim oneMember As memberInfo
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		Dim index As Integer
		Dim players As Array
		For index = 1 To totalRecords
			FileGet(1, oneEvent)
			If oneEvent.eventID = viewEvents.currentRecord Then
				players = oneEvent.playing.Split(",")
			End If
		Next
		FileClose(1)
		FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneMember))
		For Each playerID In players
			FileGet(2, oneMember)
			If oneMember.id = players(playerID) Then
				lstPlayers.Items.Add(New ListViewItem({oneMember.id, oneMember.name, oneMember.instrument}))
			End If
		Next
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		viewEvents.Show()
		Me.Hide()
	End Sub
End Class