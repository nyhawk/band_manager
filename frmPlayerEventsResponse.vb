Public Class frmPlayerEventsResponse
	Private Sub playerEventsResponse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim oneEvent As calendarEvent   'pointers to structures
		Dim oneMember As memberInfo
		Dim oneResponse As responses
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		FileOpen(2, "eventsResponses.dat", OpenMode.Random,,, Len(oneResponse))

		Dim totalRecordsEvent As Integer = LOF(1) / Len(oneEvent)    'find number of records in the file
		Dim index As Integer
		Dim playerID As String
		Dim eventPlayers As Array
		Dim readPlayers As String
		For index = 1 To totalRecordsEvent   'for each record
			FileGet(2, oneResponse)
			'if the selected event is found, store each of the players that responded in an array
			'If oneResponse.responseID.Contains(" ") = False Then
			If oneResponse.responseID = frmEvents.currentRecord Or oneResponse.responseID = frmEvents.eventID Then
				readPlayers = oneResponse.playing.Trim()
				eventPlayers = readPlayers.Split(";")
				Exit For
				'	End If
			End If
		Next
		FileClose(1)
		FileClose(2)

		If eventPlayers.Length = 0 Then
			MsgBox("No responses recorded for this event", vbInformation, "Event responses")
			Exit Sub
		End If

		Dim totalRecordsPlayers As Integer
		For count = 0 To eventPlayers.Length - 1 'get the details of the players that are stored in the array
			FileOpen(3, "players.dat", OpenMode.Random,,, Len(oneMember))
			totalRecordsPlayers = LOF(3) / Len(oneMember)
			playerID = eventPlayers(count)
			For member = 0 To totalRecordsPlayers - 1
				FileGet(3, oneMember)
				If playerID <> "" Then
					If playerID.Contains(oneMember.id) Then
						If playerID.Contains("True") Then
							lstPlayers.Items.Add(New ListViewItem({oneMember.id.Trim(), oneMember.name.Trim(), oneMember.instrument.Trim()}))
							Exit For
						End If
					End If
				End If
			Next
			FileClose(3)
		Next
		FileClose(3)
		lblIdDate.Text = frmEvents.eventIdDate
		lblAddress.Text = frmEvents.eventAddress
	End Sub

	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		frmEvents.Left = Me.Left
		frmEvents.Top = Me.Top
		Me.Close()
		frmEvents.Show()
	End Sub
End Class