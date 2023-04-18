<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMusic
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusic))
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
		CType(Me.dgvMusic, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvMusic
		'
		Me.dgvMusic.AllowUserToAddRows = False
		Me.dgvMusic.AllowUserToDeleteRows = False
		Me.dgvMusic.BackgroundColor = System.Drawing.Color.White
		Me.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvMusic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colTitle, Me.colWriter})
		Me.dgvMusic.Location = New System.Drawing.Point(14, 31)
		Me.dgvMusic.Name = "dgvMusic"
		Me.dgvMusic.ReadOnly = True
		Me.dgvMusic.Size = New System.Drawing.Size(548, 226)
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
		Me.colTitle.Width = 200
		'
		'colWriter
		'
		Me.colWriter.HeaderText = "Writer"
		Me.colWriter.Name = "colWriter"
		Me.colWriter.ReadOnly = True
		Me.colWriter.Width = 150
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(1009, 171)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(87, 27)
		Me.btnClear.TabIndex = 49
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
		Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdd.ForeColor = System.Drawing.Color.White
		Me.btnAdd.Location = New System.Drawing.Point(725, 171)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(87, 27)
		Me.btnAdd.TabIndex = 48
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = False
		'
		'lblWriter
		'
		Me.lblWriter.AutoSize = True
		Me.lblWriter.Location = New System.Drawing.Point(668, 90)
		Me.lblWriter.Name = "lblWriter"
		Me.lblWriter.Size = New System.Drawing.Size(86, 30)
		Me.lblWriter.TabIndex = 47
		Me.lblWriter.Text = "Composer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(and arranger)"
		'
		'txtWriter
		'
		Me.txtWriter.Location = New System.Drawing.Point(765, 97)
		Me.txtWriter.Name = "txtWriter"
		Me.txtWriter.Size = New System.Drawing.Size(191, 21)
		Me.txtWriter.TabIndex = 46
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Location = New System.Drawing.Point(668, 67)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(30, 15)
		Me.lblTitle.TabIndex = 45
		Me.lblTitle.Text = "Title"
		'
		'txtTitle
		'
		Me.txtTitle.Location = New System.Drawing.Point(765, 67)
		Me.txtTitle.Name = "txtTitle"
		Me.txtTitle.Size = New System.Drawing.Size(191, 21)
		Me.txtTitle.TabIndex = 44
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(672, 40)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(19, 15)
		Me.lblID.TabIndex = 43
		Me.lblID.Text = "ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(765, 37)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(191, 21)
		Me.txtID.TabIndex = 42
		'
		'txtSearch
		'
		Me.txtSearch.Location = New System.Drawing.Point(765, 281)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(191, 21)
		Me.txtSearch.TabIndex = 50
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(672, 287)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(30, 15)
		Me.Label1.TabIndex = 51
		Me.Label1.Text = "Title"
		'
		'btnSearch
		'
		Me.btnSearch.BackColor = System.Drawing.Color.Firebrick
		Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSearch.ForeColor = System.Drawing.Color.White
		Me.btnSearch.Location = New System.Drawing.Point(1009, 275)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(87, 27)
		Me.btnSearch.TabIndex = 52
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = False
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(820, 171)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
		Me.btnUpdate.TabIndex = 53
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(914, 171)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(87, 27)
		Me.btnDelete.TabIndex = 54
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'dgvSearch
		'
		Me.dgvSearch.AllowUserToAddRows = False
		Me.dgvSearch.AllowUserToDeleteRows = False
		Me.dgvSearch.BackgroundColor = System.Drawing.Color.White
		Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
		Me.dgvSearch.Location = New System.Drawing.Point(14, 277)
		Me.dgvSearch.Name = "dgvSearch"
		Me.dgvSearch.ReadOnly = True
		Me.dgvSearch.Size = New System.Drawing.Size(548, 218)
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
		Me.DataGridViewTextBoxColumn2.Width = 200
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.HeaderText = "Writer"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		Me.DataGridViewTextBoxColumn3.Width = 150
		'
		'frmMusic
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1193, 549)
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
		Me.Controls.Add(Me.dgvMusic)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMusic"
		Me.Text = "Music"
		CType(Me.dgvMusic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvMusic As DataGridView
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
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colTitle As DataGridViewTextBoxColumn
	Friend WithEvents colWriter As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
