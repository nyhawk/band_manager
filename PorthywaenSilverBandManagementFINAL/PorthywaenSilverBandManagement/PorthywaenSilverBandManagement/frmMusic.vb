Structure music
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim title As String
	<VBFixedString(50)> Dim writer As String
End Structure
Public Class frmMusic
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
					txtID.Text = String.Format(onePiece.id).Trim()
					txtTitle.Text = String.Format(onePiece.title).Trim()
					txtWriter.Text = String.Format(onePiece.writer).Trim()
				End If
			Next
			FileClose(1)
		Catch ex As Exception   'show message if error occurs
			FileClose(1)
			MsgBox("Display failed", vbExclamation, "Music")
			Exit Sub
		End Try
	End Sub
	Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.MdiParent = frmHome
		Me.Dock = DockStyle.Fill
		Me.FormBorderStyle = FormBorderStyle.None
		Dim index As Integer
		Dim onePiece As music

		Try
			dgvMusic.Rows.Clear()

			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			Dim totalRecords As Integer = LOF(1) / Len(onePiece)    'add each record to dgv
			For index = 1 To totalRecords
				FileGet(1, onePiece)    'add each record to dgv
				dgvMusic.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
			Next
			FileClose(1)
		Catch ex As Exception   'show message if error occurs
			MsgBox("Display failed", vbExclamation, "Music")
			FileClose(1)
			Exit Sub
		End Try
	End Sub
	Function validation(title, writer)
		Dim failed As Boolean = False
		If title.Length < 1 Then
			MsgBox("Enter the title", vbExclamation, "Music")
			failed = True
		ElseIf writer.Length < 1 Then
			MsgBox("Enter the composer and/or arranger", vbExclamation, "Music")
			failed = True
		End If
		Return failed
	End Function
	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim onePiece As music
		FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
		Dim totalRecords As Integer = LOF(1) / Len(onePiece)
		Dim index As Integer

		Try
			'automatic id creation by searching file for last id
			Dim searchID As Integer = "00001"
			'if not records in the file, new id must be the first possible id
			If totalRecords = 0 Then
				txtID.Text = "00001"
			End If
			'search for available id
			For index = 1 To totalRecords
				FileGet(1, onePiece)
				If searchID <= onePiece.id.TrimStart("0") Then
					searchID = onePiece.id.TrimStart("0") + 1
				End If

			Next

			Dim idString As String = searchID.ToString().PadLeft(5, "0")
			txtID.Text = idString
			FileClose(1)
		Catch ex As Exception  'if fails, give option to retry, else end sub
			If MsgBox("Automatic ID generation failed", vbRetryCancel + vbExclamation, "Error") = vbRetry Then
				FileClose(1)
				btnAdd_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try

		'validation
		Dim validationFailed = validation(txtTitle.Text.Trim(), txtWriter.Text.Trim())
		If validationFailed = True Then
			FileClose(1)
			Exit Sub
		End If

		Try
			'populate structure
			onePiece.id = txtID.Text
			onePiece.title = txtTitle.Text
			onePiece.writer = txtWriter.Text

			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
			totalRecords = LOF(1) / Len(onePiece)
			FilePut(1, onePiece, totalRecords + 1) 'append to file

		Catch ex As Exception  'if an error occurs, allow user to retry, else end sub
			If MsgBox("Music failed to be added", vbExclamation + vbRetryCancel, "Music") = vbRetry Then
				FileClose(1)
				btnAdd_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
		FileClose(1)
		MsgBox("Music added sucessfully", vbInformation, "Music")

		Try
			'display data in dgv
			dgvMusic.Rows.Clear()
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			totalRecords = LOF(1) / Len(onePiece)
			For index = 1 To totalRecords
				FileGet(1, onePiece)

				dgvMusic.Rows.Add(onePiece.id.Trim(), onePiece.title.Trim(), onePiece.writer.Trim())
			Next
		Catch ex As Exception   'show messange if error occurs
			MsgBox("Display failed", vbExclamation, "Music")
			FileClose(1)
			Exit Sub
		End Try
		FileClose(1)
	End Sub
	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		Dim onePiece As music
		Dim found As Boolean

		Try
			If txtSearch.Text = "" Then
				MsgBox("A title or keywords need to be entered in order to search", vbExclamation, "Music")
				Exit Sub
			End If

			dgvSearch.Rows.Clear()
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			While Not EOF(1)    'compare each item to piece searched
				FileGet(1, onePiece)
				If onePiece.title.ToLower.Contains(txtSearch.Text.ToLower) Then 'toLower used so search is not case sensitive
					dgvSearch.Rows.Add(onePiece.id, onePiece.title, onePiece.writer)
					found = True
				End If
			End While
			FileClose(1)
			If found = False Then
				MsgBox("Music not found", vbInformation, "Music")
			End If

		Catch ex As Exception    'if an error occurs, allow user to retry, else end sub
			If MsgBox("Search failed", vbExclamation + vbRetryCancel, "Music") = vbRetry Then
				FileClose(1)
				btnSearch_Click(sender, e)
			Else
				FileClose(1)
				Exit Sub
			End If
		End Try
	End Sub
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim onePiece As music 'pointer to structure

		'validation
		Dim validationFailed = validation(txtTitle.Text.Trim(), txtWriter.Text.Trim())
		If validationFailed = True Then
			Exit Sub
		End If

		Try
			'storing inputs into structure
			onePiece.id = txtID.Text
			onePiece.title = txtTitle.Text
			onePiece.writer = txtWriter.Text

			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
			FilePut(1, onePiece, currentRecord)
			FileClose(1)
			MsgBox("Music details updated", vbInformation, "Music")

		Catch ex As Exception    'if an error occurs, allow user to retry, else end sub
			If MsgBox("Update failed", vbExclamation + vbRetryCancel, "Music") = vbRetry Then
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
			dgvMusic.Rows.Clear()
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			Dim totalRecords As Integer = LOF(1) / Len(onePiece)
			For index = 1 To totalRecords
				FileGet(1, onePiece)
				dgvMusic.Rows.Add(onePiece.id.Trim(), onePiece.title.Trim(), onePiece.writer.Trim())
			Next
		Catch ex As Exception   'show messange if error occurs
			MsgBox("Display failed", vbExclamation, "Music")
			FileClose(1)
			Exit Sub
		End Try
		FileClose(1)
	End Sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		If txtID.Text = "" Then
			MsgBox("Music cannot be deleted. No ID found")
			Exit Sub
		End If

		Dim onePiece As music 'pointer to structure

		Try
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))
			FileOpen(2, "tempMusic.dat", OpenMode.Random,,, Len(onePiece))

			Do While Not EOF(1)
				If Loc(1) <> currentRecord - 1 Then  'compare each record to record to be deleted
					FileGet(1, onePiece)    'if not the record to be deleted, add to temp file
					FilePut(2, onePiece)
				Else
					FileGet(1, onePiece)    'if is the record, skip
				End If
			Loop
			FileClose(1)
			FileClose(2)

			Kill("music.dat")
			Rename("tempMusic.dat", "music.dat")

			MsgBox("Music deleted", vbInformation, "Music")

		Catch ex As Exception    'if an error occurs, allow user to retry, else end sub
			If MsgBox("Delete failed", vbExclamation + vbRetryCancel, "Music") = vbRetry Then
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
			dgvMusic.Rows.Clear()
			FileOpen(1, "music.dat", OpenMode.Random,,, Len(onePiece))

			Dim totalRecords As Integer = LOF(1) / Len(onePiece)
			For index = 1 To totalRecords
				FileGet(1, onePiece)
				dgvMusic.Rows.Add(onePiece.id.Trim(), onePiece.title.Trim(), onePiece.writer.Trim())
			Next
			FileClose(1)
		Catch ex As Exception   'show messange if error occurs
			MsgBox("Display failed", vbExclamation, "Music")
			FileClose(1)
			Exit Sub
		End Try
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'clear inputs
		txtID.Clear()
		txtTitle.Clear()
		txtWriter.ResetText()
	End Sub
End Class