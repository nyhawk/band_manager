Structure committee
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim name As String
	<VBFixedString(22)> Dim role As String
End Structure
Public Class home
	Public Shared isDep As Boolean = False

	Private Sub form_shown(sender As Object, e As EventArgs) Handles Me.Shown
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


	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click,
		btnPlayers.Click
		players.Show()
		Me.Hide()
	End Sub

	Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click, btnGroups.Click
		MsgBox("testing")
		group.Show()
		Me.Hide()
	End Sub

	Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click,
		btnEvents.Click
		viewEvents.Show()
		Me.Hide()
	End Sub

	Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click,
		btnMusic.Click
		viewMusic.Show()
		Me.Hide()
	End Sub

	Private Sub InstrumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentsToolStripMenuItem.Click,
		btnInstruments.Click

		viewInstrument.Show()
		Me.Hide()
	End Sub

	Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If MsgBox("Logout?", MsgBoxStyle.YesNo) = vbYes Then
			End
		End If
	End Sub

	Private Sub btnUserDetails_Click(sender As Object, e As EventArgs) Handles btnUserDetails.Click, UserToolStripMenuItem.Click
		userDetails.Show()
		Me.Hide()

	End Sub

	Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'disabling menu for different levels of access
		If login.role = "player" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnMusic.Hide()
			btnInstruments.Hide()
			btnPlayers.Hide()

		ElseIf login.role = "librarian" Then
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnInstruments.Hide()
			btnPlayers.Hide()

		ElseIf login.role = "instruments" Then
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False
			MusicToolStripMenuItem.Enabled = False
			btnPlayers.Hide()
			btnGroups.Hide()
			btnMusic.Hide()

		ElseIf login.role = "events" Or login.role = "admin" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnMusic.Hide()
			btnInstruments.Hide()
			btnPlayers.Hide()

			'conductor can see all so no menuItems are disabled
		End If
	End Sub
End Class