Structure instruments
	<VBFixedString(10)> Dim serialNumber As String
	<VBFixedString(30)> Dim name As String
	<VBFixedString(14)> Dim instrument As String
	<VBFixedString(5)> Dim holderID As String
	<VBFixedString(50)> Dim holderName As String
	<VBFixedString(22)> Dim serviceDate As Date
End Structure
Public Class viewInstrument
	Public currentRecord As Integer = 0
	Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
		Dim oneInstrument As instruments
		Dim quantity As Integer = 0
		Dim instrument As String
		Dim holder As String
		Dim empty As String = vbNullChar & vbNullChar & vbNullChar & vbNullChar & vbNullChar

		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

		While Not EOF(1)
			FileGet(1, oneInstrument)
			instrument = oneInstrument.instrument
			holder = oneInstrument.holderID
			If instrument.Contains(cmbInstrumentSearch.Text) Then
				If holder.Contains(empty) Then
					quantity = quantity + 1
					dgvInstrumentSearch.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
												 oneInstrument.holderID, oneInstrument.holderName)
				End If
			End If
		End While

		txtQuantity.Text = quantity
		FileClose(1)
		If quantity = 0 Then
			MsgBox("No available instruments found")
		End If
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		'set up pointer to record
		Dim oneInstrument As instruments
		'validation


		Dim serviceMonth = oneInstrument.serviceDate.ToString("MM")
		Dim red = Date.Today.ToString("MM") - 11
		Dim yellow = Date.Today.ToString("MM") - 9
		Dim orange = Date.Today.ToString("MM") - 10

		'populate structure
		oneInstrument.serialNumber = txtSerialNo.Text
		oneInstrument.name = txtName.Text
		oneInstrument.instrument = cmbInstrument.Text
		oneInstrument.holderID = txtID.Text
		oneInstrument.holderName = txtHolderName.Text
		oneInstrument.serviceDate = dtpServiceDate.Text


		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		FilePut(1, oneInstrument, totalRecords + 1) '+1 append to file
		FileClose(1)

		'display members in dataGridView
		Dim index As Integer
		dgvInstruments.Rows.Clear()
		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

		totalRecords = LOF(1) / Len(oneInstrument)
		For index = 1 To totalRecords
			FileGet(1, oneInstrument)
			dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
									oneInstrument.holderID, oneInstrument.holderName, oneInstrument.serviceDate)

			If serviceMonth = red Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White
			ElseIf serviceMonth = yellow Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			ElseIf serviceMonth = orange Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Orange
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			Else
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.LightGreen
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			End If
		Next
		FileClose(1)
		MsgBox("Instrument added successfully")
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		'set up pointer to record
		Dim oneInstrument As instruments
		'validation

		Dim serviceMonth = oneInstrument.serviceDate.ToString("MM")
		Dim red = Date.Today.ToString("MM") - 11
		Dim yellow = Date.Today.ToString("MM") - 9
		Dim orange = Date.Today.ToString("MM") - 10

		'populate structure
		oneInstrument.serialNumber = txtSerialNo.Text
		oneInstrument.name = txtName.Text
		oneInstrument.instrument = cmbInstrument.Text
		oneInstrument.holderID = txtID.Text
		oneInstrument.holderName = txtHolderName.Text
		oneInstrument.serviceDate = dtpServiceDate.Text

		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))
		FilePut(1, oneInstrument, currentRecord)
		FileClose(1)

		'display members in dataGridView
		Dim index As Integer

		dgvInstruments.Rows.Clear()
		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		For index = 1 To totalRecords
			FileGet(1, oneInstrument)
			dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
									oneInstrument.holderID, oneInstrument.holderName, oneInstrument.serviceDate)

			If serviceMonth = red Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White
			ElseIf serviceMonth = yellow Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			ElseIf serviceMonth = orange Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Orange
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			Else
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.LightGreen
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			End If
		Next
		FileClose(1)
		MsgBox("Instrument updated")
	End Sub
	Private Sub dgvInstruments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstruments.CellClick
		Dim readSerialNo As String
		Dim row As DataGridViewRow = dgvInstruments.CurrentRow
		currentRecord = row.Index + 1

		'stops memberDetails from being diplayed when column header clicked to sort dgv
		If e.RowIndex = -1 Then
			Return
		End If

		Try
			Dim serialNo = row.Cells(0).Value.ToString()

			'clear all inputs
			txtSerialNo.Clear()
			txtID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrument.ResetText()

			'display details
			Dim oneInstrument As instruments 'pointer to structure
			Dim index As Integer
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
			For index = 1 To totalRecords
				FileGet(1, oneInstrument)
				readSerialNo = oneInstrument.serialNumber

				'if read id matches id selected in dgv display structure 
				If readSerialNo.Contains(serialNo) Then
					txtID.Text = String.Format(oneInstrument.holderID)
					txtName.Text = String.Format(oneInstrument.name)
					dtpServiceDate.Value = String.Format(oneInstrument.serviceDate)
					txtSerialNo.Text = String.Format(oneInstrument.serialNumber)
					txtHolderName.Text = String.Format(oneInstrument.holderName)
					cmbInstrument.Text = String.Format(oneInstrument.instrument)

					If txtID.Text = "" Then
						MessageBox.Show("Display failed")
					End If
				End If
			Next
		Catch ex As Exception
			MessageBox.Show("Member details display failed")
		End Try
		FileClose(1)
	End Sub
	Private Sub dgvInstrumentSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstrumentSearch.CellClick
		Dim readSerialNo As String
		Dim row As DataGridViewRow = dgvInstrumentSearch.CurrentRow
		Dim currentRecord As Integer = row.Index + 1

		'stops memberDetails from being diplayed when column header clicked to sort dgv
		If e.RowIndex = -1 Then
			Return
		End If

		Try
			Dim serialNo = row.Cells(0).Value.ToString()

			'clear all inputs
			txtSerialNo.Clear()
			txtID.Clear()
			txtName.Clear()
			dtpServiceDate.ResetText()
			txtSerialNo.Clear()
			txtHolderName.Clear()
			cmbInstrumentSearch.ResetText()

			'display details
			Dim oneInstrument As instruments 'pointer to structure
			Dim index As Integer
			FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

			Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
			For index = 1 To totalRecords
				FileGet(1, oneInstrument)
				readSerialNo = oneInstrument.serialNumber

				'if read id matches id selected in dgv display structure 
				If readSerialNo.Contains(serialNo) Then
					txtID.Text = String.Format(oneInstrument.holderID)
					txtName.Text = String.Format(oneInstrument.name)
					dtpServiceDate.Text = String.Format(oneInstrument.serialNumber)
					txtSerialNo.Text = String.Format(oneInstrument.serialNumber)
					txtHolderName.Text = String.Format(oneInstrument.holderName)
					cmbInstrument.Text = String.Format(oneInstrument.instrument)

					If txtID.Text = "" Then
						MessageBox.Show("Display failed")
					End If
				End If
			Next
			FileClose(1)
		Catch ex As Exception
			MessageBox.Show("Member details display failed")
		End Try
	End Sub
	Private Sub ViewInstrument_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
		'display members in dataGridView
		Dim index As Integer
		Dim oneInstrument As instruments

		Dim red = Date.Today.ToString("MM") - 11
		Dim yellow = Date.Today.ToString("MM") - 9
		Dim orange = Date.Today.ToString("MM") - 10

		dgvInstruments.Rows.Clear()
		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		For index = 1 To totalRecords
			FileGet(1, oneInstrument)
			dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
									oneInstrument.holderID, oneInstrument.holderName, oneInstrument.serviceDate)
			Dim serviceMonth = oneInstrument.serviceDate.ToString("MM")
			If serviceMonth = red Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White
			ElseIf serviceMonth = yellow Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			ElseIf serviceMonth = orange Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Orange
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			Else
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.LightGreen
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			End If
		Next
		FileClose(1)
	End Sub
	Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim oneinstrument As instruments
		Dim recordNumber As Integer = txtID.Text

		Dim red = Date.Today.ToString("MM") - 11
		Dim yellow = Date.Today.ToString("MM") - 9
		Dim orange = Date.Today.ToString("MM") - 10

		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneinstrument))
		FileOpen(2, "tempInstruments.dat", OpenMode.Random,,, Len(oneinstrument))

		Dim reader As String
		Do While Not EOF(1)
			reader = Loc(1) 'testing
			If Loc(1) <> recordNumber - 1 Then
				FileGet(1, oneinstrument)
				FilePut(2, oneinstrument)
			Else
				FileGet(1, oneinstrument)
			End If
		Loop
		FileClose(1)
		FileClose(2)

		Kill("instruments.dat")
		Rename("tempInstruments.dat", "instruments.dat")

		MsgBox("Record deleted")

		'display members in dataGridView
		Dim index As Integer
		dgvInstruments.Rows.Clear()
		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneinstrument))

		Dim totalRecords As Integer = LOF(1) / Len(oneinstrument)
		For index = 1 To totalRecords
			FileGet(1, oneinstrument)
			dgvInstruments.Rows.Add(oneinstrument.serialNumber, oneinstrument.name, oneinstrument.instrument,
									oneinstrument.holderID, oneinstrument.holderName, oneinstrument.serviceDate)

			Dim serviceMonth = oneinstrument.serviceDate.ToString("MM")
			If serviceMonth = red Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White
			ElseIf serviceMonth = yellow Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			ElseIf serviceMonth = orange Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Orange
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			Else
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.LightGreen
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black
			End If
		Next
		FileClose(1)
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear all inputs
		txtID.Clear()
		txtName.Clear()
		dtpServiceDate.ResetText()
		txtSerialNo.Clear()
		txtHolderName.Clear()
		cmbInstrument.ResetText()
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

	Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
		viewEvents.Show()
		Me.Hide()
	End Sub

	Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click
		viewMusic.Show()
		Me.Hide()
	End Sub

	Private Sub viewInstrument_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
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
	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			End
		End If
	End Sub
End Class