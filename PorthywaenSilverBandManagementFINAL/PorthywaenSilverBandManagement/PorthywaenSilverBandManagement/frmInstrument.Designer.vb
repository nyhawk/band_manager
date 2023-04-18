<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstrument
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstrument))
		Me.dgvInstruments = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colSerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrument = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colHolderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colHolderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colServiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvInstrumentSearch = New System.Windows.Forms.DataGridView()
		Me.colInstrumentIDSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colSerialNoSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colNameSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colInstrumentSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colIdSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colHolderNameSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colServiceDateSearch = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cmbInstrumentSearch = New System.Windows.Forms.ComboBox()
		Me.btnFindAvailable = New System.Windows.Forms.Button()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.lblServiceDate = New System.Windows.Forms.Label()
		Me.lblHolderID = New System.Windows.Forms.Label()
		Me.txtHolderID = New System.Windows.Forms.TextBox()
		Me.lblInstrument = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
		Me.lblSerialNo = New System.Windows.Forms.Label()
		Me.cmbInstrument = New System.Windows.Forms.ComboBox()
		Me.txtSerialNo = New System.Windows.Forms.TextBox()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.lblHolderName = New System.Windows.Forms.Label()
		Me.txtHolderName = New System.Windows.Forms.TextBox()
		Me.lblInstrumentID = New System.Windows.Forms.Label()
		Me.txtInstrumentID = New System.Windows.Forms.TextBox()
		Me.btnFindAll = New System.Windows.Forms.Button()
		Me.cmbHolder = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.dgvInstruments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvInstrumentSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvInstruments
		'
		Me.dgvInstruments.AllowUserToAddRows = False
		Me.dgvInstruments.AllowUserToDeleteRows = False
		Me.dgvInstruments.BackgroundColor = System.Drawing.Color.White
		Me.dgvInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInstruments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colSerialNo, Me.colName, Me.colInstrument, Me.colHolderID, Me.colHolderName, Me.colServiceDate})
		Me.dgvInstruments.Location = New System.Drawing.Point(14, 27)
		Me.dgvInstruments.Name = "dgvInstruments"
		Me.dgvInstruments.ReadOnly = True
		Me.dgvInstruments.Size = New System.Drawing.Size(763, 232)
		Me.dgvInstruments.TabIndex = 0
		'
		'colID
		'
		Me.colID.HeaderText = "Instrument ID"
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		Me.colID.Width = 70
		'
		'colSerialNo
		'
		Me.colSerialNo.HeaderText = "Serial number"
		Me.colSerialNo.Name = "colSerialNo"
		Me.colSerialNo.ReadOnly = True
		Me.colSerialNo.Width = 70
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
		Me.colHolderID.Width = 70
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
		'dgvInstrumentSearch
		'
		Me.dgvInstrumentSearch.AllowUserToAddRows = False
		Me.dgvInstrumentSearch.AllowUserToDeleteRows = False
		Me.dgvInstrumentSearch.BackgroundColor = System.Drawing.Color.White
		Me.dgvInstrumentSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInstrumentSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInstrumentIDSearch, Me.colSerialNoSearch, Me.colNameSearch, Me.colInstrumentSearch, Me.colIdSearch, Me.colHolderNameSearch, Me.colServiceDateSearch})
		Me.dgvInstrumentSearch.Location = New System.Drawing.Point(14, 265)
		Me.dgvInstrumentSearch.Name = "dgvInstrumentSearch"
		Me.dgvInstrumentSearch.ReadOnly = True
		Me.dgvInstrumentSearch.Size = New System.Drawing.Size(763, 240)
		Me.dgvInstrumentSearch.TabIndex = 7
		'
		'colInstrumentIDSearch
		'
		Me.colInstrumentIDSearch.HeaderText = "Instrument ID"
		Me.colInstrumentIDSearch.Name = "colInstrumentIDSearch"
		Me.colInstrumentIDSearch.ReadOnly = True
		Me.colInstrumentIDSearch.Width = 70
		'
		'colSerialNoSearch
		'
		Me.colSerialNoSearch.HeaderText = "Serial number"
		Me.colSerialNoSearch.Name = "colSerialNoSearch"
		Me.colSerialNoSearch.ReadOnly = True
		Me.colSerialNoSearch.Width = 70
		'
		'colNameSearch
		'
		Me.colNameSearch.HeaderText = "Name"
		Me.colNameSearch.Name = "colNameSearch"
		Me.colNameSearch.ReadOnly = True
		'
		'colInstrumentSearch
		'
		Me.colInstrumentSearch.HeaderText = "Instrument"
		Me.colInstrumentSearch.Name = "colInstrumentSearch"
		Me.colInstrumentSearch.ReadOnly = True
		'
		'colIdSearch
		'
		Me.colIdSearch.HeaderText = "Holder ID"
		Me.colIdSearch.Name = "colIdSearch"
		Me.colIdSearch.ReadOnly = True
		Me.colIdSearch.Width = 70
		'
		'colHolderNameSearch
		'
		Me.colHolderNameSearch.HeaderText = "Holder name"
		Me.colHolderNameSearch.Name = "colHolderNameSearch"
		Me.colHolderNameSearch.ReadOnly = True
		'
		'colServiceDateSearch
		'
		Me.colServiceDateSearch.HeaderText = "Service date"
		Me.colServiceDateSearch.Name = "colServiceDateSearch"
		Me.colServiceDateSearch.ReadOnly = True
		'
		'cmbInstrumentSearch
		'
		Me.cmbInstrumentSearch.FormattingEnabled = True
		Me.cmbInstrumentSearch.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrumentSearch.Location = New System.Drawing.Point(813, 48)
		Me.cmbInstrumentSearch.Name = "cmbInstrumentSearch"
		Me.cmbInstrumentSearch.Size = New System.Drawing.Size(138, 23)
		Me.cmbInstrumentSearch.TabIndex = 47
		'
		'btnFindAvailable
		'
		Me.btnFindAvailable.BackColor = System.Drawing.Color.Firebrick
		Me.btnFindAvailable.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnFindAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFindAvailable.ForeColor = System.Drawing.Color.White
		Me.btnFindAvailable.Location = New System.Drawing.Point(959, 48)
		Me.btnFindAvailable.Name = "btnFindAvailable"
		Me.btnFindAvailable.Size = New System.Drawing.Size(96, 52)
		Me.btnFindAvailable.TabIndex = 48
		Me.btnFindAvailable.Text = "Find available instruments"
		Me.btnFindAvailable.UseVisualStyleBackColor = False
		'
		'txtQuantity
		'
		Me.txtQuantity.Location = New System.Drawing.Point(857, 77)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.ReadOnly = True
		Me.txtQuantity.Size = New System.Drawing.Size(39, 21)
		Me.txtQuantity.TabIndex = 49
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(817, 80)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(34, 15)
		Me.lblTotal.TabIndex = 50
		Me.lblTotal.Text = "Total"
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(936, 482)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(87, 27)
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
		Me.btnClear.Location = New System.Drawing.Point(1063, 447)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(87, 27)
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
		Me.btnAdd.Location = New System.Drawing.Point(936, 414)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(87, 27)
		Me.btnAdd.TabIndex = 63
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = False
		'
		'lblServiceDate
		'
		Me.lblServiceDate.AutoSize = True
		Me.lblServiceDate.Location = New System.Drawing.Point(866, 260)
		Me.lblServiceDate.Name = "lblServiceDate"
		Me.lblServiceDate.Size = New System.Drawing.Size(74, 15)
		Me.lblServiceDate.TabIndex = 62
		Me.lblServiceDate.Text = "Service date"
		'
		'lblHolderID
		'
		Me.lblHolderID.AutoSize = True
		Me.lblHolderID.Location = New System.Drawing.Point(866, 342)
		Me.lblHolderID.Name = "lblHolderID"
		Me.lblHolderID.Size = New System.Drawing.Size(59, 15)
		Me.lblHolderID.TabIndex = 59
		Me.lblHolderID.Text = "Holder ID"
		'
		'txtHolderID
		'
		Me.txtHolderID.Location = New System.Drawing.Point(959, 339)
		Me.txtHolderID.Name = "txtHolderID"
		Me.txtHolderID.ReadOnly = True
		Me.txtHolderID.Size = New System.Drawing.Size(191, 21)
		Me.txtHolderID.TabIndex = 58
		'
		'lblInstrument
		'
		Me.lblInstrument.AutoSize = True
		Me.lblInstrument.Location = New System.Drawing.Point(866, 225)
		Me.lblInstrument.Name = "lblInstrument"
		Me.lblInstrument.Size = New System.Drawing.Size(65, 15)
		Me.lblInstrument.TabIndex = 57
		Me.lblInstrument.Text = "Instrument"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(866, 195)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(41, 15)
		Me.lblName.TabIndex = 56
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(959, 192)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(191, 21)
		Me.txtName.TabIndex = 55
		'
		'dtpServiceDate
		'
		Me.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpServiceDate.Location = New System.Drawing.Point(959, 253)
		Me.dtpServiceDate.Name = "dtpServiceDate"
		Me.dtpServiceDate.Size = New System.Drawing.Size(191, 21)
		Me.dtpServiceDate.TabIndex = 54
		'
		'lblSerialNo
		'
		Me.lblSerialNo.AutoSize = True
		Me.lblSerialNo.Location = New System.Drawing.Point(866, 165)
		Me.lblSerialNo.Name = "lblSerialNo"
		Me.lblSerialNo.Size = New System.Drawing.Size(85, 15)
		Me.lblSerialNo.TabIndex = 53
		Me.lblSerialNo.Text = "Serial number"
		'
		'cmbInstrument
		'
		Me.cmbInstrument.FormattingEnabled = True
		Me.cmbInstrument.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrument.Location = New System.Drawing.Point(959, 222)
		Me.cmbInstrument.Name = "cmbInstrument"
		Me.cmbInstrument.Size = New System.Drawing.Size(191, 23)
		Me.cmbInstrument.TabIndex = 52
		'
		'txtSerialNo
		'
		Me.txtSerialNo.Location = New System.Drawing.Point(959, 162)
		Me.txtSerialNo.Name = "txtSerialNo"
		Me.txtSerialNo.Size = New System.Drawing.Size(191, 21)
		Me.txtSerialNo.TabIndex = 51
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(936, 447)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
		Me.btnUpdate.TabIndex = 66
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'lblHolderName
		'
		Me.lblHolderName.AutoSize = True
		Me.lblHolderName.Location = New System.Drawing.Point(866, 372)
		Me.lblHolderName.Name = "lblHolderName"
		Me.lblHolderName.Size = New System.Drawing.Size(79, 15)
		Me.lblHolderName.TabIndex = 78
		Me.lblHolderName.Text = "Holder name"
		'
		'txtHolderName
		'
		Me.txtHolderName.BackColor = System.Drawing.SystemColors.Control
		Me.txtHolderName.Location = New System.Drawing.Point(959, 369)
		Me.txtHolderName.Name = "txtHolderName"
		Me.txtHolderName.ReadOnly = True
		Me.txtHolderName.Size = New System.Drawing.Size(191, 21)
		Me.txtHolderName.TabIndex = 77
		'
		'lblInstrumentID
		'
		Me.lblInstrumentID.AutoSize = True
		Me.lblInstrumentID.Location = New System.Drawing.Point(866, 135)
		Me.lblInstrumentID.Name = "lblInstrumentID"
		Me.lblInstrumentID.Size = New System.Drawing.Size(80, 15)
		Me.lblInstrumentID.TabIndex = 80
		Me.lblInstrumentID.Text = "Instrument ID"
		'
		'txtInstrumentID
		'
		Me.txtInstrumentID.Location = New System.Drawing.Point(959, 132)
		Me.txtInstrumentID.Name = "txtInstrumentID"
		Me.txtInstrumentID.ReadOnly = True
		Me.txtInstrumentID.Size = New System.Drawing.Size(191, 21)
		Me.txtInstrumentID.TabIndex = 79
		'
		'btnFindAll
		'
		Me.btnFindAll.BackColor = System.Drawing.Color.Firebrick
		Me.btnFindAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFindAll.ForeColor = System.Drawing.Color.White
		Me.btnFindAll.Location = New System.Drawing.Point(1062, 48)
		Me.btnFindAll.Name = "btnFindAll"
		Me.btnFindAll.Size = New System.Drawing.Size(96, 52)
		Me.btnFindAll.TabIndex = 81
		Me.btnFindAll.Text = "Find all instruments"
		Me.btnFindAll.UseVisualStyleBackColor = False
		'
		'cmbHolder
		'
		Me.cmbHolder.FormattingEnabled = True
		Me.cmbHolder.Items.AddRange(New Object() {""})
		Me.cmbHolder.Location = New System.Drawing.Point(959, 297)
		Me.cmbHolder.Name = "cmbHolder"
		Me.cmbHolder.Size = New System.Drawing.Size(191, 23)
		Me.cmbHolder.TabIndex = 82
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(866, 300)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(79, 15)
		Me.Label1.TabIndex = 83
		Me.Label1.Text = "Select holder"
		'
		'frmInstrument
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1178, 519)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cmbHolder)
		Me.Controls.Add(Me.btnFindAll)
		Me.Controls.Add(Me.lblInstrumentID)
		Me.Controls.Add(Me.txtInstrumentID)
		Me.Controls.Add(Me.lblHolderName)
		Me.Controls.Add(Me.txtHolderName)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.lblServiceDate)
		Me.Controls.Add(Me.lblHolderID)
		Me.Controls.Add(Me.txtHolderID)
		Me.Controls.Add(Me.lblInstrument)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.dtpServiceDate)
		Me.Controls.Add(Me.lblSerialNo)
		Me.Controls.Add(Me.cmbInstrument)
		Me.Controls.Add(Me.txtSerialNo)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.txtQuantity)
		Me.Controls.Add(Me.btnFindAvailable)
		Me.Controls.Add(Me.cmbInstrumentSearch)
		Me.Controls.Add(Me.dgvInstrumentSearch)
		Me.Controls.Add(Me.dgvInstruments)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmInstrument"
		Me.Text = "viewInstrument"
		CType(Me.dgvInstruments, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvInstrumentSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvInstruments As DataGridView
	Friend WithEvents dgvInstrumentSearch As DataGridView
	Friend WithEvents cmbInstrumentSearch As ComboBox
	Friend WithEvents btnFindAvailable As Button
	Friend WithEvents txtQuantity As TextBox
	Friend WithEvents lblTotal As Label
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnAdd As Button
	Friend WithEvents lblServiceDate As Label
	Friend WithEvents lblHolderID As Label
	Friend WithEvents txtHolderID As TextBox
	Friend WithEvents lblInstrument As Label
	Friend WithEvents lblName As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents dtpServiceDate As DateTimePicker
	Friend WithEvents lblSerialNo As Label
	Friend WithEvents cmbInstrument As ComboBox
	Friend WithEvents txtSerialNo As TextBox
	Friend WithEvents btnUpdate As Button
    Friend WithEvents lblHolderName As Label
    Friend WithEvents txtHolderName As TextBox
	Friend WithEvents lblInstrumentID As Label
	Friend WithEvents txtInstrumentID As TextBox
	Friend WithEvents btnFindAll As Button
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colSerialNo As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colInstrument As DataGridViewTextBoxColumn
	Friend WithEvents colHolderID As DataGridViewTextBoxColumn
	Friend WithEvents colHolderName As DataGridViewTextBoxColumn
	Friend WithEvents colServiceDate As DataGridViewTextBoxColumn
	Friend WithEvents colInstrumentIDSearch As DataGridViewTextBoxColumn
	Friend WithEvents colSerialNoSearch As DataGridViewTextBoxColumn
	Friend WithEvents colNameSearch As DataGridViewTextBoxColumn
	Friend WithEvents colInstrumentSearch As DataGridViewTextBoxColumn
	Friend WithEvents colIdSearch As DataGridViewTextBoxColumn
	Friend WithEvents colHolderNameSearch As DataGridViewTextBoxColumn
	Friend WithEvents colServiceDateSearch As DataGridViewTextBoxColumn
	Friend WithEvents cmbHolder As ComboBox
	Friend WithEvents Label1 As Label
End Class
