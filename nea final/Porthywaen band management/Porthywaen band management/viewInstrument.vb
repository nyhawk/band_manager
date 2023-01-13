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

	'declaring global variables to handle undo and redo
	Shared undo() As String
	Shared count As Integer = 0
	Shared pointer As Integer = 1
	Shared lengthCount As Integer = 0 'does not decrease so more elements are added to array if undo, input, undo occurs
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
			Dim serviceDate = oneInstrument.serviceDate.ToString("dd/MM/yyyy")

			If serviceDate.Contains(red) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White

			ElseIf serviceDate.Contains(yellow) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

			ElseIf serviceDate.Contains(orange) Then
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
			Dim serviceDate = oneInstrument.serviceDate.ToString("dd/MM/yyyy")

			If serviceDate.Contains(red) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White

			ElseIf serviceDate.Contains(yellow) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

			ElseIf serviceDate.Contains(orange) Then
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


	Private Sub ViewInstrument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim customCulture As Globalization.CultureInfo = New Globalization.CultureInfo("en-GB")
		customCulture.DateTimeFormat.Calendar = New Globalization.GregorianCalendar
		Threading.Thread.CurrentThread.CurrentCulture = customCulture

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

		'display members in dataGridView
		Dim index As Integer
		Dim oneInstrument As instruments

		Dim Red = Date.Now.AddMonths(-11).ToString("MM/yyyy")
		Dim Orange = Date.Now.AddMonths(-10).ToString("MM/yyyy")
		Dim Yellow = Date.Now.AddMonths(-9).ToString("MM/yyyy")

		dgvInstruments.Rows.Clear()
		FileOpen(1, "instruments.dat", OpenMode.Random,,, Len(oneInstrument))

		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		For index = 1 To totalRecords
			FileGet(1, oneInstrument)
			dgvInstruments.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
									oneInstrument.holderID, oneInstrument.holderName, oneInstrument.serviceDate)
			Dim serviceDate = oneInstrument.serviceDate.ToString("dd/MM/yyyy")

			If serviceDate.Contains(Red) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White

			ElseIf serviceDate.Contains(Yellow) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

			ElseIf serviceDate.Contains(Orange) Then
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
			Dim serviceDate = oneinstrument.serviceDate.ToString("dd/MM/yyyy")

			If serviceDate.Contains(red) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.DarkRed
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.White

			ElseIf serviceDate.Contains(yellow) Then
				dgvInstruments.Rows(index - 1).Cells(5).Style.BackColor = Color.Gold
				dgvInstruments.Rows(index - 1).Cells(5).Style.ForeColor = Color.Black

			ElseIf serviceDate.Contains(orange) Then
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

	Private Sub formChanged(sender As Object, e As EventArgs) Handles txtName.Leave, txtPhone.Leave,
	txtEmail.Leave, cmbInstrument.Leave, cmbLevel.Leave, cmbRole.Leave, chkPhotoPerm.Leave, chkPBB.Leave,
	chkPSB.Leave, chkPYTB.Leave, chkStarters.Leave, txtContName.Leave, txtContPhone.Leave, dtpDOB.Leave

		'if a button has been clicked execute code for the button
		If ActiveControl.Name = "btnUndo" Then
			undo_click(sender, e)
		ElseIf ActiveControl.Name = "btnAdd" Then
			btnAdd_Click(sender, e)
		ElseIf ActiveControl.Name = "btnClear" Then
			btnClear_Click(sender, e)
		ElseIf ActiveControl.Name = "btnDelete" Then
			BtnDelete_Click(sender, e)
		ElseIf ActiveControl.Name = "btnUpdate" Then
			btnUpdate_Click(sender, e)

		Else
			'saves the data in the form to a dynamic array so changes can be restored when btnUndo clicked
			Dim changeRecorded As Boolean = False

			For i = pointer To undo.Length
				If changeRecorded = False Then
					If undo.Length - 1 - (lengthCount * 13) < 14 Then 'if no empty space, add more elements to the array
						ReDim Preserve undo(UBound(undo) + 14)
					End If
					If undo(i) = Nothing And i > 0 Then 'search for empty place in array that is not the first
						Try
							undo(i) = txtName.Text
							undo(i + 1) = dtpDOB.Text
							undo(i + 2) = txtEmail.Text
							undo(i + 3) = txtPhone.Text
							undo(i + 4) = cmbInstrument.Text
							undo(i + 5) = cmbLevel.Text
							undo(i + 6) = chkPhotoPerm.Checked
							undo(i + 7) = chkPSB.Checked
							undo(i + 8) = chkPYTB.Checked
							undo(i + 9) = chkPBB.Checked
							undo(i + 10) = chkStarters.Checked
							undo(i + 11) = cmbRole.Text
							undo(i + 12) = txtContName.Text
							undo(i + 13) = txtContPhone.Text

							pointer += 14
							count += 1
							lengthCount += 1
							changeRecorded = True

						Catch ex As Exception
							If MsgBox("Undo management failed", MsgBoxStyle.OkOnly) = vbOK Then
								For j = 0 To undo.Length - 1
									undo(j) = Nothing
								Next
								count = 0
								lengthCount = 0
								pointer = 1
								formChanged(sender, e)
								MsgBox("Undo reset")
							End If
						End Try
					End If
				End If
			Next
		End If
	End Sub

	Private Sub undo_click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUndo.Click, btnUndo.DoubleClick
		Dim startLocation As Integer = pointer - 28
		If count = 1 Then 'if only one change has been saved, the form must have been blank previously
			txtName.Clear()
			dtpDOB.ResetText()
			txtPhone.Clear()
			cmbInstrument.ResetText()
			cmbLevel.ResetText()
			chkPhotoPerm.CheckState = CheckState.Unchecked
			chkPSB.CheckState = CheckState.Unchecked
			chkPYTB.CheckState = CheckState.Unchecked
			chkPBB.CheckState = CheckState.Unchecked
			chkStarters.CheckState = CheckState.Unchecked
			cmbRole.ResetText()
			txtContName.Clear()
			txtContPhone.Clear()

			count = 0
			pointer = 0
		ElseIf count = 0 Then
			MsgBox("No changes made to be undone")

		Else 'if more than 1 change
			txtName.Text = undo(startLocation)
			dtpDOB.Text = undo(startLocation + 1)
			txtEmail.Text = undo(startLocation + 2)
			txtPhone.Text = undo(startLocation + 3)
			cmbInstrument.Text = undo(startLocation + 4)
			cmbLevel.Text = undo(startLocation + 5)

			Try
				If undo(startLocation + 6) = True Then
					chkPhotoPerm.CheckState = CheckState.Checked
				Else
					chkPhotoPerm.CheckState = CheckState.Unchecked
				End If
				If undo(startLocation + 7) = True Then
					chkPSB.CheckState = CheckState.Checked
				Else
					chkPSB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 8) = True Then
					chkPYTB.CheckState = CheckState.Checked
				Else
					chkPYTB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 9) = True Then
					chkPBB.CheckState = CheckState.Checked
				Else
					chkPBB.CheckState = CheckState.Unchecked
				End If

				If undo(startLocation + 10) = True Then
					chkStarters.CheckState = CheckState.Checked
				Else
					chkStarters.CheckState = CheckState.Unchecked
				End If

				cmbRole.Text = undo(startLocation + 11)
				txtContName.Text = undo(startLocation + 12)
				txtContPhone.Text = undo(startLocation + 13)

				count = count - 1
				pointer = pointer - 14
			Catch ex As Exception
				MsgBox("Previous data cannot be displayed")
			End Try
		End If
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
	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			End
		End If
	End Sub
End Class