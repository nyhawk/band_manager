<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvents
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvents))
		Me.cdrCalendar = New System.Windows.Forms.MonthCalendar()
		Me.dgvDay = New System.Windows.Forms.DataGridView()
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
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colMusic = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPlaying = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		CType(Me.dgvDay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cdrCalendar
		'
		Me.cdrCalendar.Location = New System.Drawing.Point(21, 38)
		Me.cdrCalendar.Margin = New System.Windows.Forms.Padding(10)
		Me.cdrCalendar.Name = "cdrCalendar"
		Me.cdrCalendar.TabIndex = 0
		'
		'dgvDay
		'
		Me.dgvDay.AllowUserToAddRows = False
		Me.dgvDay.AllowUserToDeleteRows = False
		Me.dgvDay.BackgroundColor = System.Drawing.Color.White
		Me.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colAddress, Me.colDate, Me.colStartTime, Me.colGroup, Me.colMusic, Me.colPlaying})
		Me.dgvDay.Location = New System.Drawing.Point(21, 239)
		Me.dgvDay.Name = "dgvDay"
		Me.dgvDay.Size = New System.Drawing.Size(757, 286)
		Me.dgvDay.TabIndex = 1
		'
		'lblMusic
		'
		Me.lblMusic.AutoSize = True
		Me.lblMusic.Location = New System.Drawing.Point(827, 293)
		Me.lblMusic.Name = "lblMusic"
		Me.lblMusic.Size = New System.Drawing.Size(40, 15)
		Me.lblMusic.TabIndex = 95
		Me.lblMusic.Text = "Music"
		'
		'txtMusic
		'
		Me.txtMusic.Location = New System.Drawing.Point(920, 290)
		Me.txtMusic.Multiline = True
		Me.txtMusic.Name = "txtMusic"
		Me.txtMusic.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtMusic.Size = New System.Drawing.Size(191, 89)
		Me.txtMusic.TabIndex = 94
		'
		'lblContPhone
		'
		Me.lblContPhone.AutoSize = True
		Me.lblContPhone.Location = New System.Drawing.Point(827, 450)
		Me.lblContPhone.Name = "lblContPhone"
		Me.lblContPhone.Size = New System.Drawing.Size(43, 15)
		Me.lblContPhone.TabIndex = 93
		Me.lblContPhone.Text = "Phone"
		'
		'txtCustomerPhone
		'
		Me.txtCustomerPhone.Location = New System.Drawing.Point(920, 447)
		Me.txtCustomerPhone.Name = "txtCustomerPhone"
		Me.txtCustomerPhone.Size = New System.Drawing.Size(191, 21)
		Me.txtCustomerPhone.TabIndex = 92
		'
		'lblContName
		'
		Me.lblContName.AutoSize = True
		Me.lblContName.Location = New System.Drawing.Point(827, 420)
		Me.lblContName.Name = "lblContName"
		Me.lblContName.Size = New System.Drawing.Size(41, 15)
		Me.lblContName.TabIndex = 91
		Me.lblContName.Text = "Name"
		'
		'txtCustomerName
		'
		Me.txtCustomerName.Location = New System.Drawing.Point(920, 417)
		Me.txtCustomerName.Name = "txtCustomerName"
		Me.txtCustomerName.Size = New System.Drawing.Size(191, 21)
		Me.txtCustomerName.TabIndex = 90
		'
		'chkStarters
		'
		Me.chkStarters.AutoSize = True
		Me.chkStarters.Location = New System.Drawing.Point(1114, 263)
		Me.chkStarters.Name = "chkStarters"
		Me.chkStarters.Size = New System.Drawing.Size(68, 19)
		Me.chkStarters.TabIndex = 89
		Me.chkStarters.Text = "Starters"
		Me.chkStarters.UseVisualStyleBackColor = True
		'
		'chkPBB
		'
		Me.chkPBB.AutoSize = True
		Me.chkPBB.Location = New System.Drawing.Point(1052, 263)
		Me.chkPBB.Name = "chkPBB"
		Me.chkPBB.Size = New System.Drawing.Size(50, 19)
		Me.chkPBB.TabIndex = 88
		Me.chkPBB.Text = "PBB"
		Me.chkPBB.UseVisualStyleBackColor = True
		'
		'chkPYTB
		'
		Me.chkPYTB.AutoSize = True
		Me.chkPYTB.Location = New System.Drawing.Point(982, 263)
		Me.chkPYTB.Name = "chkPYTB"
		Me.chkPYTB.Size = New System.Drawing.Size(56, 19)
		Me.chkPYTB.TabIndex = 87
		Me.chkPYTB.Text = "PYTB"
		Me.chkPYTB.UseVisualStyleBackColor = True
		'
		'chkPSB
		'
		Me.chkPSB.AutoSize = True
		Me.chkPSB.Location = New System.Drawing.Point(920, 263)
		Me.chkPSB.Name = "chkPSB"
		Me.chkPSB.Size = New System.Drawing.Size(50, 19)
		Me.chkPSB.TabIndex = 86
		Me.chkPSB.Text = "PSB"
		Me.chkPSB.UseVisualStyleBackColor = True
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Location = New System.Drawing.Point(829, 163)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(33, 15)
		Me.lblDate.TabIndex = 82
		Me.lblDate.Text = "Date"
		'
		'lblTime
		'
		Me.lblTime.AutoSize = True
		Me.lblTime.Location = New System.Drawing.Point(826, 196)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(59, 15)
		Me.lblTime.TabIndex = 81
		Me.lblTime.Text = "Start time"
		'
		'txtStartTime
		'
		Me.txtStartTime.Location = New System.Drawing.Point(919, 193)
		Me.txtStartTime.Name = "txtStartTime"
		Me.txtStartTime.Size = New System.Drawing.Size(191, 21)
		Me.txtStartTime.TabIndex = 80
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(827, 480)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(39, 15)
		Me.lblEmail.TabIndex = 79
		Me.lblEmail.Text = "Email"
		'
		'txtCustomerEmail
		'
		Me.txtCustomerEmail.Location = New System.Drawing.Point(920, 477)
		Me.txtCustomerEmail.Name = "txtCustomerEmail"
		Me.txtCustomerEmail.Size = New System.Drawing.Size(191, 21)
		Me.txtCustomerEmail.TabIndex = 78
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(827, 73)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(51, 15)
		Me.lblName.TabIndex = 77
		Me.lblName.Text = "Address"
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(920, 69)
		Me.txtAddress.Multiline = True
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(191, 51)
		Me.txtAddress.TabIndex = 76
		'
		'dtpDate
		'
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpDate.Location = New System.Drawing.Point(919, 163)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(191, 21)
		Me.dtpDate.TabIndex = 75
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(827, 43)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(52, 15)
		Me.lblID.TabIndex = 74
		Me.lblID.Text = "Event ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(920, 39)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(191, 21)
		Me.txtID.TabIndex = 73
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
		Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(650, 62)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(87, 59)
		Me.btnDelete.TabIndex = 97
		Me.btnDelete.Text = "Delete event"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
		Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAdd.ForeColor = System.Drawing.Color.White
		Me.btnAdd.Location = New System.Drawing.Point(457, 62)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(87, 59)
		Me.btnAdd.TabIndex = 96
		Me.btnAdd.Text = "Add event"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(555, 61)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(87, 60)
		Me.btnUpdate.TabIndex = 98
		Me.btnUpdate.Text = "Update event"
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(650, 128)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(87, 61)
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
		Me.btnShowAll.Location = New System.Drawing.Point(300, 62)
		Me.btnShowAll.Name = "btnShowAll"
		Me.btnShowAll.Size = New System.Drawing.Size(87, 59)
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
		Me.btnPlayers.Location = New System.Drawing.Point(300, 128)
		Me.btnPlayers.Name = "btnPlayers"
		Me.btnPlayers.Size = New System.Drawing.Size(87, 61)
		Me.btnPlayers.TabIndex = 102
		Me.btnPlayers.Text = "View available players"
		Me.btnPlayers.UseVisualStyleBackColor = True
		'
		'btnSaveResponse
		'
		Me.btnSaveResponse.BackColor = System.Drawing.Color.Firebrick
		Me.btnSaveResponse.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnSaveResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSaveResponse.ForeColor = System.Drawing.Color.White
		Me.btnSaveResponse.Location = New System.Drawing.Point(457, 128)
		Me.btnSaveResponse.Name = "btnSaveResponse"
		Me.btnSaveResponse.Size = New System.Drawing.Size(87, 61)
		Me.btnSaveResponse.TabIndex = 103
		Me.btnSaveResponse.Text = "Save availablilty"
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
		Me.btnPrint.Location = New System.Drawing.Point(555, 128)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(87, 61)
		Me.btnPrint.TabIndex = 104
		Me.btnPrint.Text = "Print events"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'lblCustomerID
		'
		Me.lblCustomerID.AutoSize = True
		Me.lblCustomerID.Location = New System.Drawing.Point(827, 390)
		Me.lblCustomerID.Name = "lblCustomerID"
		Me.lblCustomerID.Size = New System.Drawing.Size(75, 15)
		Me.lblCustomerID.TabIndex = 106
		Me.lblCustomerID.Text = "Customer ID"
		'
		'txtCustomerID
		'
		Me.txtCustomerID.Location = New System.Drawing.Point(920, 387)
		Me.txtCustomerID.Name = "txtCustomerID"
		Me.txtCustomerID.Size = New System.Drawing.Size(191, 21)
		Me.txtCustomerID.TabIndex = 105
		'
		'lblPostcode
		'
		Me.lblPostcode.AutoSize = True
		Me.lblPostcode.Location = New System.Drawing.Point(827, 132)
		Me.lblPostcode.Name = "lblPostcode"
		Me.lblPostcode.Size = New System.Drawing.Size(58, 15)
		Me.lblPostcode.TabIndex = 108
		Me.lblPostcode.Text = "Postcode"
		'
		'txtPostcode
		'
		Me.txtPostcode.Location = New System.Drawing.Point(920, 128)
		Me.txtPostcode.Name = "txtPostcode"
		Me.txtPostcode.Size = New System.Drawing.Size(191, 21)
		Me.txtPostcode.TabIndex = 107
		'
		'lblArrivalTime
		'
		Me.lblArrivalTime.AutoSize = True
		Me.lblArrivalTime.Location = New System.Drawing.Point(827, 226)
		Me.lblArrivalTime.Name = "lblArrivalTime"
		Me.lblArrivalTime.Size = New System.Drawing.Size(67, 15)
		Me.lblArrivalTime.TabIndex = 110
		Me.lblArrivalTime.Text = "Arrival time"
		'
		'txtArrivalTime
		'
		Me.txtArrivalTime.Location = New System.Drawing.Point(920, 223)
		Me.txtArrivalTime.Name = "txtArrivalTime"
		Me.txtArrivalTime.Size = New System.Drawing.Size(191, 21)
		Me.txtArrivalTime.TabIndex = 109
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.Width = 50
		'
		'colAddress
		'
		Me.colAddress.HeaderText = "Address"
		Me.colAddress.Name = "colAddress"
		'
		'colDate
		'
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		'
		'colStartTime
		'
		Me.colStartTime.HeaderText = "Start time"
		Me.colStartTime.Name = "colStartTime"
		Me.colStartTime.Width = 50
		'
		'colGroup
		'
		Me.colGroup.HeaderText = "Groups(s)"
		Me.colGroup.Name = "colGroup"
		'
		'colMusic
		'
		Me.colMusic.HeaderText = "Music"
		Me.colMusic.Name = "colMusic"
		Me.colMusic.Width = 150
		'
		'colPlaying
		'
		Me.colPlaying.HeaderText = "Available?"
		Me.colPlaying.Name = "colPlaying"
		Me.colPlaying.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colPlaying.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.colPlaying.Width = 70
		'
		'frmEvents
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1193, 549)
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
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmEvents"
		Me.Text = "Events"
		CType(Me.dgvDay, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblPostcode As Label
    Friend WithEvents txtPostcode As TextBox
    Public WithEvents lblArrivalTime As Label
    Friend WithEvents txtArrivalTime As TextBox
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colAddress As DataGridViewTextBoxColumn
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colStartTime As DataGridViewTextBoxColumn
	Friend WithEvents colGroup As DataGridViewTextBoxColumn
	Friend WithEvents colMusic As DataGridViewTextBoxColumn
	Friend WithEvents colPlaying As DataGridViewCheckBoxColumn
End Class
