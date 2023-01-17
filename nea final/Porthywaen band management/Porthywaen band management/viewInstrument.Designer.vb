<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewInstrument
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewInstrument))
		Me.dgvInstruments = New System.Windows.Forms.DataGridView()
		Me.dgvInstrumentSearch = New System.Windows.Forms.DataGridView()
		Me.cmbInstrumentSearch = New System.Windows.Forms.ComboBox()
		Me.btnFind = New System.Windows.Forms.Button()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.lblServiceDate = New System.Windows.Forms.Label()
		Me.lblHolderID = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.lblInstrument = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
		Me.lblSerialNo = New System.Windows.Forms.Label()
		Me.cmbInstrument = New System.Windows.Forms.ComboBox()
		Me.txtSerialNo = New System.Windows.Forms.TextBox()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.menu = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnUndo = New System.Windows.Forms.Button()
		Me.lblHolderName = New System.Windows.Forms.Label()
		Me.txtHolderName = New System.Windows.Forms.TextBox()
		Me.colSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrument = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colHolderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colHolderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colServiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvInstruments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvInstrumentSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.menu.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvInstruments
		'
		Me.dgvInstruments.AllowUserToAddRows = False
		Me.dgvInstruments.AllowUserToDeleteRows = False
		Me.dgvInstruments.BackgroundColor = System.Drawing.Color.White
		Me.dgvInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInstruments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSerialNo, Me.colName, Me.colInstrument, Me.colHolderID, Me.colHolderName, Me.colServiceDate})
		Me.dgvInstruments.Location = New System.Drawing.Point(12, 23)
		Me.dgvInstruments.Name = "dgvInstruments"
		Me.dgvInstruments.ReadOnly = True
		Me.dgvInstruments.Size = New System.Drawing.Size(643, 201)
		Me.dgvInstruments.TabIndex = 0
		'
		'dgvInstrumentSearch
		'
		Me.dgvInstrumentSearch.AllowUserToAddRows = False
		Me.dgvInstrumentSearch.AllowUserToDeleteRows = False
		Me.dgvInstrumentSearch.BackgroundColor = System.Drawing.Color.White
		Me.dgvInstrumentSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInstrumentSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
		Me.dgvInstrumentSearch.Location = New System.Drawing.Point(12, 230)
		Me.dgvInstrumentSearch.Name = "dgvInstrumentSearch"
		Me.dgvInstrumentSearch.ReadOnly = True
		Me.dgvInstrumentSearch.Size = New System.Drawing.Size(643, 208)
		Me.dgvInstrumentSearch.TabIndex = 7
		'
		'cmbInstrumentSearch
		'
		Me.cmbInstrumentSearch.FormattingEnabled = True
		Me.cmbInstrumentSearch.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrumentSearch.Location = New System.Drawing.Point(741, 33)
		Me.cmbInstrumentSearch.Name = "cmbInstrumentSearch"
		Me.cmbInstrumentSearch.Size = New System.Drawing.Size(164, 21)
		Me.cmbInstrumentSearch.TabIndex = 47
		'
		'btnFind
		'
		Me.btnFind.BackColor = System.Drawing.Color.Firebrick
		Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFind.ForeColor = System.Drawing.Color.White
		Me.btnFind.Location = New System.Drawing.Point(925, 33)
		Me.btnFind.Name = "btnFind"
		Me.btnFind.Size = New System.Drawing.Size(75, 23)
		Me.btnFind.TabIndex = 48
		Me.btnFind.Text = "Find"
		Me.btnFind.UseVisualStyleBackColor = False
		'
		'txtQuantity
		'
		Me.txtQuantity.Location = New System.Drawing.Point(822, 58)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
		Me.txtQuantity.TabIndex = 49
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(742, 65)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(31, 13)
		Me.lblTotal.TabIndex = 50
		Me.lblTotal.Text = "Total"
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(802, 352)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 65
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(911, 340)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 64
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
		Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdd.ForeColor = System.Drawing.Color.White
		Me.btnAdd.Location = New System.Drawing.Point(802, 293)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 63
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = False
		'
		'lblServiceDate
		'
		Me.lblServiceDate.AutoSize = True
		Me.lblServiceDate.Location = New System.Drawing.Point(742, 208)
		Me.lblServiceDate.Name = "lblServiceDate"
		Me.lblServiceDate.Size = New System.Drawing.Size(67, 13)
		Me.lblServiceDate.TabIndex = 62
		Me.lblServiceDate.Text = "Service date"
		'
		'lblHolderID
		'
		Me.lblHolderID.AutoSize = True
		Me.lblHolderID.Location = New System.Drawing.Point(742, 231)
		Me.lblHolderID.Name = "lblHolderID"
		Me.lblHolderID.Size = New System.Drawing.Size(52, 13)
		Me.lblHolderID.TabIndex = 59
		Me.lblHolderID.Text = "Holder ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(822, 228)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(164, 20)
		Me.txtID.TabIndex = 58
		'
		'lblInstrument
		'
		Me.lblInstrument.AutoSize = True
		Me.lblInstrument.Location = New System.Drawing.Point(742, 178)
		Me.lblInstrument.Name = "lblInstrument"
		Me.lblInstrument.Size = New System.Drawing.Size(56, 13)
		Me.lblInstrument.TabIndex = 57
		Me.lblInstrument.Text = "Instrument"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(742, 152)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 56
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(822, 149)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(164, 20)
		Me.txtName.TabIndex = 55
		'
		'dtpServiceDate
		'
		Me.dtpServiceDate.Location = New System.Drawing.Point(822, 202)
		Me.dtpServiceDate.Name = "dtpServiceDate"
		Me.dtpServiceDate.Size = New System.Drawing.Size(164, 20)
		Me.dtpServiceDate.TabIndex = 54
		'
		'lblSerialNo
		'
		Me.lblSerialNo.AutoSize = True
		Me.lblSerialNo.Location = New System.Drawing.Point(742, 126)
		Me.lblSerialNo.Name = "lblSerialNo"
		Me.lblSerialNo.Size = New System.Drawing.Size(71, 13)
		Me.lblSerialNo.TabIndex = 53
		Me.lblSerialNo.Text = "Serial number"
		'
		'cmbInstrument
		'
		Me.cmbInstrument.FormattingEnabled = True
		Me.cmbInstrument.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrument.Location = New System.Drawing.Point(822, 175)
		Me.cmbInstrument.Name = "cmbInstrument"
		Me.cmbInstrument.Size = New System.Drawing.Size(164, 21)
		Me.cmbInstrument.TabIndex = 52
		'
		'txtSerialNo
		'
		Me.txtSerialNo.Location = New System.Drawing.Point(822, 123)
		Me.txtSerialNo.Name = "txtSerialNo"
		Me.txtSerialNo.Size = New System.Drawing.Size(164, 20)
		Me.txtSerialNo.TabIndex = 51
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(802, 322)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 66
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'menu
		'
		Me.menu.BackColor = System.Drawing.Color.Firebrick
		Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.menu.Location = New System.Drawing.Point(0, 0)
		Me.menu.Name = "menu"
		Me.menu.Size = New System.Drawing.Size(1010, 24)
		Me.menu.TabIndex = 67
		Me.menu.Text = "Menu"
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
		Me.btnUndo.Location = New System.Drawing.Point(911, 311)
		Me.btnUndo.Name = "btnUndo"
		Me.btnUndo.Size = New System.Drawing.Size(75, 23)
		Me.btnUndo.TabIndex = 76
		Me.btnUndo.Text = "Undo"
		Me.btnUndo.UseVisualStyleBackColor = False
		'
		'lblHolderName
		'
		Me.lblHolderName.AutoSize = True
		Me.lblHolderName.Location = New System.Drawing.Point(742, 257)
		Me.lblHolderName.Name = "lblHolderName"
		Me.lblHolderName.Size = New System.Drawing.Size(67, 13)
		Me.lblHolderName.TabIndex = 78
		Me.lblHolderName.Text = "Holder name"
		'
		'txtHolderName
		'
		Me.txtHolderName.BackColor = System.Drawing.SystemColors.Control
		Me.txtHolderName.Location = New System.Drawing.Point(822, 254)
		Me.txtHolderName.Name = "txtHolderName"
		Me.txtHolderName.ReadOnly = True
		Me.txtHolderName.Size = New System.Drawing.Size(164, 20)
		Me.txtHolderName.TabIndex = 77
		'
		'colSerialNo
		'
		Me.colSerialNo.HeaderText = "Serial number"
		Me.colSerialNo.Name = "colSerialNo"
		Me.colSerialNo.ReadOnly = True
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
		'colHolderID
		'
		Me.colHolderID.HeaderText = "Holder ID"
		Me.colHolderID.Name = "colHolderID"
		Me.colHolderID.ReadOnly = True
		'
		'colHolderName
		'
		Me.colHolderName.HeaderText = "Holder name"
		Me.colHolderName.Name = "colHolderName"
		Me.colHolderName.ReadOnly = True
		'
		'colServiceDate
		'
		Me.colServiceDate.HeaderText = "Service date"
		Me.colServiceDate.Name = "colServiceDate"
		Me.colServiceDate.ReadOnly = True
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.HeaderText = "Serial number"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.HeaderText = "Instrument"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.HeaderText = "Holder ID"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		Me.DataGridViewTextBoxColumn4.ReadOnly = True
		'
		'viewInstrument
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1010, 450)
		Me.Controls.Add(Me.lblHolderName)
		Me.Controls.Add(Me.txtHolderName)
		Me.Controls.Add(Me.btnUndo)
		Me.Controls.Add(Me.menu)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.lblServiceDate)
		Me.Controls.Add(Me.lblHolderID)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblInstrument)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.dtpServiceDate)
		Me.Controls.Add(Me.lblSerialNo)
		Me.Controls.Add(Me.cmbInstrument)
		Me.Controls.Add(Me.txtSerialNo)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.txtQuantity)
		Me.Controls.Add(Me.btnFind)
		Me.Controls.Add(Me.cmbInstrumentSearch)
		Me.Controls.Add(Me.dgvInstrumentSearch)
		Me.Controls.Add(Me.dgvInstruments)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "viewInstrument"
		Me.Text = "viewInstrument"
		CType(Me.dgvInstruments, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvInstrumentSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.menu.ResumeLayout(False)
		Me.menu.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvInstruments As DataGridView
	Friend WithEvents dgvInstrumentSearch As DataGridView
	Friend WithEvents cmbInstrumentSearch As ComboBox
	Friend WithEvents btnFind As Button
	Friend WithEvents txtQuantity As TextBox
	Friend WithEvents lblTotal As Label
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents lblServiceDate As Label
	Friend WithEvents lblHolderID As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents lblInstrument As Label
	Friend WithEvents lblName As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents dtpServiceDate As DateTimePicker
	Friend WithEvents lblSerialNo As Label
	Friend WithEvents cmbInstrument As ComboBox
	Friend WithEvents txtSerialNo As TextBox
	Friend WithEvents btnUpdate As Button
	Friend WithEvents menu As MenuStrip
	Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnUndo As Button
	Friend WithEvents lblHolderName As Label
	Friend WithEvents txtHolderName As TextBox
	Friend WithEvents colSerialNo As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colInstrument As DataGridViewTextBoxColumn
	Friend WithEvents colHolderID As DataGridViewTextBoxColumn
	Friend WithEvents colHolderName As DataGridViewTextBoxColumn
	Friend WithEvents colServiceDate As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
