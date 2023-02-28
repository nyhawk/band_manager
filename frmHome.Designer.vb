<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
		Me.btnPlayers = New System.Windows.Forms.Button()
		Me.btnEvents = New System.Windows.Forms.Button()
		Me.btnMusic = New System.Windows.Forms.Button()
		Me.btnUserDetails = New System.Windows.Forms.Button()
		Me.btnInstruments = New System.Windows.Forms.Button()
		Me.btnGroups = New System.Windows.Forms.Button()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnPlayers
		'
		Me.btnPlayers.BackColor = System.Drawing.Color.Firebrick
		Me.btnPlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPlayers.ForeColor = System.Drawing.Color.White
		Me.btnPlayers.Image = CType(resources.GetObject("btnPlayers.Image"), System.Drawing.Image)
		Me.btnPlayers.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.btnPlayers.Location = New System.Drawing.Point(394, 209)
		Me.btnPlayers.Name = "btnPlayers"
		Me.btnPlayers.Size = New System.Drawing.Size(163, 114)
		Me.btnPlayers.TabIndex = 1
		Me.btnPlayers.Text = "Players"
		Me.btnPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnPlayers.UseVisualStyleBackColor = False
		'
		'btnEvents
		'
		Me.btnEvents.BackColor = System.Drawing.Color.Firebrick
		Me.btnEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEvents.ForeColor = System.Drawing.Color.White
		Me.btnEvents.Image = CType(resources.GetObject("btnEvents.Image"), System.Drawing.Image)
		Me.btnEvents.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.btnEvents.Location = New System.Drawing.Point(225, 89)
		Me.btnEvents.Name = "btnEvents"
		Me.btnEvents.Size = New System.Drawing.Size(163, 114)
		Me.btnEvents.TabIndex = 2
		Me.btnEvents.Text = "Events"
		Me.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnEvents.UseVisualStyleBackColor = False
		'
		'btnMusic
		'
		Me.btnMusic.BackColor = System.Drawing.Color.Firebrick
		Me.btnMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnMusic.ForeColor = System.Drawing.Color.White
		Me.btnMusic.Image = CType(resources.GetObject("btnMusic.Image"), System.Drawing.Image)
		Me.btnMusic.ImageAlign = System.Drawing.ContentAlignment.BottomRight
		Me.btnMusic.Location = New System.Drawing.Point(56, 209)
		Me.btnMusic.Name = "btnMusic"
		Me.btnMusic.Size = New System.Drawing.Size(163, 114)
		Me.btnMusic.TabIndex = 3
		Me.btnMusic.Text = "Music"
		Me.btnMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnMusic.UseVisualStyleBackColor = False
		'
		'btnUserDetails
		'
		Me.btnUserDetails.BackColor = System.Drawing.Color.Firebrick
		Me.btnUserDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUserDetails.ForeColor = System.Drawing.Color.White
		Me.btnUserDetails.Image = CType(resources.GetObject("btnUserDetails.Image"), System.Drawing.Image)
		Me.btnUserDetails.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.btnUserDetails.Location = New System.Drawing.Point(56, 89)
		Me.btnUserDetails.Name = "btnUserDetails"
		Me.btnUserDetails.Size = New System.Drawing.Size(163, 114)
		Me.btnUserDetails.TabIndex = 6
		Me.btnUserDetails.Text = "My details"
		Me.btnUserDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnUserDetails.UseVisualStyleBackColor = False
		'
		'btnInstruments
		'
		Me.btnInstruments.BackColor = System.Drawing.Color.Firebrick
		Me.btnInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInstruments.ForeColor = System.Drawing.Color.White
		Me.btnInstruments.Image = CType(resources.GetObject("btnInstruments.Image"), System.Drawing.Image)
		Me.btnInstruments.ImageAlign = System.Drawing.ContentAlignment.BottomRight
		Me.btnInstruments.Location = New System.Drawing.Point(225, 209)
		Me.btnInstruments.Name = "btnInstruments"
		Me.btnInstruments.Size = New System.Drawing.Size(163, 114)
		Me.btnInstruments.TabIndex = 7
		Me.btnInstruments.Text = "Instruments"
		Me.btnInstruments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnInstruments.UseVisualStyleBackColor = False
		'
		'btnGroups
		'
		Me.btnGroups.BackColor = System.Drawing.Color.Firebrick
		Me.btnGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGroups.ForeColor = System.Drawing.Color.White
		Me.btnGroups.Image = CType(resources.GetObject("btnGroups.Image"), System.Drawing.Image)
		Me.btnGroups.ImageAlign = System.Drawing.ContentAlignment.BottomRight
		Me.btnGroups.Location = New System.Drawing.Point(394, 89)
		Me.btnGroups.Name = "btnGroups"
		Me.btnGroups.Size = New System.Drawing.Size(163, 114)
		Me.btnGroups.TabIndex = 8
		Me.btnGroups.Text = "Groups"
		Me.btnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
		Me.btnGroups.UseVisualStyleBackColor = False
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(1206, 24)
		Me.MenuStrip1.TabIndex = 80
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'HomeToolStripMenuItem
		'
		Me.HomeToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
		Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
		Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.HomeToolStripMenuItem.Text = "Home"
		'
		'PlayersToolStripMenuItem
		'
		Me.PlayersToolStripMenuItem.AutoSize = False
		Me.PlayersToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.PlayersToolStripMenuItem.Name = "PlayersToolStripMenuItem"
		Me.PlayersToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
		Me.PlayersToolStripMenuItem.Text = "Players"
		'
		'GroupToolStripMenuItem
		'
		Me.GroupToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem"
		Me.GroupToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.GroupToolStripMenuItem.Text = "Group"
		'
		'EventsToolStripMenuItem
		'
		Me.EventsToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
		Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.EventsToolStripMenuItem.Text = "Events"
		'
		'MusicToolStripMenuItem
		'
		Me.MusicToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
		Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
		Me.MusicToolStripMenuItem.Text = "Music"
		'
		'InstrumentsToolStripMenuItem
		'
		Me.InstrumentsToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.InstrumentsToolStripMenuItem.Name = "InstrumentsToolStripMenuItem"
		Me.InstrumentsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
		Me.InstrumentsToolStripMenuItem.Text = "Instruments"
		'
		'UserToolStripMenuItem
		'
		Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
		Me.UserToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
		Me.UserToolStripMenuItem.Text = "User details"
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.LogoutToolStripMenuItem.Text = "Logout"
		'
		'frmHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1206, 590)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.btnGroups)
		Me.Controls.Add(Me.btnInstruments)
		Me.Controls.Add(Me.btnUserDetails)
		Me.Controls.Add(Me.btnMusic)
		Me.Controls.Add(Me.btnEvents)
		Me.Controls.Add(Me.btnPlayers)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.Name = "frmHome"
		Me.Text = "Porthywaen Silver Band Management"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnPlayers As Button
	Friend WithEvents btnEvents As Button
	Friend WithEvents btnMusic As Button
	Friend WithEvents btnUserDetails As Button
	Friend WithEvents btnInstruments As Button
	Friend WithEvents btnGroups As Button
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
