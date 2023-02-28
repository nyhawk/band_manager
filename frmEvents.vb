
Imports System.Text.RegularExpressions
Structure calendarEvent
	<VBFixedString(5)> Dim eventID As String
	<VBFixedString(5)> Dim responseID As String
	<VBFixedString(100)> Dim address As String
	<VBFixedString(10)> Dim postcode As String
	<VBFixedString(22)> Dim eventDate As Date
	<VBFixedString(15)> Dim startTime As String
	<VBFixedString(15)> Dim arrivalTime As String
	<VBFixedString(24)> Dim groups As String
	<VBFixedString(300)> Dim music As String
	<VBFixedString(5)> Dim customerID As String
	<VBFixedString(50)> Dim contName As String
	<VBFixedString(11)> Dim contPhone As String
	<VBFixedString(50)> Dim contEmail As String
End Structure
Structure responses
	<VBFixedString(5)> Dim responseID As String
	<VBFixedString(300)> Dim playing As String
End Structure
Public Class frmEvents
	Shared selectedDate As Date
	Public Shared currentRecord As Integer = 0
	Public Shared eventID As Integer

	Public Shared eventIdDate As String 'used to display some event details in eventResponses form
	Public Shared eventAddress As String 'used to display some event details in eventResponses form
	Function eventsValidation(sender, address, postcode, startTime, arrivalTime, music, customerID, customerName, customerPhone, customerEmail, eventDate)
		Dim validationFailed As Boolean
		Dim postcodeFormat As String = "^[A-Z]{1,2}[0-9]{1,2}[A-Z]?\s?[0-9][A-Z]{2}([\s]+)?$"
		Dim postcodeMatch As Match = Regex.Match(postcode, postcodeFormat)
		Dim emailFormat As String = "^[A-Za-z0-9._%-]+\@[A-Za-z0-9_%-]+\.+[A-Za-z0-9_%-]+([\s]+)?$"
		Dim emailMatch As Match = Regex.Match(customerEmail.trim(), emailFormat)
		'validation
		If address = "" Then
			MsgBox("Enter the address", vbExclamation, "Events")
			validationFailed = True

		ElseIf startTime = "" Then
			MsgBox("Enter the start time", vbExclamation, "Events")
			validationFailed = True

		ElseIf arrivalTime = "" Then
			MsgBox("Enter the arrival time", vbExclamation, "Events")
			validationFailed = True

		ElseIf music = "" Then
			MsgBox("Enter the music", vbExclamation, "Events")
			validationFailed = True

		ElseIf customerName = "" Then
			MsgBox("Enter the customer's name", vbExclamation, "Events")
			validationFailed = True

		ElseIf customerPhone = "" Then
			MsgBox("Enter the customer's phone number", vbExclamation, "Events")
			validationFailed = True

		ElseIf customerPhone.length <> 11 Then
			MsgBox("Phone number must be 11 characters long", vbExclamation, "Events")
			validationFailed = True

		ElseIf CustomerID = "" Then
			MsgBox("Enter the customer's ID", vbExclamation, "Events")
			validationFailed = True

		ElseIf CustomerID.length <> 5 Then
			MsgBox("Customer's ID must be 5 characters long", vbExclamation, "Events")
			validationFailed = True

		ElseIf (emailMatch.Success).Equals(False) Then
			MsgBox("Enter a valid email", vbExclamation, "Events")
			validationFailed = True

		ElseIf (postcodeMatch.Success).Equals(False) Then
			MsgBox("Enter a valid postcode", vbExclamation, "Events")
			validationFailed = True

		ElseIf Year(eventDate) < 1900 Then
			MsgBox("Date is outside an acceptable range", vbExclamation, "Events")
			validationFailed = True
		End If

		'check the date is available
		Dim oneEvent As calendarEvent
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		While EOF(1) = False
			FileGet(1, oneEvent)
			If oneEvent.eventDate.ToString.Contains(eventDate) Then
				If sender.name = "btnAdd" Then
					If MsgBox("An event has already been entered for this date, would you like to add it to the system anyway?", vbYesNo + vbInformation, "Events") = vbNo Then
						validationFailed = True
						Exit While
					End If
				End If
			End If
		End While
		FileClose(1)
		Return validationFailed
	End Function
	Private Sub dgvday_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDay.CellClick
		Dim row As DataGridViewRow = dgvDay.CurrentRow
		currentRecord = row.Index + 1
		eventID = row.Cells(0).Value.ToString

		'stops memberDetails from being diplayed when column header clicked to sort dgv
		If e.RowIndex = -1 Then
			Exit Sub

			'stop details being displayed when a response is marked
		ElseIf TypeOf dgvday.Rows(e.RowIndex).Cells(e.ColumnIndex) Is DataGridViewCheckBoxCell Then  'validation
			Exit Sub
		End If


		'clear all inputs
		txtID.Clear()
		txtAddress.Clear()
		dtpDate.ResetText()
		txtCustomerEmail.Clear()
		txtStartTime.Clear()
		txtMusic.ResetText()
		txtCustomerName.Clear()
		txtCustomerPhone.Clear()
		chkPSB.Checked = False
		chkPYTB.Checked = False
		chkPBB.Checked = False
		chkStarters.Checked = False

		Try
			'display details
			Dim oneEvent As calendarEvent 'pointer to structure
			Dim index As Integer

			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
			Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)

				'if read id matches id selected in dgv display structure 
				If oneEvent.eventID = eventID Then
					txtID.Text = String.Format(oneEvent.eventID).Trim()
					txtAddress.Text = String.Format(oneEvent.address).Trim()
					dtpDate.Text = String.Format(oneEvent.eventDate).Trim()
					txtCustomerEmail.Text = String.Format(oneEvent.contEmail).Trim()
					txtCustomerPhone.Text = String.Format(oneEvent.contPhone).Trim()
					txtStartTime.Text = String.Format(oneEvent.startTime).Trim()
					txtArrivalTime.Text = String.Format(oneEvent.arrivalTime).Trim()
					txtMusic.Text = String.Format(oneEvent.music).Trim()
					txtCustomerName.Text = String.Format(oneEvent.contName).Trim()
					txtCustomerID.Text = String.Format(oneEvent.customerID).Trim()
					txtPostcode.Text = String.Format(oneEvent.postcode).Trim()

					'data to be displayed in eventResponses form
					eventIdDate = "Event ID: " & txtID.Text.Trim() & "     Date: " & dtpDate.Text.Trim()
					eventAddress = "Address: " & txtAddress.Text.Trim()

					'convert stored string into boolean so checkboxes can be ticked
					Dim psb As Boolean = groupInput.tickPSB(oneEvent.groups)
					If psb = True Then
						chkPSB.CheckState = CheckState.Checked
					End If

					Dim pytb As Boolean = groupInput.tickPYTB(oneEvent.groups)
					If pytb = True Then
						chkPYTB.CheckState = CheckState.Checked
					End If

					Dim pbb As Boolean = groupInput.tickPBB(oneEvent.groups)
					If pbb = True Then
						chkPBB.CheckState = CheckState.Checked
					End If

					Dim starters As Boolean = groupInput.tickStarters(oneEvent.groups)
					If starters = True Then
						chkStarters.CheckState = CheckState.Checked
					End If

					If txtID.Text = "" Then
						MessageBox.Show("Display failed")
					End If
				End If
			Next
		Catch ex As Exception   'if an error occurs, allow user to retry, else end sub
			If MsgBox("Display failed", vbExclamation + vbRetryCancel, "Events") = vbRetry Then
				FileClose(1)
				dgvday_CellClick(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
		FileClose(1)
		'groupInput.checkboxes() 'add text to checkboxes as sometimes disappears
	End Sub

	Private Sub cdrCalendar_MouseClick(sender As Object, e As MouseEventArgs) Handles cdrCalendar.MouseDown
		selectedDate = cdrCalendar.SelectionStart
		dtpDate.Value = selectedDate    'set the date in the dtp as the one selected in the calendar
		Dim oneEvent As calendarEvent
		Dim index As Integer
		Dim eventsFound As Boolean = False
		dgvDay.Rows.Clear()

		Try
			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

			Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)
				'add any events with the selected date into the dgv
				If oneEvent.eventDate = selectedDate Then
					dgvDay.Rows.Add(oneEvent.eventID.Trim(), oneEvent.address.Trim(), oneEvent.eventDate, oneEvent.startTime.Trim(),
								oneEvent.groups.Trim(), oneEvent.music.Trim())
					eventsFound = True
				End If
			Next
		Catch ex As Exception 'if an error occurs, allow user to retry, else end sub
			If MsgBox("Display failed", vbExclamation + vbRetryCancel, "Events") = vbRetry Then
				FileClose(1)
				cdrCalendar_MouseClick(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
		FileClose(1)

		If eventsFound = False Then
			MsgBox("No events booked for the selected date", vbInformation, "Events")
		End If
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		'converting checkboxes to a string
		Dim groups As String = groupInput.groups("Events", chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)
		If groups = "False" Then
			FileClose(1)
			Exit Sub
		End If
		Dim oneEvent As calendarEvent 'pointer to structure

		'validation
		Dim validationfailed = eventsValidation(sender, txtAddress.Text.Trim(), txtPostcode.Text.Trim(), txtStartTime.Text.Trim(),
												txtArrivalTime.Text.Trim(), txtMusic.Text.Trim(), txtCustomerID.Text.Trim(), txtCustomerName.Text.Trim(),
												txtCustomerPhone.Text.Trim(), txtCustomerEmail.Text.Trim(), dtpDate.Text.Trim())
		If validationfailed = True Then 'if validation has failed, exit so user can change inputs and no data added
			FileClose(1)
			Exit Sub
		End If

		Try
			'storing inputs into structure
			oneEvent.eventID = txtID.Text
			oneEvent.address = txtAddress.Text
			oneEvent.eventDate = dtpDate.Text
			oneEvent.startTime = txtStartTime.Text
			oneEvent.arrivalTime = txtArrivalTime.Text
			oneEvent.postcode = txtPostcode.Text
			oneEvent.groups = groups
			oneEvent.music = txtMusic.Text
			oneEvent.customerID = txtCustomerID.Text
			oneEvent.contEmail = txtCustomerEmail.Text
			oneEvent.contName = txtCustomerName.Text
			oneEvent.contPhone = txtCustomerPhone.Text

			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
			FilePut(1, oneEvent, currentRecord) 'add to file at correct place
			FileClose(1)

		Catch ex As Exception
			If MsgBox("Update failed", vbExclamation + vbRetryCancel, "Events") = vbRetry Then
				FileClose(1)
				btnUpdate_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try

		Try
			'display members in dataGridView
			Dim index As Integer
			dgvDay.Rows.Clear()
			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

			Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)
				dgvDay.Rows.Add(oneEvent.eventID.Trim(), oneEvent.address.Trim(), oneEvent.eventDate, oneEvent.startTime.Trim(),
							oneEvent.groups.Trim(), oneEvent.music.Trim())
			Next
		Catch ex As Exception  'if an error occurs, allow user to retry, else end sub
			MsgBox("Display failed", vbExclamation, "Events")
			FileClose(1)
			Exit Sub
		End Try
		FileClose(1)
		'groupInput.checkboxes() 'add text to checkboxes
		MsgBox("Event updated", vbInformation, "Events")
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		'validation
		Dim validationfailed = eventsValidation(sender, txtAddress.Text.Trim(), txtPostcode.Text.Trim(), txtStartTime.Text.Trim(),
												txtArrivalTime.Text.Trim(), txtMusic.Text.Trim(), txtCustomerID.Text.Trim(), txtCustomerName.Text.Trim(),
												txtCustomerPhone.Text.Trim(), txtCustomerEmail.Text.Trim(), dtpDate.Text.Trim())
		If validationfailed = True Then 'if validation has failed, exit so user can change inputs and no data added
			FileClose(1)
			Exit Sub
		End If

		'format groups
		Dim groups As String = groupInput.groups("Events", chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)
		If groups = "False" Then
			FileClose(1)
			Exit Sub
		End If
		Dim oneEvent As calendarEvent   'pointer to structure

		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		Dim index As Integer
		Dim searchID As Integer = "00001"
		Dim finalID As String

		Try     'automatic id creation
			'if not records in the file, new id must be the first possible id
			If totalRecords = 0 Then
				txtID.Text = "00001"
			End If

			For index = 1 To totalRecords
				FileGet(1, oneEvent)

				'search for available id
				If searchID <= oneEvent.eventID.TrimStart("0") Then
					searchID = oneEvent.eventID.TrimStart("0") + 1
				End If
			Next
			Dim idString As String = searchID.ToString()
			Dim idLen As Integer = Len(idString)
			finalID = idString.PadLeft(5, "0")

			txtID.Text = finalID
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Automatic ID generation failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				btnAdd_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try

		Try
			'populate structure
			oneEvent.eventID = finalid
			oneEvent.address = txtAddress.Text
			oneEvent.eventDate = dtpDate.Text
			oneEvent.startTime = txtStartTime.Text
			oneEvent.arrivalTime = txtArrivalTime.Text
			oneEvent.postcode = txtPostcode.Text
			oneEvent.groups = groups
			oneEvent.music = txtMusic.Text
			oneEvent.customerID = txtCustomerID.Text
			oneEvent.contEmail = txtCustomerEmail.Text
			oneEvent.contName = txtCustomerName.Text
			oneEvent.contPhone = txtCustomerPhone.Text

			FilePut(1, oneEvent, totalRecords + 1)
			FileClose(1)
			MsgBox("Event added", vbInformation, "Events")

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Event failed to be added", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				btnAdd_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try

		Try
			dgvDay.Rows.Clear()
			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

			totalRecords = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)
				dgvDay.Rows.Add(oneEvent.eventID.Trim(), oneEvent.address.Trim(), oneEvent.eventDate, oneEvent.startTime.Trim(), oneEvent.groups.Trim(),
							oneEvent.music.Trim())
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, inform user
			MsgBox("Display failed", vbExclamation, "Error")
		End Try
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If txtID.Text = "" Then
			MsgBox("Event cannot be deleted. No ID stored", vbExclamation, "Events")
			Exit Sub
		End If
		Dim oneEvent As calendarEvent

		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		FileOpen(2, "tempEvents.dat", OpenMode.Random,,, Len(oneEvent))
		Try
			Do While Not EOF(1) 'search file for the record to be deleted
				If Loc(1) <> currentRecord - 1 Then  'if is not the recpord to be deleted, add to temp file
					FileGet(1, oneEvent)
					FilePut(2, oneEvent)
				Else
					FileGet(1, oneEvent)    'if it is the record to be deleted, skip
				End If
			Loop
			FileClose(1)
			FileClose(2)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Deletion failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				btnDelete_Click(sender, e)
			Else
				FileClose(1)
				FileClose(2)
				Exit Sub
			End If
		End Try
		Kill("eventsCalendar.dat")
		Rename("tempEvents.dat", "eventsCalendar.dat")

		MsgBox("Record deleted", vbInformation, "Events")

		Try
			'display members in dataGridView
			Dim index As Integer
			dgvDay.Rows.Clear()
			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

			Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)    'add each record to dgv
				dgvDay.Rows.Add(oneEvent.eventID.Trim(), oneEvent.address.Trim(), oneEvent.eventDate, oneEvent.startTime.Trim(),
								oneEvent.groups.Trim(), oneEvent.music.Trim())
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, inform user
			MsgBox("Display failed", vbExclamation, "Error")
		End Try
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear inputs
		txtID.Clear()
		txtAddress.Clear()
		dtpDate.ResetText()
		txtCustomerEmail.Clear()
		txtStartTime.Clear()
		txtMusic.ResetText()
		txtCustomerName.Clear()
		txtCustomerPhone.Clear()
		chkPSB.Checked = False
		chkPYTB.Checked = False
		chkPBB.Checked = False
		chkStarters.Checked = False
		txtCustomerID.Clear()
		txtPostcode.Clear()
		txtArrivalTime.Clear()
	End Sub
	Private Sub btnSaveResponse_Click(sender As Object, e As EventArgs) Handles btnSaveResponse.Click
		Dim oneResponse As responses 'pointer
		Dim totalrecords As Integer
		Dim checked As Boolean
		Dim recorded As Boolean
		Dim found As Boolean
		Dim recordNumber As Integer
		Dim readPlayers As String
		Dim players As String()

		For rowNumber = 0 To dgvDay.Rows.Count - 1  'for each row in dgv
			FileClose(1)
			FileOpen(1, "eventsResponses.dat", OpenMode.Random,,, Len(oneResponse))
			totalrecords = LOF(1) / Len(oneResponse)
			'find record and get all data
			For records = 1 To totalrecords
				FileGet(1, oneResponse)
				If oneResponse.responseID = dgvDay.Rows(rowNumber).Cells(0).Value Then
					readPlayers = oneResponse.playing.Trim()
					players = readPlayers.Split(";")
					recordNumber = records
					found = True
					Exit For
				End If
			Next

			'saving availibility in variable
			If dgvDay.Rows(rowNumber).Cells(6).Value = Nothing Then
				checked = False
			Else
				checked = True
			End If

			'saving availibility to array
			If players IsNot Nothing Then
				For index = 0 To players.Length - 1
					recorded = False

					If players(index) = "" Then
						recorded = True
						Exit For
					End If

					If found = True Then    'check if response needs to be updated
						If players(index).Contains(frmLogin.userID & "," & checked) = True Then
							'check if same availibility already recorded
							MsgBox("Availibility has already been recorded for event " & dgvDay.Rows(rowNumber).Cells(0).Value & " in " & dgvDay.Rows(rowNumber).Cells(1).Value.Trim(","), vbExclamation, "Events")
							recorded = True
							Exit For

						ElseIf players(index).Contains(frmLogin.userID & ",") = True Then
							'check if availibility recorded, but different
							If MsgBox("Availibility for event " & dgvDay.Rows(rowNumber).Cells(0).Value & " in " & dgvDay.Rows(rowNumber).Cells(1).Value.Trim(",") & " is different to inputted reponse. Would you like to update it?", vbYesNo + vbInformation, "Events") = vbYes Then
								'update availibility
								players(index) = (frmLogin.userID & "," & checked)
								Dim newResponses As String = ""
								For i = 0 To players.Length - 1
									newResponses = newResponses & players(i) & ";"
								Next
								oneResponse.playing = newResponses
								FilePut(1, oneResponse, recordNumber)
								MsgBox("Response updated", vbInformation, "Events")
								recorded = True
								Exit For
							Else 'don't want to update availibility
								recorded = True
								Exit For
							End If
						End If
					End If
				Next
			End If

			If recorded = False Then
				If found = False Then    'no availibility has been recorded for this event yet so add to file
					oneResponse.responseID = dgvDay.Rows(rowNumber).Cells(0).Value
					oneResponse.playing = frmLogin.userID & "," & checked & ";"
					FilePut(1, oneResponse, totalrecords + 1)

				ElseIf found = True Then 'if it is a new response for a recorded event
					Dim marksString As String = ""
					'put all array elements into a string so thay can be stored
					For marksElement = 0 To players.Length - 1
						If players(marksElement) <> "" Then
							If marksString = Nothing Then
								marksString = players(marksElement) & ";"
							Else
								marksString = marksString & players(marksElement) & ";"
							End If
						End If
					Next
					'add the new response to the string
					marksString = marksString & frmLogin.userID & "," & checked & ";"
					'store the responses
					oneResponse.playing = marksString
					FilePut(1, oneResponse, recordNumber)
					recorded = True
				End If
			End If
		Next
		FileClose(1)
		MsgBox("Availibility saved", vbInformation, "Events")
	End Sub
	Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click, MyBase.Load
		eventIdDate = ""
		'get menustrip for form
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None

		Dim oneEvent As calendarEvent
		Dim index As Integer
		dgvDay.Rows.Clear()
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		For index = 1 To totalRecords
			FileGet(1, oneEvent)
			dgvDay.Rows.Add(oneEvent.eventID.Trim(), oneEvent.address.Trim(), oneEvent.eventDate, oneEvent.startTime.Trim(), oneEvent.groups.Trim(),
							oneEvent.music.Trim())
		Next
		FileClose(1)
	End Sub

	Private Sub btnPlayers_Click(sender As Object, e As EventArgs) Handles btnPlayers.Click
		If eventIdDate = Nothing Then
			MsgBox("An event must be selected before viewing responses", vbExclamation, "Event responses")
			Exit Sub
		Else
			frmPlayerEventsResponse.Show()
			Me.Close()
		End If

	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
		'print dgv
		pdcPrint.DefaultPageSettings.Landscape = True
		ppdPrint.ShowDialog()
	End Sub

	Private Sub pdcPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdcPrint.PrintPage
		Try 'create bitmap of dgv so it can be printed
			Dim bm As New Bitmap(700, dgvDay.Height)
			dgvDay.DrawToBitmap(bm, New Rectangle(30, 30, 700, dgvDay.Height))
			e.Graphics.DrawImage(bm, 0, 0)
		Catch ex As Exception
			If MsgBox("Print failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				pdcPrint_PrintPage(sender, e)
			End If
		End Try
	End Sub
End Class