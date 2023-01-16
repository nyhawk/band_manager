<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class players
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(players))
		Me.dgvPlayers = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrument = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
		Me.btnAdd = New System.Windows.Forms.Button()
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
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.lblContact = New System.Windows.Forms.Label()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnUndo = New System.Windows.Forms.Button()
		Me.lblRole = New System.Windows.Forms.Label()
		Me.cmbRole = New System.Windows.Forms.ComboBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvPlayers
		'
		Me.dgvPlayers.AllowUserToAddRows = False
		Me.dgvPlayers.AllowUserToDeleteRows = False
		Me.dgvPlayers.BackgroundColor = System.Drawing.Color.White
		Me.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvPlayers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colInstrument})
		Me.dgvPlayers.Location = New System.Drawing.Point(12, 37)
		Me.dgvPlayers.Name = "dgvPlayers"
		Me.dgvPlayers.ReadOnly = True
		Me.dgvPlayers.Size = New System.Drawing.Size(344, 291)
		Me.dgvPlayers.TabIndex = 4
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		'
		'colName
		'
		Me.colName.HeaderText = "Name"
		Me.colName.Name = "colName"
		Me.colName.ReadOnly = True
		'
		'colInstrument
		'
		Me.colInstrument.HeaderText = "Instrument"
		Me.colInstrument.Name = "colInstrument"
		Me.colInstrument.ReadOnly = True
		'
		'lblContPhone
		'
		Me.lblContPhone.AutoSize = True
		Me.lblContPhone.Location = New System.Drawing.Point(691, 97)
		Me.lblContPhone.Name = "lblContPhone"
		Me.lblContPhone.Size = New System.Drawing.Size(38, 13)
		Me.lblContPhone.TabIndex = 70
		Me.lblContPhone.Text = "Phone"
		'
		'txtContPhone
		'
		Me.txtContPhone.Location = New System.Drawing.Point(746, 90)
		Me.txtContPhone.Name = "txtContPhone"
		Me.txtContPhone.Size = New System.Drawing.Size(164, 20)
		Me.txtContPhone.TabIndex = 69
		'
		'lblContName
		'
		Me.lblContName.AutoSize = True
		Me.lblContName.Location = New System.Drawing.Point(691, 71)
		Me.lblContName.Name = "lblContName"
		Me.lblContName.Size = New System.Drawing.Size(35, 13)
		Me.lblContName.TabIndex = 68
		Me.lblContName.Text = "Name"
		'
		'txtContName
		'
		Me.txtContName.Location = New System.Drawing.Point(746, 64)
		Me.txtContName.Name = "txtContName"
		Me.txtContName.Size = New System.Drawing.Size(164, 20)
		Me.txtContName.TabIndex = 67
		'
		'chkStarters
		'
		Me.chkStarters.Location = New System.Drawing.Point(642, 284)
		Me.chkStarters.Name = "chkStarters"
		Me.chkStarters.Size = New System.Drawing.Size(62, 17)
		Me.chkStarters.TabIndex = 65
		Me.chkStarters.Text = "Starters"
		Me.chkStarters.UseVisualStyleBackColor = True
		'
		'chkPBB
		'
		Me.chkPBB.Location = New System.Drawing.Point(589, 284)
		Me.chkPBB.Name = "chkPBB"
		Me.chkPBB.Size = New System.Drawing.Size(47, 17)
		Me.chkPBB.TabIndex = 64
		Me.chkPBB.Text = "PBB"
		Me.chkPBB.UseVisualStyleBackColor = True
		'
		'chkPYTB
		'
		Me.chkPYTB.Location = New System.Drawing.Point(529, 284)
		Me.chkPYTB.Name = "chkPYTB"
		Me.chkPYTB.Size = New System.Drawing.Size(54, 17)
		Me.chkPYTB.TabIndex = 63
		Me.chkPYTB.Text = "PYTB"
		Me.chkPYTB.UseVisualStyleBackColor = True
		'
		'chkPSB
		'
		Me.chkPSB.Location = New System.Drawing.Point(476, 284)
		Me.chkPSB.Name = "chkPSB"
		Me.chkPSB.Size = New System.Drawing.Size(47, 17)
		Me.chkPSB.TabIndex = 62
		Me.chkPSB.Text = "PSB"
		Me.chkPSB.UseVisualStyleBackColor = True
		'
		'chkPhotoPerm
		'
		Me.chkPhotoPerm.Location = New System.Drawing.Point(476, 251)
		Me.chkPhotoPerm.Name = "chkPhotoPerm"
		Me.chkPhotoPerm.Size = New System.Drawing.Size(164, 17)
		Me.chkPhotoPerm.TabIndex = 61
		Me.chkPhotoPerm.Text = "Photograph permission"
		Me.chkPhotoPerm.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(396, 226)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(33, 13)
		Me.Label1.TabIndex = 60
		Me.Label1.Text = "Level"
		'
		'cmbLevel
		'
		Me.cmbLevel.FormattingEnabled = True
		Me.cmbLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "8+"})
		Me.cmbLevel.Location = New System.Drawing.Point(476, 223)
		Me.cmbLevel.Name = "cmbLevel"
		Me.cmbLevel.Size = New System.Drawing.Size(164, 21)
		Me.cmbLevel.TabIndex = 59
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(806, 173)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 57
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
		Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdd.ForeColor = System.Drawing.Color.White
		Me.btnAdd.Location = New System.Drawing.Point(694, 160)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 56
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = False
		'
		'lblDOB
		'
		Me.lblDOB.AutoSize = True
		Me.lblDOB.Location = New System.Drawing.Point(396, 118)
		Me.lblDOB.Name = "lblDOB"
		Me.lblDOB.Size = New System.Drawing.Size(30, 13)
		Me.lblDOB.TabIndex = 55
		Me.lblDOB.Text = "DOB"
		'
		'lblHoldername
		'
		Me.lblHoldername.AutoSize = True
		Me.lblHoldername.Location = New System.Drawing.Point(396, 173)
		Me.lblHoldername.Name = "lblHoldername"
		Me.lblHoldername.Size = New System.Drawing.Size(38, 13)
		Me.lblHoldername.TabIndex = 54
		Me.lblHoldername.Text = "Phone"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(476, 170)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(164, 20)
		Me.txtPhone.TabIndex = 53
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(396, 147)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(32, 13)
		Me.lblEmail.TabIndex = 52
		Me.lblEmail.Text = "Email"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(476, 144)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(164, 20)
		Me.txtEmail.TabIndex = 51
		'
		'lblInstrument
		'
		Me.lblInstrument.AutoSize = True
		Me.lblInstrument.Location = New System.Drawing.Point(396, 199)
		Me.lblInstrument.Name = "lblInstrument"
		Me.lblInstrument.Size = New System.Drawing.Size(56, 13)
		Me.lblInstrument.TabIndex = 50
		Me.lblInstrument.Text = "Instrument"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(396, 95)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 49
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(476, 92)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(164, 20)
		Me.txtName.TabIndex = 48
		'
		'dtpDOB
		'
		Me.dtpDOB.Location = New System.Drawing.Point(476, 118)
		Me.dtpDOB.MaxDate = New Date(2023, 1, 16, 0, 0, 0, 0)
		Me.dtpDOB.Name = "dtpDOB"
		Me.dtpDOB.Size = New System.Drawing.Size(164, 20)
		Me.dtpDOB.TabIndex = 47
		Me.dtpDOB.Value = New Date(2023, 1, 16, 0, 0, 0, 0)
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(396, 69)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(18, 13)
		Me.lblID.TabIndex = 46
		Me.lblID.Text = "ID"
		'
		'cmbInstrument
		'
		Me.cmbInstrument.FormattingEnabled = True
		Me.cmbInstrument.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrument.Location = New System.Drawing.Point(476, 196)
		Me.cmbInstrument.Name = "cmbInstrument"
		Me.cmbInstrument.Size = New System.Drawing.Size(164, 21)
		Me.cmbInstrument.TabIndex = 45
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(476, 68)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(164, 20)
		Me.txtID.TabIndex = 44
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(694, 189)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 71
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'lblContact
		'
		Me.lblContact.AutoSize = True
		Me.lblContact.Location = New System.Drawing.Point(691, 44)
		Me.lblContact.Name = "lblContact"
		Me.lblContact.Size = New System.Drawing.Size(99, 13)
		Me.lblContact.TabIndex = 72
		Me.lblContact.Text = "Emergency contact"
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(694, 218)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 73
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'btnUndo
		'
		Me.btnUndo.BackColor = System.Drawing.Color.Firebrick
		Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUndo.ForeColor = System.Drawing.Color.White
		Me.btnUndo.Location = New System.Drawing.Point(806, 202)
		Me.btnUndo.Name = "btnUndo"
		Me.btnUndo.Size = New System.Drawing.Size(75, 23)
		Me.btnUndo.TabIndex = 75
		Me.btnUndo.Text = "Undo"
		Me.btnUndo.UseVisualStyleBackColor = False
		'
		'lblRole
		'
		Me.lblRole.AutoSize = True
		Me.lblRole.Location = New System.Drawing.Point(396, 310)
		Me.lblRole.Name = "lblRole"
		Me.lblRole.Size = New System.Drawing.Size(29, 13)
		Me.lblRole.TabIndex = 78
		Me.lblRole.Text = "Role"
		'
		'cmbRole
		'
		Me.cmbRole.FormattingEnabled = True
		Me.cmbRole.Items.AddRange(New Object() {"Player", "Dep", "Committee member", "Librarian", "Instruments", "Events", "Treasurer", "Conductor"})
		Me.cmbRole.Location = New System.Drawing.Point(476, 307)
		Me.cmbRole.Name = "cmbRole"
		Me.cmbRole.Size = New System.Drawing.Size(164, 21)
		Me.cmbRole.TabIndex = 77
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.Firebrick
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(927, 24)
		Me.MenuStrip1.TabIndex = 79
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
		'players
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(927, 390)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.lblRole)
		Me.Controls.Add(Me.cmbRole)
		Me.Controls.Add(Me.btnUndo)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.lblContact)
		Me.Controls.Add(Me.btnDelete)
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
		Me.Controls.Add(Me.btnAdd)
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
		Me.Controls.Add(Me.dgvPlayers)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "players"
		Me.Text = "players"
		CType(Me.dgvPlayers, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvPlayers As DataGridView
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colInstrument As DataGridViewTextBoxColumn
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
	Friend WithEvents btnAdd As Button
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
	Friend WithEvents btnDelete As Button
	Friend WithEvents lblContact As Label
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnUndo As Button
	Friend WithEvents lblRole As Label
	Friend WithEvents cmbRole As ComboBox
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
