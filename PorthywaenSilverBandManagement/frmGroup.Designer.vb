<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroup
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroup))
		Me.dgvMembers = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrument = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPresent = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.dtpMarkDate = New System.Windows.Forms.DateTimePicker()
		Me.cmbGroup = New System.Windows.Forms.ComboBox()
		Me.chtAttendance = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.btnAttendance = New System.Windows.Forms.Button()
		Me.dgvTotal = New System.Windows.Forms.DataGridView()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.txtRehearsals = New System.Windows.Forms.TextBox()
		Me.lblDate = New System.Windows.Forms.Label()
		Me.lblGroup = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chtAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvMembers
		'
		Me.dgvMembers.AllowUserToAddRows = False
		Me.dgvMembers.AllowUserToDeleteRows = False
		Me.dgvMembers.BackgroundColor = System.Drawing.Color.White
		Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colInstrument, Me.colRole, Me.colPresent})
		Me.dgvMembers.Location = New System.Drawing.Point(12, 13)
		Me.dgvMembers.Name = "dgvMembers"
		Me.dgvMembers.Size = New System.Drawing.Size(445, 220)
		Me.dgvMembers.TabIndex = 0
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.Width = 50
		'
		'colName
		'
		Me.colName.HeaderText = "Name"
		Me.colName.Name = "colName"
		Me.colName.Width = 150
		'
		'colInstrument
		'
		Me.colInstrument.HeaderText = "Instrument"
		Me.colInstrument.Name = "colInstrument"
		'
		'colRole
		'
		Me.colRole.HeaderText = "Role"
		Me.colRole.Name = "colRole"
		Me.colRole.Visible = False
		'
		'colPresent
		'
		Me.colPresent.HeaderText = "Present"
		Me.colPresent.Name = "colPresent"
		Me.colPresent.Width = 75
		'
		'dtpMarkDate
		'
		Me.dtpMarkDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpMarkDate.Location = New System.Drawing.Point(619, 14)
		Me.dtpMarkDate.MinDate = New Date(1934, 1, 1, 0, 0, 0, 0)
		Me.dtpMarkDate.Name = "dtpMarkDate"
		Me.dtpMarkDate.Size = New System.Drawing.Size(140, 21)
		Me.dtpMarkDate.TabIndex = 6
		'
		'cmbGroup
		'
		Me.cmbGroup.FormattingEnabled = True
		Me.cmbGroup.Items.AddRange(New Object() {"PSB", "PYTB", "PBB", "Starters", "Dep", "Committee"})
		Me.cmbGroup.Location = New System.Drawing.Point(827, 14)
		Me.cmbGroup.Name = "cmbGroup"
		Me.cmbGroup.Size = New System.Drawing.Size(87, 23)
		Me.cmbGroup.TabIndex = 7
		'
		'chtAttendance
		'
		ChartArea1.Name = "ChartArea1"
		Me.chtAttendance.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.chtAttendance.Legends.Add(Legend1)
		Me.chtAttendance.Location = New System.Drawing.Point(227, 239)
		Me.chtAttendance.Name = "chtAttendance"
		Me.chtAttendance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Me.chtAttendance.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Firebrick}
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
		Me.chtAttendance.Series.Add(Series1)
		Me.chtAttendance.Size = New System.Drawing.Size(954, 299)
		Me.chtAttendance.TabIndex = 9
		'
		'btnAttendance
		'
		Me.btnAttendance.BackColor = System.Drawing.Color.Firebrick
		Me.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAttendance.ForeColor = System.Drawing.Color.White
		Me.btnAttendance.Location = New System.Drawing.Point(771, 98)
		Me.btnAttendance.Name = "btnAttendance"
		Me.btnAttendance.Size = New System.Drawing.Size(87, 52)
		Me.btnAttendance.TabIndex = 10
		Me.btnAttendance.Text = "Show attendance"
		Me.btnAttendance.UseVisualStyleBackColor = False
		'
		'dgvTotal
		'
		Me.dgvTotal.AllowUserToAddRows = False
		Me.dgvTotal.AllowUserToDeleteRows = False
		Me.dgvTotal.BackgroundColor = System.Drawing.Color.White
		Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colTotal, Me.colPercentage})
		Me.dgvTotal.Location = New System.Drawing.Point(12, 239)
		Me.dgvTotal.Name = "dgvTotal"
		Me.dgvTotal.ReadOnly = True
		Me.dgvTotal.Size = New System.Drawing.Size(209, 173)
		Me.dgvTotal.TabIndex = 11
		'
		'colDate
		'
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		Me.colDate.ReadOnly = True
		Me.colDate.Width = 50
		'
		'colTotal
		'
		Me.colTotal.HeaderText = "Total"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.ReadOnly = True
		Me.colTotal.Width = 40
		'
		'colPercentage
		'
		Me.colPercentage.HeaderText = "Percentage"
		Me.colPercentage.Name = "colPercentage"
		Me.colPercentage.ReadOnly = True
		Me.colPercentage.Width = 75
		'
		'btnSave
		'
		Me.btnSave.BackColor = System.Drawing.Color.Firebrick
		Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.ForeColor = System.Drawing.Color.White
		Me.btnSave.Location = New System.Drawing.Point(677, 98)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(87, 52)
		Me.btnSave.TabIndex = 12
		Me.btnSave.Text = "Save attendance"
		Me.btnSave.UseVisualStyleBackColor = False
		'
		'txtRehearsals
		'
		Me.txtRehearsals.Location = New System.Drawing.Point(741, 59)
		Me.txtRehearsals.Name = "txtRehearsals"
		Me.txtRehearsals.Size = New System.Drawing.Size(45, 21)
		Me.txtRehearsals.TabIndex = 14
		Me.txtRehearsals.Text = "4"
		Me.txtRehearsals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Location = New System.Drawing.Point(580, 17)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(33, 15)
		Me.lblDate.TabIndex = 15
		Me.lblDate.Text = "Date"
		'
		'lblGroup
		'
		Me.lblGroup.AutoSize = True
		Me.lblGroup.Location = New System.Drawing.Point(780, 19)
		Me.lblGroup.Name = "lblGroup"
		Me.lblGroup.Size = New System.Drawing.Size(41, 15)
		Me.lblGroup.TabIndex = 16
		Me.lblGroup.Text = "Group"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(620, 62)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(115, 15)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Rehearsals to show"
		'
		'frmGroup
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1193, 549)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblGroup)
		Me.Controls.Add(Me.lblDate)
		Me.Controls.Add(Me.txtRehearsals)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.dgvTotal)
		Me.Controls.Add(Me.btnAttendance)
		Me.Controls.Add(Me.chtAttendance)
		Me.Controls.Add(Me.cmbGroup)
		Me.Controls.Add(Me.dtpMarkDate)
		Me.Controls.Add(Me.dgvMembers)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmGroup"
		Me.Text = "Group"
		CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chtAttendance, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvMembers As DataGridView
	Friend WithEvents dtpMarkDate As DateTimePicker
	Friend WithEvents cmbGroup As ComboBox
	Friend WithEvents chtAttendance As DataVisualization.Charting.Chart
	Friend WithEvents btnAttendance As Button
	Friend WithEvents dgvTotal As DataGridView
	Friend WithEvents btnSave As Button
	Friend WithEvents txtRehearsals As TextBox
	Friend WithEvents lblDate As Label
	Friend WithEvents lblGroup As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colInstrument As DataGridViewTextBoxColumn
	Friend WithEvents colRole As DataGridViewTextBoxColumn
	Friend WithEvents colPresent As DataGridViewCheckBoxColumn
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colTotal As DataGridViewTextBoxColumn
	Friend WithEvents colPercentage As DataGridViewTextBoxColumn
End Class
