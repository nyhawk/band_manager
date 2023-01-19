Structure music
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim title As String
	<VBFixedString(50)> Dim writer As String
End Structure
Public Class viewMusic
	Public Shared currentRecord As Integer = 0
	Public musicID As String

	Private Sub dgvPlayers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMusic.CellClick
		Dim row As DataGridViewRow = dgvMusic.CurrentRow
		Dim readID As String

		'stops memberDetails from being diplayed when column header clicked to sort dgv
		If e.RowIndex = -1 Then
			Return
		End If

		currentRecord = row.Index + 1

		Try
			musicID = row.Cells(0).Value.ToString()

			txtWriter.Clear()
			txtTitle.Clear()
			txtID.Clear()

			Dim onePiece As music 'pointer to structure
			Dim index As Integer
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			Dim totalRecords As Integer = LOF(1) / Len(onePiece)
			For index = 1 To totalRecords
				FileGet(1, onePiece)

				'if read id matches id selected in dgv display structure 
				readID = onePiece.id
				If readID.contains(musicID) Then
					txtID.Text = String.Format(onePiece.id)
					txtTitle.Text = String.Format(onePiece.title)
					txtWriter.Text = String.Format(onePiece.writer)
				End If
			Next
			FileClose(1)
		Catch ex As Exception
			MessageBox.Show("Display failed")
		End Try
	End Sub
	Private Sub players_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'disabling menu for different levels of access
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
	Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click, MyBase.Load
		Dim index As Integer
		Dim onePiece As music

		dgvMusic.Rows.Clear()

		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

		Dim totalRecords As Integer = LOF(1) / Len(onePiece)
		For index = 1 To totalRecords
			FileGet(1, onePiece)

			dgvMusic.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
		Next
		FileClose(1)
	End Sub
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim onePiece As music
		'validation

		'populate structure
		onePiece.id = txtID.Text
		onePiece.title = txtTitle.Text
		onePiece.writer = txtWriter.Text

		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
		Dim totalRecords As Integer = LOF(1) / Len(onePiece)
		FilePut(1, onePiece, totalRecords + 1) 'append to file

		FileClose(1)
		MessageBox.Show("Music added sucessfully")

		'display data in dgv
		Dim index As Integer
		dgvMusic.Rows.Clear()
		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

		totalRecords = LOF(1) / Len(onePiece)
		Dim searchID As Integer = "00001"
		'if not records in the file, new id must be the first possible id
		If totalRecords = 0 Then
			txtID.Text = "00001"
		End If

		For index = 1 To totalRecords
			FileGet(1, onePiece)

			'search for available id
			If searchID = onePiece.id Then
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
		For index = 1 To totalRecords
			FileGet(1, onePiece)
			dgvMusic.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
		Next
		FileClose(1)
	End Sub
	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		Dim onePiece As music
		Dim found As Boolean
		Dim title As String
		dgvSearch.Rows.Clear()
		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

		While Not EOF(1)
			FileGet(1, onePiece)
			title = onePiece.title
			If title.Contains(txtSearch.Text) Then
				dgvSearch.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
				found = True
			End If
		End While
		FileClose(1)
		If found = False Then
			MsgBox("Music not found")
		End If
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim onePiece As music 'pointer to structure

		'storing inputs into structure
		onePiece.id = txtID.Text
		onePiece.title = txtTitle.Text
		onePiece.writer = txtWriter.Text

		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
		FilePut(1, onePiece)
		FileClose(1)
		MsgBox("Player details updated")

		'display members in dataGridView
		Dim index As Integer
		dgvMusic.Rows.Clear()
		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

		Dim totalRecords As Integer = LOF(1) / Len(onePiece)
		For index = 1 To totalRecords
			FileGet(1, onePiece)
			dgvMusic.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
		Next
		FileClose(1)
	End Sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim onePiece As music 'pointer to structure
		Dim recordNumber As Integer = txtID.Text

		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
		FileOpen(2, "tempMusic.dat", OpenMode.Random,,, Len(onePiece))

		Dim reader As String
		Do While Not EOF(1)
			reader = Loc(1) 'testing
			If Loc(1) <> recordNumber - 1 Then
				FileGet(1, onePiece)
				FilePut(2, onePiece)
			Else
				FileGet(1, onePiece)
			End If
		Loop
		FileClose(1)
		FileClose(2)

		Kill("music.dat")
		Rename("tempMusic.dat", "music.dat")

		MsgBox("Record deleted")

		'display members in dataGridView
		Dim index As Integer
		dgvMusic.Rows.Clear()
		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

		Dim totalRecords As Integer = LOF(1) / Len(onePiece)
		For index = 1 To totalRecords
			FileGet(1, onePiece)
			dgvMusic.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
		Next
		FileClose(1)
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtID.Clear()
		txtTitle.Clear()
		txtWriter.ResetText()
	End Sub
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		home.Show()
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

	Private Sub InstrumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentsToolStripMenuItem.Click
		viewInstrument.Show()
		Me.Hide()
	End Sub
	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			End
		End If
	End Sub
End Class