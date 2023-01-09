<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class group
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.dgvMembers = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrument = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPresent = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.dtpMarkDate = New System.Windows.Forms.DateTimePicker()
		Me.cmbGroup = New System.Windows.Forms.ComboBox()
		Me.btnShow = New System.Windows.Forms.Button()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.btnAttendance = New System.Windows.Forms.Button()
		Me.dgvTotal = New System.Windows.Forms.DataGridView()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.txtWeeks = New System.Windows.Forms.TextBox()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
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
		Me.CommitteeMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvMembers
		'
		Me.dgvMembers.AllowUserToAddRows = False
		Me.dgvMembers.AllowUserToDeleteRows = False
		Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colInstrument, Me.colPresent})
		Me.dgvMembers.Location = New System.Drawing.Point(25, 38)
		Me.dgvMembers.Name = "dgvMembers"
		Me.dgvMembers.Size = New System.Drawing.Size(438, 150)
		Me.dgvMembers.TabIndex = 0
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		'
		'colName
		'
		Me.colName.HeaderText = "Name"
		Me.colName.Name = "colName"
		'
		'colInstrument
		'
		Me.colInstrument.HeaderText = "Instrument"
		Me.colInstrument.Name = "colInstrument"
		'
		'colPresent
		'
		Me.colPresent.HeaderText = "Present"
		Me.colPresent.Name = "colPresent"
		'
		'dtpMarkDate
		'
		Me.dtpMarkDate.Location = New System.Drawing.Point(537, 38)
		Me.dtpMarkDate.Name = "dtpMarkDate"
		Me.dtpMarkDate.Size = New System.Drawing.Size(121, 20)
		Me.dtpMarkDate.TabIndex = 6
		'
		'cmbGroup
		'
		Me.cmbGroup.FormattingEnabled = True
		Me.cmbGroup.Items.AddRange(New Object() {"PSB", "PYTB", "PBB", "Starters", "Dep"})
		Me.cmbGroup.Location = New System.Drawing.Point(715, 38)
		Me.cmbGroup.Name = "cmbGroup"
		Me.cmbGroup.Size = New System.Drawing.Size(75, 21)
		Me.cmbGroup.TabIndex = 7
		'
		'btnShow
		'
		Me.btnShow.Location = New System.Drawing.Point(537, 116)
		Me.btnShow.Name = "btnShow"
		Me.btnShow.Size = New System.Drawing.Size(75, 45)
		Me.btnShow.TabIndex = 8
		Me.btnShow.Text = "Show group"
		Me.btnShow.UseVisualStyleBackColor = True
		'
		'Chart1
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(507, 181)
		Me.Chart1.Name = "Chart1"
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(300, 300)
		Me.Chart1.TabIndex = 9
		Me.Chart1.Text = "Chart1"
		'
		'btnAttendance
		'
		Me.btnAttendance.Location = New System.Drawing.Point(699, 116)
		Me.btnAttendance.Name = "btnAttendance"
		Me.btnAttendance.Size = New System.Drawing.Size(75, 45)
		Me.btnAttendance.TabIndex = 10
		Me.btnAttendance.Text = "Show attendance"
		Me.btnAttendance.UseVisualStyleBackColor = True
		'
		'dgvTotal
		'
		Me.dgvTotal.AllowUserToAddRows = False
		Me.dgvTotal.AllowUserToDeleteRows = False
		Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTotal, Me.colPercentage})
		Me.dgvTotal.Location = New System.Drawing.Point(25, 211)
		Me.dgvTotal.Name = "dgvTotal"
		Me.dgvTotal.ReadOnly = True
		Me.dgvTotal.Size = New System.Drawing.Size(343, 150)
		Me.dgvTotal.TabIndex = 11
		'
		'colDate
		'
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		Me.colDate.ReadOnly = True
		'
		'colTotal
		'
		Me.colTotal.HeaderText = "Total"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.ReadOnly = True
		'
		'colPercentage
		'
		Me.colPercentage.HeaderText = "Percentage"
		Me.colPercentage.Name = "colPercentage"
		Me.colPercentage.ReadOnly = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(618, 116)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 45)
		Me.btnSave.TabIndex = 12
		Me.btnSave.Text = "Save attendance"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'txtWeeks
		'
		Me.txtWeeks.Location = New System.Drawing.Point(641, 77)
		Me.txtWeeks.Name = "txtWeeks"
		Me.txtWeeks.Size = New System.Drawing.Size(39, 20)
		Me.txtWeeks.TabIndex = 14
		Me.txtWeeks.Text = "4"
		Me.txtWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Location = New System.Drawing.Point(486, 44)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(30, 13)
		Me.lblDate.TabIndex = 15
		Me.lblDate.Text = "Date"
		'
		'lblGroup
		'
		Me.lblGroup.AutoSize = True
		Me.lblGroup.Location = New System.Drawing.Point(673, 45)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(36, 13)
		Me.lblGroup.TabIndex = 16
		Me.lblGroup.Text = "Group"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(554, 80)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 13)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Weeks to show"
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.GroupToolStripMenuItem, Me.EventsToolStripMenuItem, Me.MusicToolStripMenuItem, Me.InstrumentsToolStripMenuItem, Me.UserToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
		Me.MenuStrip1.TabIndex = 18
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
		Me.GroupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommitteeMembersToolStripMenuItem})
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
		'CommitteeMembersToolStripMenuItem
		'
		Me.CommitteeMembersToolStripMenuItem.Name = "CommitteeMembersToolStripMenuItem"
		Me.CommitteeMembersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
		Me.CommitteeMembersToolStripMenuItem.Text = "Committee members"
		'
		'group
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 497)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblGroup)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.txtWeeks)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.dgvTotal)
		Me.Controls.Add(Me.btnAttendance)
		Me.Controls.Add(Me.Chart1)
		Me.Controls.Add(Me.btnShow)
		Me.Controls.Add(Me.cmbGroup)
		Me.Controls.Add(Me.dtpMarkDate)
		Me.Controls.Add(Me.dgvMembers)
		Me.Name = "group"
		Me.Text = "group"
		CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvMembers As DataGridView
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colInstrument As DataGridViewTextBoxColumn
	Friend WithEvents colPresent As DataGridViewCheckBoxColumn
	Friend WithEvents dtpMarkDate As DateTimePicker
	Friend WithEvents cmbGroup As ComboBox
	Friend WithEvents btnShow As Button
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents btnAttendance As Button
	Friend WithEvents dgvTotal As DataGridView
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colTotal As DataGridViewTextBoxColumn
	Friend WithEvents colPercentage As DataGridViewTextBoxColumn
	Friend WithEvents btnSave As Button
	Friend WithEvents txtWeeks As TextBox
	Friend WithEvents lblDate As Label
	Friend WithEvents lblGroup As Label
	Friend WithEvents Label1 As Label
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
	Friend WithEvents CommitteeMembersToolStripMenuItem As ToolStripMenuItem
End Class
