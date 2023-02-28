Structure committee
	<VBFixedString(5)> Dim id As String
	<VBFixedString(50)> Dim name As String
	<VBFixedString(22)> Dim role As String
End Structure
Public Class frmHome
	Public Shared isDep As Boolean = False

	' setup the forms and menu items
	Sub SetupFormsAndMenuItems()
		frmPlayers.Close()
		frmEvents.Close()
		frmGroup.Close()
		frmInstrument.Close()
		frmMusic.Close()
		frmUserDetails.Close()

		btnPlayers.Hide()
		btnEvents.Hide()
		btnGroups.Hide()
		btnInstruments.Hide()
		btnMusic.Hide()
		btnUserDetails.Hide()

		HomeToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		PlayersToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		EventsToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		GroupToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		InstrumentsToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		MusicToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
		UserToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick


	End Sub

	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click

		SetupFormsAndMenuItems()
		HomeToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		' show the buttons on the home page
		btnEvents.Show()
		btnGroups.Show()
		btnInstruments.Show()
		btnMusic.Show()
		btnPlayers.Show()
		btnUserDetails.Show()
	End Sub


	Private Sub PlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem.Click,
		btnPlayers.Click


		SetupFormsAndMenuItems()
		PlayersToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		frmPlayers.Show()

	End Sub

	Private Sub GroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupToolStripMenuItem.Click, btnGroups.Click

		SetupFormsAndMenuItems()
		GroupToolStripMenuItem.BackColor = System.Drawing.Color.Maroon


		frmGroup.Show()

	End Sub

	Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click,
		btnEvents.Click

		SetupFormsAndMenuItems()
		EventsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		frmEvents.Show()

	End Sub

	Private Sub MusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicToolStripMenuItem.Click,
		btnMusic.Click

		SetupFormsAndMenuItems()
		MusicToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		frmMusic.Show()

	End Sub

	Private Sub InstrumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstrumentsToolStripMenuItem.Click,
		btnInstruments.Click

		SetupFormsAndMenuItems()
		InstrumentsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		frmInstrument.Show()

	End Sub


	Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
		SetupFormsAndMenuItems()
		UserToolStripMenuItem.BackColor = System.Drawing.Color.Maroon

		frmUserDetails.Show()

	End Sub

	Private Sub btnUserDetails_Click(sender As Object, e As EventArgs) Handles btnUserDetails.Click
		UserToolStripMenuItem_Click(sender, e)
	End Sub

	Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load, HomeToolStripMenuItem.Click
		For Each ctl As Control In Me.Controls  'set the backColor to be what is specified
			If TypeOf ctl Is MdiClient Then
				ctl.BackColor = Me.BackColor
			End If
		Next ctl

		'disabling menu for different levels of access
		If frmLogin.role = "player" Or frmLogin.role = "dep" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnMusic.Hide()
			btnInstruments.Hide()
			btnPlayers.Hide()

		ElseIf frmLogin.role = "librarian" Then
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnInstruments.Hide()
			btnPlayers.Hide()

		ElseIf frmLogin.role = "instruments" Then
			PlayersToolStripMenuItem.Enabled = False
			GroupToolStripMenuItem.Enabled = False
			MusicToolStripMenuItem.Enabled = False
			btnPlayers.Hide()
			btnGroups.Hide()
			btnMusic.Hide()

		ElseIf frmLogin.role = "events" Or frmLogin.role = "admin" Then
			MusicToolStripMenuItem.Enabled = False
			InstrumentsToolStripMenuItem.Enabled = False
			PlayersToolStripMenuItem.Enabled = False
			btnMusic.Hide()
			btnInstruments.Hide()
			btnPlayers.Hide()

			'conductor can see all so no menuItems are disabled
		End If
	End Sub

	Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
		If MsgBox("Logout?", vbYesNo + vbInformation) = vbYes Then
			Application.Exit()
		End If
	End Sub


End Class