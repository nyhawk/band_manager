
Imports System.Text.RegularExpressions
Structure calendarEvent
	<VBFixedString(5)> Dim eventID As String
	<VBFixedString(5)> Dim customerID As String
	<VBFixedString(100)> Dim address As String
	<VBFixedString(10)> Dim postcode As String
	<VBFixedString(22)> Dim eventDate As Date
	<VBFixedString(15)> Dim startTime As String
	<VBFixedString(15)> Dim arrivalTime As String
	<VBFixedString(24)> Dim groups As String
	<VBFixedString(300)> Dim music As String
	<VBFixedString(200)> Dim playing As String
End Structure
Structure customer
	<VBFixedString(5)> Dim customerID As String
	<VBFixedString(50)> Dim contName As String
	<VBFixedString(11)> Dim contPhone As String
	<VBFixedString(50)> Dim contEmail As String
End Structure
Public Class viewEvents
	Public Shared selectedDate As Date
	Public Shared currentRecord As Integer = 0
	Public Shared eventID As Integer
	Private Sub dgvday_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDay.CellClick
		Dim row As DataGridViewRow = dgvDay.CurrentRow
		currentRecord = row.Index + 1

		'stops memberDetails from being diplayed when column header clicked to sort dgv
		If e.RowIndex = -1 Then
			Return
		End If

		Try
			eventID = row.Cells(0).Value.ToString()

			'clear all inputs
			txtID.Clear()
			txtAddress.Clear()
			dtpDate.ResetText()
			txtEmail.Clear()
			txtTime.Clear()
			txtMusic.ResetText()
			txtContName.Clear()
			txtContPhone.Clear()
			chkPSB.Checked = False
			chkPYTB.Checked = False
			chkPBB.Checked = False
			chkStarters.Checked = False

			'display details
			Dim oneEvent As calendarEvent 'pointer to structure
			Dim onecustomer As customer
			Dim index As Integer
			FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

			Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
			For index = 1 To totalRecords
				FileGet(1, oneEvent)

				'if read id matches id selected in dgv display structure 
				If oneEvent.eventID = eventID Then
					txtID.Text = String.Format(oneEvent.eventID)
					txtAddress.Text = String.Format(oneEvent.address)
					dtpDate.Text = String.Format(oneEvent.eventDate)
					txtEmail.Text = String.Format(onecustomer.contEmail)
					txtContPhone.Text = String.Format(onecustomer.contPhone)
					txtTime.Text = String.Format(oneEvent.startTime)
					txtArrivalTime.Text = String.Format(oneEvent.arrivalTime)
					txtMusic.Text = String.Format(oneEvent.music)
					txtContName.Text = String.Format(onecustomer.contName)
					txtCustomerID.Text = String.Format(onecustomer.customerID)
					txtPostcode.Text = String.Format(oneEvent.postcode)

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
			FileClose(1)
		Catch ex As Exception
			MessageBox.Show("Member details display failed")
		End Try
		groupInput.checkboxes()
	End Sub

	Private Sub cdrCalendar_MouseClick(sender As Object, e As MouseEventArgs) Handles cdrCalendar.MouseDown
		selectedDate = cdrCalendar.SelectionStart
		dtpDate.Value = selectedDate
		Dim oneEvent As calendarEvent
		Dim index As Integer
		dgvDay.Rows.Clear()
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		For index = 1 To totalRecords
			FileGet(1, oneEvent)

			If oneEvent.eventDate = selectedDate Then
				dgvDay.Rows.Add(oneEvent.eventID, oneEvent.address, oneEvent.eventDate, oneEvent.startTime,
								oneEvent.groups, oneEvent.music)
			End If
		Next
		FileClose(1)
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		'converting checkboxes to a string
		Dim groups As String = groupInput.groups(chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)
		Dim oneEvent As calendarEvent 'pointer to structure
		Dim oneCustomer As customer

		'storing inputs into structure
		oneEvent.eventID = txtID.Text
		oneEvent.address = txtAddress.Text
		oneEvent.eventDate = dtpDate.Text
		oneEvent.startTime = txtTime.Text
		oneEvent.arrivalTime = txtArrivalTime.Text
		oneEvent.postcode = txtPostcode.Text
		oneEvent.groups = groups
		oneEvent.music = txtMusic.Text
		oneCustomer.customerID = txtCustomerID.Text
		oneCustomer.contEmail = txtEmail.Text
		oneCustomer.contName = txtContName.Text
		oneCustomer.contPhone = txtContPhone.Text

		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		FilePut(1, oneEvent, currentRecord)
		FileClose(1)
		MsgBox("Event details updated")

		'display members in dataGridView
		Dim index As Integer
		dgvDay.Rows.Clear()
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		For index = 1 To totalRecords
			FileGet(1, oneEvent)
			dgvDay.Rows.Add(oneEvent.eventID, oneEvent.address, oneEvent.eventDate, oneEvent.startTime,
							oneEvent.groups, oneEvent.music)
		Next
		FileClose(1)
		groupInput.checkboxes()
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim groups As String = groupInput.groups(chkPSB.Checked, chkPYTB.Checked, chkPBB.Checked, chkStarters.Checked)

		Dim oneEvent As calendarEvent
		Dim oneCustomer As customer
		Dim postcodeFormat As String = "/[A-Z]{1,2}[0-9]{1,2}[A-Z]?\s?[0-9][A-Z]{2}/i"
		Dim postcodeMatch As Match = Regex.Match(txtPostcode.Text, postcodeFormat)
		Dim emailFormat As String = "^[A-Za-z0-9]+\@[A-Za-z0-9]+\.[A-Za-z0-9]+$"
		Dim emailMatch As Match = Regex.Match(txtEmail.Text, emailFormat)

		'validation
		If txtAddress.Text = "" Then
			MsgBox("Enter an address")

			If txtID.Text = "" Or txtCustomerID.Text = "" Then
				MsgBox("Enter a valid ID")

				If dtpDate.Text = "" Then
					MsgBox("Date is in incorrect format")

					If postcodeMatch.Success = False Then
						MsgBox("Invalid postcode")

						If txtTime.Text = "" Then
							MsgBox("Enter a start time")

							If txtArrivalTime.Text = "" Then
								MsgBox("Enter an arrival time")

								If txtMusic.Text = "" Then
									MsgBox("Enter the music")

									If txtContName.Text = "" Then
										MsgBox("Enter the customer's name")

										If txtContPhone.Text = "" Then
											MsgBox("Enter the customer's phone number")

											If emailMatch.Success = False Then
												MsgBox("Enter a valid email")

											Else
												FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
												Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
												Dim index As Integer
												totalRecords = LOF(1) / Len(oneEvent)
												Dim searchID As Integer = "00001"
												'if not records in the file, new id must be the first possible id
												If totalRecords = 0 Then
													txtID.Text = "00001"
												End If

		For index = 1 To totalRecords
			FileGet(1, oneEvent)

			'search for available id
			If searchID = oneEvent.eventID Then
				searchID += 1
			End If
		Next
		Dim idString As String = searchID.ToString()
		Dim idLen As Integer = Len(idString)
		Dim finalID As String = idString
		For i = 1 To 5 - idLen
			finalID = "0" & finalID
		Next
		txtID.Text = finalID

		oneEvent.eventID = txtID.Text
		oneEvent.address = txtAddress.Text
		oneEvent.eventDate = dtpDate.Text
		oneEvent.startTime = txtTime.Text
		oneEvent.arrivalTime = txtArrivalTime.Text
		oneEvent.postcode = txtPostcode.Text
		oneEvent.groups = groups
		oneEvent.music = txtMusic.Text
		oneCustomer.customerID = txtCustomerID.Text
		oneCustomer.contEmail = txtEmail.Text
		oneCustomer.contName = txtContName.Text
		oneCustomer.contPhone = txtContPhone.Text

		FilePut(1, oneEvent, totalRecords + 1)
		FileClose(1)
		MsgBox("Event added")

		'display members in dataGridView
		dgvDay.Rows.Clear()

												For index = 1 To totalRecords
													FileGet(1, oneEvent)
													dgvDay.Rows.Add(oneEvent.eventID, oneEvent.address, oneEvent.eventDate,
																	oneEvent.startTime, oneEvent.groups, oneEvent.music)
												Next
												FileClose(1)
												groupInput.checkboxes()
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If txtID.Text = "" Then
			MsgBox("Event cannot be deleted. No ID stored")
			Exit Sub
		End If
		Dim oneEvent As calendarEvent
		Dim recordNumber As Integer = txtID.Text

		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))
		FileOpen(2, "tempEvents.dat", OpenMode.Random,,, Len(oneEvent))

		Dim reader As String
		Do While Not EOF(1)
			reader = Loc(1) 'testing
			If Loc(1) <> recordNumber - 1 Then
				FileGet(1, oneEvent)
				FilePut(2, oneEvent)
			Else
				FileGet(1, oneEvent)
			End If
		Loop
		FileClose(1)
		FileClose(2)

		Kill("eventsCalendar.dat")
		Rename("tempEvents.dat", "eventsCalendar.dat")

		MsgBox("Record deleted")

		'display members in dataGridView
		Dim index As Integer
		dgvDay.Rows.Clear()
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		For index = 1 To totalRecords
			FileGet(1, oneEvent)
			dgvDay.Rows.Add(oneEvent.eventID, oneEvent.address, oneEvent.eventDate, oneEvent.startTime,
							oneEvent.groups, oneEvent.music)
		Next
		FileClose(1)
		groupInput.checkboxes()
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtID.Clear()
		txtAddress.Clear()
		dtpDate.ResetText()
		txtEmail.Clear()
		txtTime.Clear()
		txtMusic.ResetText()
		txtContName.Clear()
		txtContPhone.Clear()
		chkPSB.Checked = False
		chkPYTB.Checked = False
		chkPBB.Checked = False
		chkStarters.Checked = False
		txtCustomerID.Clear()
		txtPostcode.Clear()
		txtArrivalTime.Clear()
	End Sub
	Private Sub btnSaveResponse_Click(sender As Object, e As EventArgs) Handles btnSaveResponse.Click
		Dim index As Integer
		Dim oneEvent As calendarEvent 'pointer to structure
		Dim oneCustomer As customer
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim responses As String
		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		Dim checked As Boolean


		For index = 0 To dgvDay.Rows.Count - 1
			For j = 0 To totalRecords
				FileGet(1, oneEvent, index)
				If oneEvent.eventID = dgvDay.Rows(index).Cells(0).Value Then
					responses = oneEvent.playing
					If TypeOf dgvDay.Rows(index).Cells(3) Is DataGridViewCheckBoxCell Then
						'store the mark
						checked = dgvDay.Rows(index).Cells(5).Value
						oneEvent.playing = oneEvent.playing & login.userID & ", "
					End If
					FilePut(1, oneEvent, totalRecords + 1)
				End If

			Next
		Next
		FileClose(1)
		MessageBox.Show("Changes saved")
	End Sub
	Private Sub viewEvents_load(sender As Object, e As EventArgs) Handles MyBase.Load
		If login.role = "player" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False

		ElseIf login.role = "librarian" Then
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False

		ElseIf login.role = "instruments" Then
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False
			MusicToolStripMenuItem.Enabled = False

		ElseIf login.role = "events" Or login.role = "admin" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False

			'conductor can see all so no menuItems are disabled
		End If
	End Sub
	Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click, MyBase.Load
		Dim oneEvent As calendarEvent
		Dim index As Integer
		dgvDay.Rows.Clear()
		FileOpen(1, "eventsCalendar.dat", OpenMode.Random,,, Len(oneEvent))

		Dim totalRecords As Integer = LOF(1) / Len(oneEvent)
		For index = 1 To totalRecords
			FileGet(1, oneEvent)
			dgvDay.Rows.Add(oneEvent.eventID, oneEvent.address, oneEvent.eventDate, oneEvent.startTime, oneEvent.groups,
							oneEvent.music)
		Next
		FileClose(1)
	End Sub
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		Form1.Show()
		Me.Hide()
	End Sub

	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click
		players.Show()
		Me.Hide()
	End Sub

	Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click
		group.Show()
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

	Private Sub btnPlayers_Click(sender As Object, e As EventArgs) Handles btnPlayers.Click
		playerEventsResponse.Show()
		Me.Hide()
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
		PrintDocument1.DefaultPageSettings.Landscape = True
		PrintPreviewDialog1.ShowDialog()
	End Sub

	Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
		Dim bm As New Bitmap(700, dgvDay.Height)
		dgvDay.DrawToBitmap(bm, New Rectangle(30, 30, 700, dgvDay.Height))
		e.Graphics.DrawImage(bm, 0, 0)
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			End
		End If
	End Sub
	'Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click

	'End Sub
End Class