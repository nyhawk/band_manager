<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewMusic
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
		Me.btnShow = New System.Windows.Forms.Button()
		Me.dgvMusic = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colWriter = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.lblWriter = New System.Windows.Forms.Label()
		Me.txtWriter = New System.Windows.Forms.TextBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.txtTitle = New System.Windows.Forms.TextBox()
		Me.lblID = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.dgvSearch = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.dgvMusic, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnShow
		'
		Me.btnShow.Location = New System.Drawing.Point(443, 154)
		Me.btnShow.Name = "btnShow"
		Me.btnShow.Size = New System.Drawing.Size(75, 23)
		Me.btnShow.TabIndex = 7
		Me.btnShow.Text = "Show"
		Me.btnShow.UseVisualStyleBackColor = True
		'
		'dgvMusic
		'
		Me.dgvMusic.AllowUserToAddRows = False
		Me.dgvMusic.AllowUserToDeleteRows = False
		Me.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvMusic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colTitle, Me.colWriter})
		Me.dgvMusic.Location = New System.Drawing.Point(12, 27)
		Me.dgvMusic.Name = "dgvMusic"
		Me.dgvMusic.ReadOnly = True
		Me.dgvMusic.Size = New System.Drawing.Size(344, 196)
		Me.dgvMusic.TabIndex = 6
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		'
		'colTitle
		'
		Me.colTitle.HeaderText = "Title"
		Me.colTitle.Name = "colTitle"
		Me.colTitle.ReadOnly = True
		'
		'colWriter
		'
		Me.colWriter.HeaderText = "Writer"
		Me.colWriter.Name = "colWriter"
		Me.colWriter.ReadOnly = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(767, 154)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 49
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(524, 154)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 48
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'lblWriter
		'
		Me.lblWriter.AutoSize = True
		Me.lblWriter.Location = New System.Drawing.Point(475, 84)
		Me.lblWriter.Name = "lblWriter"
		Me.lblWriter.Size = New System.Drawing.Size(73, 26)
		Me.lblWriter.TabIndex = 47
		Me.lblWriter.Text = "Composer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(and arranger)"
		'
		'txtWriter
		'
		Me.txtWriter.Location = New System.Drawing.Point(558, 90)
		Me.txtWriter.Name = "txtWriter"
		Me.txtWriter.Size = New System.Drawing.Size(164, 20)
		Me.txtWriter.TabIndex = 46
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Location = New System.Drawing.Point(475, 64)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(35, 13)
		Me.lblTitle.TabIndex = 45
		Me.lblTitle.Text = "Name"
		'
		'txtTitle
		'
		Me.txtTitle.Location = New System.Drawing.Point(558, 64)
		Me.txtTitle.Name = "txtTitle"
		Me.txtTitle.Size = New System.Drawing.Size(164, 20)
		Me.txtTitle.TabIndex = 44
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(478, 41)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(18, 13)
		Me.lblID.TabIndex = 43
		Me.lblID.Text = "ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(558, 38)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(164, 20)
		Me.txtID.TabIndex = 42
		'
		'txtSearch
		'
		Me.txtSearch.Location = New System.Drawing.Point(515, 309)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(164, 20)
		Me.txtSearch.TabIndex = 50
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(457, 312)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(35, 13)
		Me.Label1.TabIndex = 51
		Me.Label1.Text = "Name"
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(698, 307)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 52
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(605, 154)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 53
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(686, 154)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 54
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'dgvSearch
		'
		Me.dgvSearch.AllowUserToAddRows = False
		Me.dgvSearch.AllowUserToDeleteRows = False
		Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
		Me.dgvSearch.Location = New System.Drawing.Point(12, 240)
		Me.dgvSearch.Name = "dgvSearch"
		Me.dgvSearch.ReadOnly = True
		Me.dgvSearch.Size = New System.Drawing.Size(344, 189)
		Me.dgvSearch.TabIndex = 55
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.HeaderText = "Writer"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(912, 24)
		Me.MenuStrip1.TabIndex = 56
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'HomeToolStripMenuItem
		'
		Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
		Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.HomeToolStripMenuItem.Text = "Home"
		'
		'PlayersToolStripMenuItem
		'
		Me.PlayersToolStripMenuItem.Name = "PlayersToolStripMenuItem"
		Me.PlayersToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
		Me.PlayersToolStripMenuItem.Text = "Players"
		'
		'GroupToolStripMenuItem
		'
		Me.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem"
		Me.GroupToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.GroupToolStripMenuItem.Text = "Group"
		'
		'EventsToolStripMenuItem
		'
		Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
		Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.EventsToolStripMenuItem.Text = "Events"
		'
		'MusicToolStripMenuItem
		'
		Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
		Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
		Me.MusicToolStripMenuItem.Text = "Music"
		'
		'InstrumentsToolStripMenuItem
		'
		Me.InstrumentsToolStripMenuItem.Name = "InstrumentsToolStripMenuItem"
		Me.InstrumentsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
		Me.InstrumentsToolStripMenuItem.Text = "Instruments"
		'
		'UserToolStripMenuItem
		'
		Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem, Me.LogoutToolStripMenuItem})
		Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
		Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
		Me.UserToolStripMenuItem.Text = "User"
		'
		'UserDetailsToolStripMenuItem
		'
		Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
		Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.UserDetailsToolStripMenuItem.Text = "User details"
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.LogoutToolStripMenuItem.Text = "Logout"
		'
		'viewMusic
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(912, 441)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.dgvSearch)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtSearch)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.lblWriter)
		Me.Controls.Add(Me.txtWriter)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.txtTitle)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.btnShow)
		Me.Controls.Add(Me.dgvMusic)
		Me.Name = "viewMusic"
		Me.Text = "viewMusic"
		CType(Me.dgvMusic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnShow As Button
	Friend WithEvents dgvMusic As DataGridView
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colTitle As DataGridViewTextBoxColumn
	Friend WithEvents colWriter As DataGridViewTextBoxColumn
	Friend WithEvents btnClear As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents lblWriter As Label
	Friend WithEvents txtWriter As TextBox
	Friend WithEvents lblTitle As Label
	Friend WithEvents txtTitle As TextBox
	Friend WithEvents lblID As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnSearch As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents dgvSearch As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserDetailsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
