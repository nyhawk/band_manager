Structure instruments
	<VBFixedString(5)> Dim instrumentID As String
	<VBFixedString(10)> Dim serialNumber As String
	<VBFixedString(30)> Dim name As String
	<VBFixedString(14)> Dim instrument As String
	<VBFixedString(5)> Dim holderID As String
	<VBFixedString(22)> Dim serviceDate As Date
End Structure
Public Class frmInstrument
	Public currentRecord As Integer = 0
	Sub colours()    'formats and displays data in dgv
		'colour variables to format service date colours
		Dim red = Date.Today.AddMonths(-11)
		Dim yellow = Date.Today.AddMonths(-9)
		Dim orange = Date.Today.AddMonths(-10)
		Dim serviceDate As String
		Dim index As Integer
		Dim oneInstrument As instruments
		Dim oneMember As memberInfo     'called to get holderName from id
		Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar

		Try
			dgvInstruments.Rows.Clear()
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))


			Dim totalRecordsInstrument As Integer = LOF(1) / Len(oneInstrument)
			Dim totalRecordsMember As Integer

			If totalRecordsInstrument = 0 Then
				MsgBox("No instruments stored", vbInformation, "Instruments")
			End If

			'open file and display record in dgv
			For index = 1 To totalRecordsInstrument
				FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneMember))
				totalRecordsMember = LOF(2) / Len(oneMember)
				FileGet(1, oneInstrument)

				If oneInstrument.holderID = empty Then
					dgvInstruments.Rows.Add(oneInstrument.instrumentID, oneInstrument.serialNumber.Trim(), oneInstrument.name.Trim(), oneInstrument.instrument,
									oneInstrument.holderID.Trim(), "", oneInstrument.serviceDate)
				Else

					For i = 1 To totalRecordsMember 'find holderName
						FileGet(2, oneMember)
						If oneMember.id.Contains(oneInstrument.holderID.Trim()) Then
							dgvInstruments.Rows.Add(oneInstrument.instrumentID.Trim(), oneInstrument.serialNumber.Trim(), oneInstrument.name.Trim(), oneInstrument.instrument.Trim(),
										oneInstrument.holderID.Trim(), oneMember.name.Trim(), oneInstrument.serviceDate)
							Exit For
						End If
					Next
				End If
				FileClose(2)
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("File reading failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				colours()
			Else
				FileClose(1)
				FileClose(2)
				Exit Sub
			End If
		End Try
		Try
			For currentRow = 1 To dgvInstruments.RowCount
				'format service dates
				serviceDate = dgvInstruments.Rows(currentRow - 1).Cells(6).Value
				If serviceDate <= red Then  'if more than 11 months ago, cell is red
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkRed
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.White

				ElseIf serviceDate <= orange And serviceDate > red Then 'if 10 months ago, cell is orange
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkOrange
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

				ElseIf serviceDate <= yellow And serviceDate > orange Then  'if 9 months ago, cell is yellow
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.Gold
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

				ElseIf serviceDate > yellow Then    'if less than 9 months ago, cell is green
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.LightGreen
					dgvInstruments.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black
				End If
			Next
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				colours()
			Else
				FileClose(1)
				FileClose(2)
				Exit Sub
			End If
		End Try
	End Sub
	Function validation(serialNo, name, instrument, holderID, serviceDate)
		Dim failed As Boolean
		If serialNo.length < 1 Or name.length < 1 Or instrument.length < 1 Then
			MsgBox("Enter data in all applicable fields", vbExclamation, "Instrument validation error")
			failed = True

			If Len(holderID) > 0 Then
				If Len(holderID) <> 5 Then
					MsgBox("ID must be 5 characters long", vbExclamation, "Instrument validation error")
					failed = True
				End If
			End If
		End If

		If Year(serviceDate) < 1900 Or Year(serviceDate) > Year(Today) Then
			MsgBox("Date is outside an acceptable range", vbExclamation, "Instrument validation error")
			failed = True
		End If
		Return failed
	End Function
	Private Sub btnFindAvailable_Click(sender As Object, e As EventArgs) Handles btnFindAvailable.Click
		Dim oneInstrument As instruments    'pointer to structure
		Dim quantity As Integer = 0
		Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar

		'colour variables to format service date colours
		Dim red = Date.Today.AddMonths(-11)
		Dim yellow = Date.Today.AddMonths(-9)
		Dim orange = Date.Today.AddMonths(-10)
		Dim serviceDate As String
		Try
			dgvInstrumentSearch.Rows.Clear()
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)

			For index = 1 To totalRecords
				FileGet(1, oneInstrument)

				If oneInstrument.instrument.Contains(cmbInstrumentSearch.Text) Then   'search for the same instrument as selected
					If oneInstrument.holderID.Contains(empty) Then  'no id means the instrument is available
						quantity = quantity + 1
						dgvInstrumentSearch.Rows.Add(oneInstrument.instrumentID.Trim(), oneInstrument.serialNumber.Trim(), oneInstrument.name.Trim(), oneInstrument.instrument.Trim(),
													 oneInstrument.holderID.Trim(), "", oneInstrument.serviceDate)
					End If
				End If
			Next
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("File search failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				btnFindAvailable_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try

		Try
			For currentRow = 1 To dgvInstrumentSearch.RowCount
				'format service dates
				serviceDate = dgvInstruments.Rows(currentRow - 1).Cells(6).Value
				If dgvInstruments.RowCount > 0 Then
					If serviceDate <= red Then  'if more than 11 months ago, cell is red
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkRed
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.White

					ElseIf serviceDate <= orange And serviceDate > red Then 'if 10 months ago, cell is orange
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkOrange
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

					ElseIf serviceDate <= yellow And serviceDate > orange Then  'if 9 months ago, cell is yellow
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.Gold
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

					ElseIf serviceDate > yellow Then    'if less than 9 months ago, cell is green
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.LightGreen
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black
					End If
				End If
			Next
			txtQuantity.Text = quantity
			FileClose(1)
			If quantity = 0 Then
				MsgBox("No available instruments found")
			End If
		Catch ex As Exception  'if fails, give option to retry, else end sub
			MsgBox("Formatting failed", vbExclamation, "Error")

		End Try
	End Sub
	Private Sub btnFindAll_Click(sender As Object, e As EventArgs) Handles btnFindAll.Click
		Dim oneInstrument As instruments    'pointer to structure
		Dim oneMember As memberInfo
		Dim quantity As Integer = 0
		Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar

		'colour variables to format service date colours
		Dim red = Date.Today.AddMonths(-11)
		Dim yellow = Date.Today.AddMonths(-9)
		Dim orange = Date.Today.AddMonths(-10)
		Dim serviceDate As String

		If cmbInstrumentSearch.Text = "" Then
			MsgBox("Select an instrument to search", vbInformation, "Instruments")
		End If
		Try
			dgvInstrumentSearch.Rows.Clear()
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecordsInstrument As Integer = LOF(1) / Len(oneInstrument)
			Dim totalRecordsMember As Integer

			If totalRecordsInstrument = 0 Then
				MsgBox("No instruments stored", vbInformation, "Instruments")
			End If

			'open file and display record in dgv
			For index = 1 To totalRecordsInstrument
				FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneMember))
				totalRecordsMember = LOF(2) / Len(oneMember)
				FileGet(1, oneInstrument)

				If oneInstrument.instrument.Contains(cmbInstrumentSearch.Text) Then
					If oneInstrument.holderID = "" Or oneInstrument.holderID = empty Then
						dgvInstrumentSearch.Rows.Add(oneInstrument.instrumentID.Trim(), oneInstrument.serialNumber.Trim(), oneInstrument.name.Trim(), oneInstrument.instrument.Trim(),
										oneInstrument.holderID.Trim(), "", oneInstrument.serviceDate)
						quantity += 1
					Else

						For i = 1 To totalRecordsMember 'find holderName
							FileGet(2, oneMember)
							If oneMember.id.Contains(oneInstrument.holderID) Then
								dgvInstrumentSearch.Rows.Add(oneInstrument.instrumentID.Trim(), oneInstrument.serialNumber.Trim(), oneInstrument.name.Trim(), oneInstrument.instrument.Trim(),
											oneInstrument.holderID.Trim(), oneMember.name.Trim(), oneInstrument.serviceDate)
								quantity += 1
								Exit For
							End If
						Next
					End If
				End If
				FileClose(2)
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("File search failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				btnFindAll_Click(sender, e)
			Else
				FileClose(1)
				FileClose(2)
				Exit Sub
			End If
		End Try

		Try
			For currentRow = 1 To dgvInstrumentSearch.RowCount
				'format service dates
				serviceDate = dgvInstruments.Rows(currentRow - 1).Cells(6).Value
				If dgvInstruments.RowCount > 0 Then
					If serviceDate <= red Then  'if more than 11 months ago, cell is red
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkRed
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.White

					ElseIf serviceDate <= orange And serviceDate > red Then 'if 10 months ago, cell is orange
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.DarkOrange
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

					ElseIf serviceDate <= yellow And serviceDate > orange Then  'if 9 months ago, cell is yellow
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.Gold
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black

					ElseIf serviceDate > yellow Then    'if less than 9 months ago, cell is green
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.BackColor = Color.LightGreen
						dgvInstrumentSearch.Rows(currentRow - 1).Cells(6).Style.ForeColor = Color.Black
					End If
				End If
			Next
			txtQuantity.Text = quantity
			FileClose(1)
			If quantity = 0 Then
				MsgBox("No available instruments found", vbInformation, "Instruments")
			End If
		Catch ex As Exception  'if fails, give option to retry, else end sub
			MsgBox("Formatting failed", vbExclamation, "Error")
		End Try
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

		'set up pointer to record
		Dim oneInstrument As instruments
		Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar
		Dim validationFailed = validation(txtSerialNo.Text.Trim(), txtName.Text.Trim(), cmbInstrument.Text.Trim(), txtHolderID.Text.Trim(), dtpServiceDate.Text.Trim()) 'validation
		If validationFailed = True Then
			FileClose(1)
			Exit Sub
		End If


		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		Dim searchID As Integer = "00001"
		Try
			'automatic id creation by searching file for last id
			'if not records in the file, new id must be the first possible id
			If totalRecords = 0 Then
				txtInstrumentID.Text = "00001"
			End If
			'search for available id
			For index = 1 To totalRecords
				FileGet(1, oneInstrument)
				If searchID <= oneInstrument.instrumentID.TrimStart("0") Then
					searchID = oneInstrument.instrumentID.TrimStart("0") + 1
				End If

			Next

			Dim idString As String = searchID.ToString().PadLeft(5, "0")
			txtInstrumentID.Text = idString

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
			If txtHolderID.Text = "" Then   'ensure all empty holderIDs are the same format
				oneInstrument.holderID = empty
			Else
				oneInstrument.holderID = txtHolderID.Text
			End If
			oneInstrument.instrumentID = txtInstrumentID.Text
			oneInstrument.serialNumber = txtSerialNo.Text
			oneInstrument.name = txtName.Text
			oneInstrument.instrument = cmbInstrument.Text
			oneInstrument.serviceDate = dtpServiceDate.Text

			FilePut(1, oneInstrument, totalRecords + 1) '+1 append to file
			FileClose(1)

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Instrument failed to be added", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				btnAdd_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
		colours() 'display and format dgv
		MsgBox("Instrument added successfully", vbInformation, "Instruments")
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Try
			Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar
			'set up pointer to record
			Dim oneInstrument As instruments
			Dim validationFailed = validation(txtSerialNo.Text.Trim(), txtName.Text.Trim(), cmbInstrument.Text.Trim(), txtHolderID.Text.Trim(), dtpServiceDate.Text.Trim()) 'validation

			If validationFailed = True Then
				Exit Sub
			End If

			'populate structure
			If txtHolderID.Text = "" Then   'ensure al empty holderIDs are the same format
				oneInstrument.holderID = empty
			Else
				oneInstrument.holderID = txtHolderID.Text
			End If
			oneInstrument.instrumentID = txtInstrumentID.Text
			oneInstrument.serialNumber = txtSerialNo.Text
			oneInstrument.name = txtName.Text
			oneInstrument.instrument = cmbInstrument.Text
			oneInstrument.serviceDate = dtpServiceDate.Text

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
			FilePut(1, oneInstrument, currentRecord)
			FileClose(1)

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Update failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				btnUpdate_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
		colours() 'display and format dgv
		MsgBox("Instrument updated", vbInformation, "Instruments")
	End Sub
	Private Sub dgvInstruments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstruments.CellClick, dgvInstrumentSearch.CellClick
		Try
			Dim row As DataGridViewRow
			If sender.name = "dgvInstruments" Then
				row = dgvInstruments.CurrentRow
			ElseIf sender.name = "dgvInstrumentSearch" Then
				row = dgvInstrumentSearch.CurrentRow
			End If

			currentRecord = row.Index + 1

			'stops instruments from being diplayed when column header clicked to sort dgv
			If e.RowIndex = -1 Then
				Return
			End If

			Dim id As String = row.Cells(0).Value.ToString()

			'clear all inputs
			txtInstrumentID.Clear()
			txtSerialNo.Clear()
			txtHolderID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrument.ResetText()
			cmbHolder.ResetText()

			'display details
			Dim oneInstrument As instruments 'pointer to structure
			Dim oneMember As memberInfo
			Dim index As Integer
			Dim empty = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecordsInstrument As Integer = LOF(1) / Len(oneInstrument)
			Dim totalRecordsMember As Integer

			For index = 1 To totalRecordsInstrument
				FileGet(1, oneInstrument)
				FileOpen(2, "players.dat", OpenMode.Random,,, Len(oneMember))
				totalRecordsMember = LOF(2) / Len(oneMember)

				'if read id matches id selected in dgv display structure 
				If id = oneInstrument.instrumentID Then
					If oneInstrument.holderID = "" Or oneInstrument.holderID = empty Then 'if holderID stored, find holderName in players file
						txtInstrumentID.Text = String.Format(oneInstrument.instrumentID).Trim()
						txtHolderID.Text = ""
						txtName.Text = String.Format(oneInstrument.name).Trim()
						dtpServiceDate.Value = String.Format(oneInstrument.serviceDate).Trim()
						txtSerialNo.Text = String.Format(oneInstrument.serialNumber).Trim()
						txtHolderName.Text = ""
						cmbInstrument.Text = String.Format(oneInstrument.instrument).Trim()

					Else
						For memberCountID = 1 To totalRecordsMember 'find holderName

							FileGet(2, oneMember)
							If oneMember.id = oneInstrument.holderID Then
								txtInstrumentID.Text = String.Format(oneInstrument.instrumentID).Trim()
								txtHolderID.Text = String.Format(oneInstrument.holderID).Trim()
								txtName.Text = String.Format(oneInstrument.name).Trim()
								dtpServiceDate.Value = String.Format(oneInstrument.serviceDate).Trim()
								txtSerialNo.Text = String.Format(oneInstrument.serialNumber).Trim()
								txtHolderName.Text = String.Format(oneMember.name).Trim()
								cmbInstrument.Text = String.Format(oneInstrument.instrument).Trim()
								Exit For
							End If
						Next

					End If
				End If
				FileClose(2)
			Next
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Display failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
			FileClose(1)
			FileClose(2)
			dgvInstruments_CellClick(sender, e)
		Else
			FileClose(1)
			FileClose(2)
			Exit Sub
		End If
		End Try
	End Sub

	Private Sub ViewInstrument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None

		dtpServiceDate.MaxDate = Date.Today 'set max date as today so no need for range check on data

		'add data to cmbHolder
		Dim index As Integer
		Dim oneMember As memberInfo 'pointer to structure

		FileOpen(1, "players.dat", OpenMode.Random,,, Len(oneMember))       'open file

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)       'add all detalis in file to dataGridView
		For index = 1 To totalRecords
			FileGet(1, oneMember)
			cmbHolder.Items.Add(oneMember.id.Trim() & ", " & oneMember.name.Trim())
		Next
		FileClose(1)

		'display members in dataGridView
		colours() 'display and format dgv
	End Sub
	Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Try
			If txtInstrumentID.Text = "" Then
				MsgBox("Instrument cannot be deleted. No ID found")
				Exit Sub
			End If

			Dim oneinstrument As instruments

			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneinstrument))
			FileOpen(2, "tempInstruments.dat", OpenMode.Random,,, Len(oneinstrument))

			Do While Not EOF(1)
				If Loc(1) <> currentRecord - 1 Then  'if not the record to delete, add to temp file
					FileGet(1, oneinstrument)
					FilePut(2, oneinstrument)
				Else
					FileGet(1, oneinstrument)   'if the record to delet, skip
				End If
			Loop
			FileClose(1)
			FileClose(2)

		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Delete failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				FileClose(2)
				BtnDelete_Click(sender, e)
			Else
				FileClose(1)
				FileClose(2)
				Exit Sub
			End If
		End Try
		Kill("instruments.dat")
		Rename("tempInstruments.dat", "instruments.dat")

		MsgBox("Record deleted", vbInformation, "Instruments")

		colours() 'display and format dgv
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear all inputs
		txtHolderID.Clear()
		txtInstrumentID.Clear()
		txtName.Clear()
		dtpServiceDate.Text = Date.Today
		txtSerialNo.Clear()
		txtHolderName.Clear()
		cmbInstrument.ResetText()
		cmbHolder.ResetText()
	End Sub

	Private Sub cmbHolder_TextChanged(sender As Object, e As EventArgs) Handles cmbHolder.LostFocus
		'display the holderID and holderName selected in the combobox in the textboxes
		If cmbHolder.Text = "" Then
			txtHolderID.Clear()
			txtHolderName.Clear()
		Else
			Dim holderSelected = cmbHolder.Text.Split(",")
			txtHolderID.Text = holderSelected(0)
			txtHolderName.Text = holderSelected(1)
		End If
	End Sub
End Class