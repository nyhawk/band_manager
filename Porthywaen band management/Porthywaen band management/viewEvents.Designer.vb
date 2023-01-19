<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewEvents
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewEvents))
		Me.cdrCalendar = New System.Windows.Forms.MonthCalendar()
		Me.dgvDay = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colMusic = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPlaying = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.lblMusic = New System.Windows.Forms.Label()
		Me.txtMusic = New System.Windows.Forms.TextBox()
		Me.lblContPhone = New System.Windows.Forms.Label()
		Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
		Me.lblContName = New System.Windows.Forms.Label()
		Me.txtCustomerName = New System.Windows.Forms.TextBox()
		Me.chkStarters = New System.Windows.Forms.CheckBox()
		Me.chkPBB = New System.Windows.Forms.CheckBox()
		Me.chkPYTB = New System.Windows.Forms.CheckBox()
		Me.chkPSB = New System.Windows.Forms.CheckBox()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.lblTime = New System.Windows.Forms.Label()
		Me.txtStartTime = New System.Windows.Forms.TextBox()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.lblID = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnShowAll = New System.Windows.Forms.Button()
		Me.btnPlayers = New System.Windows.Forms.Button()
		Me.btnSaveResponse = New System.Windows.Forms.Button()
		Me.pdcPrint = New System.Drawing.Printing.PrintDocument()
		Me.ppdPrint = New System.Windows.Forms.PrintPreviewDialog()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.lblCustomerID = New System.Windows.Forms.Label()
		Me.txtCustomerID = New System.Windows.Forms.TextBox()
		Me.lblPostcode = New System.Windows.Forms.Label()
		Me.txtPostcode = New System.Windows.Forms.TextBox()
		Me.lblArrivalTime = New System.Windows.Forms.Label()
		Me.txtArrivalTime = New System.Windows.Forms.TextBox()
		Me.msMenuBar = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnUndo = New System.Windows.Forms.Button()
		CType(Me.dgvDay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.msMenuBar.SuspendLayout()
		Me.SuspendLayout()
		'
		'cdrCalendar
		'
		Me.cdrCalendar.Location = New System.Drawing.Point(18, 33)
		Me.cdrCalendar.Name = "cdrCalendar"
		Me.cdrCalendar.TabIndex = 0
		'
		'dgvDay
		'
		Me.dgvDay.AllowUserToAddRows = False
		Me.dgvDay.BackgroundColor = System.Drawing.Color.White
		Me.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colAddress, Me.colDate, Me.colTime, Me.colGroup, Me.colMusic, Me.colPlaying})
		Me.dgvDay.Location = New System.Drawing.Point(18, 207)
		Me.dgvDay.Name = "dgvDay"
		Me.dgvDay.ReadOnly = True
		Me.dgvDay.Size = New System.Drawing.Size(649, 248)
		Me.dgvDay.TabIndex = 1
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		Me.colID.Width = 50
		'
		'colAddress
		'
		Me.colAddress.HeaderText = "Address"
		Me.colAddress.Name = "colAddress"
		Me.colAddress.ReadOnly = True
		'
		'colDate
		'
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		Me.colDate.ReadOnly = True
		'
		'colTime
		'
		Me.colTime.HeaderText = "Time"
		Me.colTime.Name = "colTime"
		Me.colTime.ReadOnly = True
		Me.colTime.Width = 50
		'
		'colGroup
		'
		Me.colGroup.HeaderText = "Groups(s)"
		Me.colGroup.Name = "colGroup"
		Me.colGroup.ReadOnly = True
		'
		'colMusic
		'
		Me.colMusic.HeaderText = "Music"
		Me.colMusic.Name = "colMusic"
		Me.colMusic.ReadOnly = True
		Me.colMusic.Width = 150
		'
		'colPlaying
		'
		Me.colPlaying.HeaderText = "Playing?"
		Me.colPlaying.Name = "colPlaying"
		Me.colPlaying.ReadOnly = True
		Me.colPlaying.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colPlaying.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.colPlaying.Width = 55
		'
		'lblMusic
		'
		Me.lblMusic.AutoSize = True
		Me.lblMusic.Location = New System.Drawing.Point(709, 254)
		Me.lblMusic.Name = "lblMusic"
		Me.lblMusic.Size = New System.Drawing.Size(35, 13)
		Me.lblMusic.TabIndex = 95
		Me.lblMusic.Text = "Music"
		'
		'txtMusic
		'
		Me.txtMusic.Location = New System.Drawing.Point(789, 251)
		Me.txtMusic.Multiline = True
		Me.txtMusic.Name = "txtMusic"
		Me.txtMusic.Size = New System.Drawing.Size(164, 78)
		Me.txtMusic.TabIndex = 94
		'
		'lblContPhone
		'
		Me.lblContPhone.AutoSize = True
		Me.lblContPhone.Location = New System.Drawing.Point(709, 390)
		Me.lblContPhone.Name = "lblContPhone"
		Me.lblContPhone.Size = New System.Drawing.Size(38, 13)
		Me.lblContPhone.TabIndex = 93
		Me.lblContPhone.Text = "Phone"
		'
		'txtCustomerPhone
		'
		Me.txtCustomerPhone.Location = New System.Drawing.Point(789, 387)
		Me.txtCustomerPhone.Name = "txtCustomerPhone"
		Me.txtCustomerPhone.Size = New System.Drawing.Size(164, 20)
		Me.txtCustomerPhone.TabIndex = 92
		'
		'lblContName
		'
		Me.lblContName.AutoSize = True
		Me.lblContName.Location = New System.Drawing.Point(709, 364)
		Me.lblContName.Name = "lblContName"
		Me.lblContName.Size = New System.Drawing.Size(35, 13)
		Me.lblContName.TabIndex = 91
		Me.lblContName.Text = "Name"
		'
		'txtCustomerName
		'
		Me.txtCustomerName.Location = New System.Drawing.Point(789, 361)
		Me.txtCustomerName.Name = "txtCustomerName"
		Me.txtCustomerName.Size = New System.Drawing.Size(164, 20)
		Me.txtCustomerName.TabIndex = 90
		'
		'chkStarters
		'
		Me.chkStarters.AutoSize = True
		Me.chkStarters.Location = New System.Drawing.Point(955, 228)
		Me.chkStarters.Name = "chkStarters"
		Me.chkStarters.Size = New System.Drawing.Size(62, 17)
		Me.chkStarters.TabIndex = 89
		Me.chkStarters.Text = "Starters"
		Me.chkStarters.UseVisualStyleBackColor = True
		'
		'chkPBB
		'
		Me.chkPBB.AutoSize = True
		Me.chkPBB.Location = New System.Drawing.Point(902, 228)
		Me.chkPBB.Name = "chkPBB"
		Me.chkPBB.Size = New System.Drawing.Size(47, 17)
		Me.chkPBB.TabIndex = 88
		Me.chkPBB.Text = "PBB"
		Me.chkPBB.UseVisualStyleBackColor = True
		'
		'chkPYTB
		'
		Me.chkPYTB.AutoSize = True
		Me.chkPYTB.Location = New System.Drawing.Point(842, 228)
		Me.chkPYTB.Name = "chkPYTB"
		Me.chkPYTB.Size = New System.Drawing.Size(54, 17)
		Me.chkPYTB.TabIndex = 87
		Me.chkPYTB.Text = "PYTB"
		Me.chkPYTB.UseVisualStyleBackColor = True
		'
		'chkPSB
		'
		Me.chkPSB.AutoSize = True
		Me.chkPSB.Location = New System.Drawing.Point(789, 228)
		Me.chkPSB.Name = "chkPSB"
		Me.chkPSB.Size = New System.Drawing.Size(47, 17)
		Me.chkPSB.TabIndex = 86
		Me.chkPSB.Text = "PSB"
		Me.chkPSB.UseVisualStyleBackColor = True
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Location = New System.Drawing.Point(711, 141)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(30, 13)
		Me.lblDate.TabIndex = 82
		Me.lblDate.Text = "Date"
		'
		'lblTime
		'
		Me.lblTime.AutoSize = True
		Me.lblTime.Location = New System.Drawing.Point(708, 170)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(51, 13)
		Me.lblTime.TabIndex = 81
		Me.lblTime.Text = "Start time"
		'
		'txtStartTime
		'
		Me.txtStartTime.Location = New System.Drawing.Point(788, 167)
		Me.txtStartTime.Name = "txtStartTime"
		Me.txtStartTime.Size = New System.Drawing.Size(164, 20)
		Me.txtStartTime.TabIndex = 80
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(709, 416)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(32, 13)
		Me.lblEmail.TabIndex = 79
		Me.lblEmail.Text = "Email"
		'
		'txtCustomerEmail
		'
		Me.txtCustomerEmail.Location = New System.Drawing.Point(789, 413)
		Me.txtCustomerEmail.Name = "txtCustomerEmail"
		Me.txtCustomerEmail.Size = New System.Drawing.Size(164, 20)
		Me.txtCustomerEmail.TabIndex = 78
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(709, 63)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(45, 13)
		Me.lblName.TabIndex = 77
		Me.lblName.Text = "Address"
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(789, 60)
		Me.txtAddress.Multiline = True
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(164, 45)
		Me.txtAddress.TabIndex = 76
		'
		'dtpDate
		'
		Me.dtpDate.Location = New System.Drawing.Point(788, 141)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(164, 20)
		Me.dtpDate.TabIndex = 75
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(709, 37)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(49, 13)
		Me.lblID.TabIndex = 74
		Me.lblID.Text = "Event ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(789, 34)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(164, 20)
		Me.txtID.TabIndex = 73
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(539, 45)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 97
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
		Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdd.ForeColor = System.Drawing.Color.White
		Me.btnAdd.Location = New System.Drawing.Point(377, 45)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 96
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(458, 45)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 98
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(539, 74)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 99
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnShowAll
		'
		Me.btnShowAll.BackColor = System.Drawing.Color.Firebrick
		Me.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnShowAll.ForeColor = System.Drawing.Color.White
		Me.btnShowAll.Location = New System.Drawing.Point(257, 54)
		Me.btnShowAll.Name = "btnShowAll"
		Me.btnShowAll.Size = New System.Drawing.Size(75, 51)
		Me.btnShowAll.TabIndex = 100
		Me.btnShowAll.Text = "Show all events"
		Me.btnShowAll.UseVisualStyleBackColor = False
		'
		'btnPlayers
		'
		Me.btnPlayers.BackColor = System.Drawing.Color.Firebrick
		Me.btnPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPlayers.ForeColor = System.Drawing.Color.White
		Me.btnPlayers.Location = New System.Drawing.Point(257, 111)
		Me.btnPlayers.Name = "btnPlayers"
		Me.btnPlayers.Size = New System.Drawing.Size(75, 53)
		Me.btnPlayers.TabIndex = 102
		Me.btnPlayers.Text = "Manage players"
		Me.btnPlayers.UseVisualStyleBackColor = True
		'
		'btnSaveResponse
		'
		Me.btnSaveResponse.BackColor = System.Drawing.Color.Firebrick
		Me.btnSaveResponse.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSaveResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSaveResponse.ForeColor = System.Drawing.Color.White
		Me.btnSaveResponse.Location = New System.Drawing.Point(430, 103)
		Me.btnSaveResponse.Name = "btnSaveResponse"
		Me.btnSaveResponse.Size = New System.Drawing.Size(140, 28)
		Me.btnSaveResponse.TabIndex = 103
		Me.btnSaveResponse.Text = "Save event responses"
		Me.btnSaveResponse.UseVisualStyleBackColor = True
		'
		'pdcPrint
		'
		'
		'ppdPrint
		'
		Me.ppdPrint.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.ppdPrint.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.ppdPrint.ClientSize = New System.Drawing.Size(400, 300)
		Me.ppdPrint.Document = Me.pdcPrint
		Me.ppdPrint.Enabled = True
		Me.ppdPrint.Icon = CType(resources.GetObject("ppdPrint.Icon"), System.Drawing.Icon)
		Me.ppdPrint.Name = "PrintPreviewDialog1"
		Me.ppdPrint.Visible = False
		'
		'btnPrint
		'
		Me.btnPrint.BackColor = System.Drawing.Color.Firebrick
		Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.ForeColor = System.Drawing.Color.White
		Me.btnPrint.Location = New System.Drawing.Point(377, 74)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(75, 23)
		Me.btnPrint.TabIndex = 104
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'lblCustomerID
		'
		Me.lblCustomerID.AutoSize = True
		Me.lblCustomerID.Location = New System.Drawing.Point(709, 338)
		Me.lblCustomerID.Name = "lblCustomerID"
		Me.lblCustomerID.Size = New System.Drawing.Size(65, 13)
		Me.lblCustomerID.TabIndex = 106
		Me.lblCustomerID.Text = "Customer ID"
		'
		'txtCustomerID
		'
		Me.txtCustomerID.Location = New System.Drawing.Point(789, 335)
		Me.txtCustomerID.Name = "txtCustomerID"
		Me.txtCustomerID.ReadOnly = True
		Me.txtCustomerID.Size = New System.Drawing.Size(164, 20)
		Me.txtCustomerID.TabIndex = 105
		'
		'lblPostcode
		'
		Me.lblPostcode.AutoSize = True
		Me.lblPostcode.Location = New System.Drawing.Point(709, 114)
		Me.lblPostcode.Name = "lblPostcode"
		Me.lblPostcode.Size = New System.Drawing.Size(52, 13)
		Me.lblPostcode.TabIndex = 108
		Me.lblPostcode.Text = "Postcode"
		'
		'txtPostcode
		'
		Me.txtPostcode.Location = New System.Drawing.Point(789, 111)
		Me.txtPostcode.Name = "txtPostcode"
		Me.txtPostcode.Size = New System.Drawing.Size(164, 20)
		Me.txtPostcode.TabIndex = 107
		'
		'lblArrivalTime
		'
		Me.lblArrivalTime.AutoSize = True
		Me.lblArrivalTime.Location = New System.Drawing.Point(709, 196)
		Me.lblArrivalTime.Name = "lblArrivalTime"
		Me.lblArrivalTime.Size = New System.Drawing.Size(58, 13)
		Me.lblArrivalTime.TabIndex = 110
		Me.lblArrivalTime.Text = "Arrival time"
		'
		'txtArrivalTime
		'
		Me.txtArrivalTime.Location = New System.Drawing.Point(789, 193)
		Me.txtArrivalTime.Name = "txtArrivalTime"
		Me.txtArrivalTime.Size = New System.Drawing.Size(164, 20)
		Me.txtArrivalTime.TabIndex = 109
		'
		'msMenuBar
		'
		Me.msMenuBar.BackColor = System.Drawing.Color.Firebrick
		Me.msMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.msMenuBar.Location = New System.Drawing.Point(0, 0)
		Me.msMenuBar.Name = "msMenuBar"
		Me.msMenuBar.Size = New System.Drawing.Size(1023, 24)
		Me.msMenuBar.TabIndex = 111
		Me.msMenuBar.Text = "MenuStrip1"
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
		'btnUndo
		'
		Me.btnUndo.BackColor = System.Drawing.Color.Firebrick
		Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUndo.ForeColor = System.Drawing.Color.White
		Me.btnUndo.Location = New System.Drawing.Point(458, 74)
		Me.btnUndo.Name = "btnUndo"
		Me.btnUndo.Size = New System.Drawing.Size(75, 23)
		Me.btnUndo.TabIndex = 112
		Me.btnUndo.Text = "Undo"
		Me.btnUndo.UseVisualStyleBackColor = False
		'
		'viewEvents
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1023, 476)
		Me.Controls.Add(Me.btnUndo)
		Me.Controls.Add(Me.msMenuBar)
		Me.Controls.Add(Me.lblArrivalTime)
		Me.Controls.Add(Me.txtArrivalTime)
		Me.Controls.Add(Me.lblPostcode)
		Me.Controls.Add(Me.txtPostcode)
		Me.Controls.Add(Me.lblCustomerID)
		Me.Controls.Add(Me.txtCustomerID)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.btnSaveResponse)
		Me.Controls.Add(Me.btnPlayers)
		Me.Controls.Add(Me.btnShowAll)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.lblMusic)
		Me.Controls.Add(Me.txtMusic)
		Me.Controls.Add(Me.lblContPhone)
		Me.Controls.Add(Me.txtCustomerPhone)
		Me.Controls.Add(Me.lblContName)
		Me.Controls.Add(Me.txtCustomerName)
		Me.Controls.Add(Me.chkStarters)
		Me.Controls.Add(Me.chkPBB)
		Me.Controls.Add(Me.chkPYTB)
		Me.Controls.Add(Me.chkPSB)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.lblTime)
		Me.Controls.Add(Me.txtStartTime)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.txtCustomerEmail)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.dtpDate)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.dgvDay)
		Me.Controls.Add(Me.cdrCalendar)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "viewEvents"
		Me.Text = "events"
		CType(Me.dgvDay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.msMenuBar.ResumeLayout(False)
		Me.msMenuBar.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cdrCalendar As MonthCalendar
	Friend WithEvents dgvDay As DataGridView
	Friend WithEvents lblMusic As Label
	Friend WithEvents txtMusic As TextBox
	Friend WithEvents lblContPhone As Label
	Friend WithEvents txtCustomerPhone As TextBox
	Friend WithEvents lblContName As Label
	Friend WithEvents txtCustomerName As TextBox
	Friend WithEvents chkStarters As CheckBox
	Friend WithEvents chkPBB As CheckBox
	Friend WithEvents chkPYTB As CheckBox
	Friend WithEvents chkPSB As CheckBox
	Friend WithEvents lblDate As Label
	Friend WithEvents lblTime As Label
	Friend WithEvents txtStartTime As TextBox
	Friend WithEvents lblEmail As Label
	Friend WithEvents txtCustomerEmail As TextBox
	Friend WithEvents lblName As Label
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents lblID As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnShowAll As Button
	Friend WithEvents btnPlayers As Button
	Friend WithEvents btnSaveResponse As Button
	Friend WithEvents pdcPrint As Printing.PrintDocument
	Friend WithEvents ppdPrint As PrintPreviewDialog
	Friend WithEvents btnPrint As Button
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colAddress As DataGridViewTextBoxColumn
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colTime As DataGridViewTextBoxColumn
	Friend WithEvents colGroup As DataGridViewTextBoxColumn
	Friend WithEvents colMusic As DataGridViewTextBoxColumn
	Friend WithEvents colPlaying As DataGridViewCheckBoxColumn
	Friend WithEvents lblCustomerID As Label
	Friend WithEvents txtCustomerID As TextBox
	Friend WithEvents lblPostcode As Label
	Friend WithEvents txtPostcode As TextBox
	Public WithEvents lblArrivalTime As Label
	Friend WithEvents txtArrivalTime As TextBox
	Friend WithEvents msMenuBar As MenuStrip
	Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnUndo As Button
End Class
