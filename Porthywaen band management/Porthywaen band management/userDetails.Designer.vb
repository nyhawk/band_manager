<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDetails
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userDetails))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblRole = New System.Windows.Forms.Label()
		Me.cmbRole = New System.Windows.Forms.ComboBox()
		Me.btnUndo = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.lblContact = New System.Windows.Forms.Label()
		Me.lblContPhone = New System.Windows.Forms.Label()
		Me.txtContPhone = New System.Windows.Forms.TextBox()
		Me.lblContName = New System.Windows.Forms.Label()
		Me.txtContName = New System.Windows.Forms.TextBox()
		Me.chkStarters = New System.Windows.Forms.CheckBox()
		Me.chkPBB = New System.Windows.Forms.CheckBox()
		Me.chkPYTB = New System.Windows.Forms.CheckBox()
		Me.chkPSB = New System.Windows.Forms.CheckBox()
		Me.chkPhotoPerm = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmbLevel = New System.Windows.Forms.ComboBox()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.lblDOB = New System.Windows.Forms.Label()
		Me.lblHoldername = New System.Windows.Forms.Label()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.lblInstrument = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
		Me.lblID = New System.Windows.Forms.Label()
		Me.cmbInstrument = New System.Windows.Forms.ComboBox()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
		Me.MenuStrip1.TabIndex = 111
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'HomeToolStripMenuItem
		'
		Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
		Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.HomeToolStripMenuItem.Text = "Home"
		'
		'PlayersToolStripMenuItem
		'
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
		'lblRole
		'
		Me.lblRole.AutoSize = True
		Me.lblRole.Location = New System.Drawing.Point(26, 309)
		Me.lblRole.Name = "lblRole"
		Me.lblRole.Size = New System.Drawing.Size(29, 13)
		Me.lblRole.TabIndex = 110
		Me.lblRole.Text = "Role"
		'
		'cmbRole
		'
		Me.cmbRole.FormattingEnabled = True
		Me.cmbRole.Items.AddRange(New Object() {"Player", "Dep", "Committee member", "Librarian", "Instruments", "Events", "Treasurer", "Conductor"})
		Me.cmbRole.Location = New System.Drawing.Point(106, 306)
		Me.cmbRole.Name = "cmbRole"
		Me.cmbRole.Size = New System.Drawing.Size(164, 21)
		Me.cmbRole.TabIndex = 109
		'
		'btnUndo
		'
		Me.btnUndo.BackColor = System.Drawing.Color.Firebrick
		Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUndo.ForeColor = System.Drawing.Color.White
		Me.btnUndo.Location = New System.Drawing.Point(324, 201)
		Me.btnUndo.Name = "btnUndo"
		Me.btnUndo.Size = New System.Drawing.Size(75, 23)
		Me.btnUndo.TabIndex = 108
		Me.btnUndo.Text = "Undo"
		Me.btnUndo.UseVisualStyleBackColor = False
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(324, 146)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 107
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'lblContact
		'
		Me.lblContact.AutoSize = True
		Me.lblContact.Location = New System.Drawing.Point(321, 43)
		Me.lblContact.Name = "lblContact"
		Me.lblContact.Size = New System.Drawing.Size(99, 13)
		Me.lblContact.TabIndex = 106
		Me.lblContact.Text = "Emergency contact"
		'
		'lblContPhone
		'
		Me.lblContPhone.AutoSize = True
		Me.lblContPhone.Location = New System.Drawing.Point(321, 96)
		Me.lblContPhone.Name = "lblContPhone"
		Me.lblContPhone.Size = New System.Drawing.Size(38, 13)
		Me.lblContPhone.TabIndex = 104
		Me.lblContPhone.Text = "Phone"
		'
		'txtContPhone
		'
		Me.txtContPhone.Location = New System.Drawing.Point(376, 89)
		Me.txtContPhone.Name = "txtContPhone"
		Me.txtContPhone.Size = New System.Drawing.Size(164, 20)
		Me.txtContPhone.TabIndex = 103
		'
		'lblContName
		'
		Me.lblContName.AutoSize = True
		Me.lblContName.Location = New System.Drawing.Point(321, 70)
		Me.lblContName.Name = "lblContName"
		Me.lblContName.Size = New System.Drawing.Size(35, 13)
		Me.lblContName.TabIndex = 102
		Me.lblContName.Text = "Name"
		'
		'txtContName
		'
		Me.txtContName.Location = New System.Drawing.Point(376, 63)
		Me.txtContName.Name = "txtContName"
		Me.txtContName.Size = New System.Drawing.Size(164, 20)
		Me.txtContName.TabIndex = 101
		'
		'chkStarters
		'
		Me.chkStarters.Location = New System.Drawing.Point(272, 283)
		Me.chkStarters.Name = "chkStarters"
		Me.chkStarters.Size = New System.Drawing.Size(62, 17)
		Me.chkStarters.TabIndex = 100
		Me.chkStarters.Text = "Starters"
		Me.chkStarters.UseVisualStyleBackColor = True
		'
		'chkPBB
		'
		Me.chkPBB.Location = New System.Drawing.Point(219, 283)
		Me.chkPBB.Name = "chkPBB"
		Me.chkPBB.Size = New System.Drawing.Size(47, 17)
		Me.chkPBB.TabIndex = 99
		Me.chkPBB.Text = "PBB"
		Me.chkPBB.UseVisualStyleBackColor = True
		'
		'chkPYTB
		'
		Me.chkPYTB.Location = New System.Drawing.Point(159, 283)
		Me.chkPYTB.Name = "chkPYTB"
		Me.chkPYTB.Size = New System.Drawing.Size(54, 17)
		Me.chkPYTB.TabIndex = 98
		Me.chkPYTB.Text = "PYTB"
		Me.chkPYTB.UseVisualStyleBackColor = True
		'
		'chkPSB
		'
		Me.chkPSB.Location = New System.Drawing.Point(106, 283)
		Me.chkPSB.Name = "chkPSB"
		Me.chkPSB.Size = New System.Drawing.Size(47, 17)
		Me.chkPSB.TabIndex = 97
		Me.chkPSB.Text = "PSB"
		Me.chkPSB.UseVisualStyleBackColor = True
		'
		'chkPhotoPerm
		'
		Me.chkPhotoPerm.Location = New System.Drawing.Point(106, 250)
		Me.chkPhotoPerm.Name = "chkPhotoPerm"
		Me.chkPhotoPerm.Size = New System.Drawing.Size(164, 17)
		Me.chkPhotoPerm.TabIndex = 96
		Me.chkPhotoPerm.Text = "Photograph permission"
		Me.chkPhotoPerm.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(26, 225)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(33, 13)
		Me.Label1.TabIndex = 95
		Me.Label1.Text = "Level"
		'
		'cmbLevel
		'
		Me.cmbLevel.FormattingEnabled = True
		Me.cmbLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "8+"})
		Me.cmbLevel.Location = New System.Drawing.Point(106, 222)
		Me.cmbLevel.Name = "cmbLevel"
		Me.cmbLevel.Size = New System.Drawing.Size(164, 21)
		Me.cmbLevel.TabIndex = 94
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(324, 172)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 93
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'lblDOB
		'
		Me.lblDOB.AutoSize = True
		Me.lblDOB.Location = New System.Drawing.Point(26, 117)
		Me.lblDOB.Name = "lblDOB"
		Me.lblDOB.Size = New System.Drawing.Size(30, 13)
		Me.lblDOB.TabIndex = 91
		Me.lblDOB.Text = "DOB"
		'
		'lblHoldername
		'
		Me.lblHoldername.AutoSize = True
		Me.lblHoldername.Location = New System.Drawing.Point(26, 172)
		Me.lblHoldername.Name = "lblHoldername"
		Me.lblHoldername.Size = New System.Drawing.Size(38, 13)
		Me.lblHoldername.TabIndex = 90
		Me.lblHoldername.Text = "Phone"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(106, 169)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(164, 20)
		Me.txtPhone.TabIndex = 89
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(26, 146)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(32, 13)
		Me.lblEmail.TabIndex = 88
		Me.lblEmail.Text = "Email"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(106, 143)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(164, 20)
		Me.txtEmail.TabIndex = 87
		'
		'lblInstrument
		'
		Me.lblInstrument.AutoSize = True
		Me.lblInstrument.Location = New System.Drawing.Point(26, 198)
		Me.lblInstrument.Name = "lblInstrument"
		Me.lblInstrument.Size = New System.Drawing.Size(56, 13)
		Me.lblInstrument.TabIndex = 86
		Me.lblInstrument.Text = "Instrument"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(26, 94)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 85
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(106, 91)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(164, 20)
		Me.txtName.TabIndex = 84
		'
		'dtpDOB
		'
		Me.dtpDOB.Location = New System.Drawing.Point(106, 117)
		Me.dtpDOB.MaxDate = New Date(2023, 1, 16, 0, 0, 0, 0)
		Me.dtpDOB.Name = "dtpDOB"
		Me.dtpDOB.Size = New System.Drawing.Size(164, 20)
		Me.dtpDOB.TabIndex = 83
		Me.dtpDOB.Value = New Date(2023, 1, 16, 0, 0, 0, 0)
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(26, 68)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(18, 13)
		Me.lblID.TabIndex = 82
		Me.lblID.Text = "ID"
		'
		'cmbInstrument
		'
		Me.cmbInstrument.FormattingEnabled = True
		Me.cmbInstrument.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrument.Location = New System.Drawing.Point(106, 195)
		Me.cmbInstrument.Name = "cmbInstrument"
		Me.cmbInstrument.Size = New System.Drawing.Size(164, 21)
		Me.cmbInstrument.TabIndex = 81
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(106, 67)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(164, 20)
		Me.txtID.TabIndex = 80
		'
		'userDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(555, 373)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.lblRole)
		Me.Controls.Add(Me.cmbRole)
		Me.Controls.Add(Me.btnUndo)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.lblContact)
		Me.Controls.Add(Me.lblContPhone)
		Me.Controls.Add(Me.txtContPhone)
		Me.Controls.Add(Me.lblContName)
		Me.Controls.Add(Me.txtContName)
		Me.Controls.Add(Me.chkStarters)
		Me.Controls.Add(Me.chkPBB)
		Me.Controls.Add(Me.chkPYTB)
		Me.Controls.Add(Me.chkPSB)
		Me.Controls.Add(Me.chkPhotoPerm)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cmbLevel)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.lblDOB)
		Me.Controls.Add(Me.lblHoldername)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.lblInstrument)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.dtpDOB)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.cmbInstrument)
		Me.Controls.Add(Me.txtID)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "userDetails"
		Me.Text = "User details"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblRole As Label
	Friend WithEvents cmbRole As ComboBox
	Friend WithEvents btnUndo As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents lblContact As Label
	Friend WithEvents lblContPhone As Label
	Friend WithEvents txtContPhone As TextBox
	Friend WithEvents lblContName As Label
	Friend WithEvents txtContName As TextBox
	Friend WithEvents chkStarters As CheckBox
	Friend WithEvents chkPBB As CheckBox
	Friend WithEvents chkPYTB As CheckBox
	Friend WithEvents chkPSB As CheckBox
	Friend WithEvents chkPhotoPerm As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents cmbLevel As ComboBox
	Friend WithEvents btnClear As Button
	Friend WithEvents lblDOB As Label
	Friend WithEvents lblHoldername As Label
	Friend WithEvents txtPhone As TextBox
	Friend WithEvents lblEmail As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents lblInstrument As Label
	Friend WithEvents lblName As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents dtpDOB As DateTimePicker
	Friend WithEvents lblID As Label
	Friend WithEvents cmbInstrument As ComboBox
	Friend WithEvents txtID As TextBox
End Class
