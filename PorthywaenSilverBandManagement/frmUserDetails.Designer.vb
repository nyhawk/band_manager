<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserDetails
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserDetails))
		Me.lblRole = New System.Windows.Forms.Label()
		Me.cmbRole = New System.Windows.Forms.ComboBox()
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
		Me.SuspendLayout()
		'
		'lblRole
		'
		Me.lblRole.AutoSize = True
		Me.lblRole.Location = New System.Drawing.Point(31, 357)
		Me.lblRole.Name = "lblRole"
		Me.lblRole.Size = New System.Drawing.Size(33, 15)
		Me.lblRole.TabIndex = 110
		Me.lblRole.Text = "Role"
		'
		'cmbRole
		'
		Me.cmbRole.FormattingEnabled = True
		Me.cmbRole.Items.AddRange(New Object() {"Player", "Dep", "Committee member", "Librarian", "Instruments", "Events", "Treasurer", "Conductor"})
		Me.cmbRole.Location = New System.Drawing.Point(122, 352)
		Me.cmbRole.Name = "cmbRole"
		Me.cmbRole.Size = New System.Drawing.Size(189, 23)
		Me.cmbRole.TabIndex = 109
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.Firebrick
		Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(378, 168)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(87, 27)
		Me.btnUpdate.TabIndex = 107
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'lblContact
		'
		Me.lblContact.AutoSize = True
		Me.lblContact.Location = New System.Drawing.Point(374, 50)
		Me.lblContact.Name = "lblContact"
		Me.lblContact.Size = New System.Drawing.Size(111, 15)
		Me.lblContact.TabIndex = 106
		Me.lblContact.Text = "Emergency contact"
		'
		'lblContPhone
		'
		Me.lblContPhone.AutoSize = True
		Me.lblContPhone.Location = New System.Drawing.Point(374, 111)
		Me.lblContPhone.Name = "lblContPhone"
		Me.lblContPhone.Size = New System.Drawing.Size(43, 15)
		Me.lblContPhone.TabIndex = 104
		Me.lblContPhone.Text = "Phone"
		'
		'txtContPhone
		'
		Me.txtContPhone.Location = New System.Drawing.Point(437, 103)
		Me.txtContPhone.Name = "txtContPhone"
		Me.txtContPhone.Size = New System.Drawing.Size(189, 21)
		Me.txtContPhone.TabIndex = 103
		'
		'lblContName
		'
		Me.lblContName.AutoSize = True
		Me.lblContName.Location = New System.Drawing.Point(374, 81)
		Me.lblContName.Name = "lblContName"
		Me.lblContName.Size = New System.Drawing.Size(41, 15)
		Me.lblContName.TabIndex = 102
		Me.lblContName.Text = "Name"
		'
		'txtContName
		'
		Me.txtContName.Location = New System.Drawing.Point(437, 73)
		Me.txtContName.Name = "txtContName"
		Me.txtContName.Size = New System.Drawing.Size(189, 21)
		Me.txtContName.TabIndex = 101
		'
		'chkStarters
		'
		Me.chkStarters.Location = New System.Drawing.Point(318, 327)
		Me.chkStarters.Name = "chkStarters"
		Me.chkStarters.Size = New System.Drawing.Size(73, 20)
		Me.chkStarters.TabIndex = 100
		Me.chkStarters.Text = "Starters"
		Me.chkStarters.UseVisualStyleBackColor = True
		'
		'chkPBB
		'
		Me.chkPBB.Location = New System.Drawing.Point(255, 327)
		Me.chkPBB.Name = "chkPBB"
		Me.chkPBB.Size = New System.Drawing.Size(55, 20)
		Me.chkPBB.TabIndex = 99
		Me.chkPBB.Text = "PBB"
		Me.chkPBB.UseVisualStyleBackColor = True
		'
		'chkPYTB
		'
		Me.chkPYTB.Location = New System.Drawing.Point(185, 327)
		Me.chkPYTB.Name = "chkPYTB"
		Me.chkPYTB.Size = New System.Drawing.Size(63, 20)
		Me.chkPYTB.TabIndex = 98
		Me.chkPYTB.Text = "PYTB"
		Me.chkPYTB.UseVisualStyleBackColor = True
		'
		'chkPSB
		'
		Me.chkPSB.Location = New System.Drawing.Point(122, 327)
		Me.chkPSB.Name = "chkPSB"
		Me.chkPSB.Size = New System.Drawing.Size(55, 20)
		Me.chkPSB.TabIndex = 97
		Me.chkPSB.Text = "PSB"
		Me.chkPSB.UseVisualStyleBackColor = True
		'
		'chkPhotoPerm
		'
		Me.chkPhotoPerm.Location = New System.Drawing.Point(122, 288)
		Me.chkPhotoPerm.Name = "chkPhotoPerm"
		Me.chkPhotoPerm.Size = New System.Drawing.Size(192, 20)
		Me.chkPhotoPerm.TabIndex = 96
		Me.chkPhotoPerm.Text = "Photograph permission"
		Me.chkPhotoPerm.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 260)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(36, 15)
		Me.Label1.TabIndex = 95
		Me.Label1.Text = "Level"
		'
		'cmbLevel
		'
		Me.cmbLevel.FormattingEnabled = True
		Me.cmbLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "8+"})
		Me.cmbLevel.Location = New System.Drawing.Point(122, 256)
		Me.cmbLevel.Name = "cmbLevel"
		Me.cmbLevel.Size = New System.Drawing.Size(189, 23)
		Me.cmbLevel.TabIndex = 94
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.Firebrick
		Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(378, 198)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(87, 27)
		Me.btnClear.TabIndex = 93
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = False
		'
		'lblDOB
		'
		Me.lblDOB.AutoSize = True
		Me.lblDOB.Location = New System.Drawing.Point(31, 135)
		Me.lblDOB.Name = "lblDOB"
		Me.lblDOB.Size = New System.Drawing.Size(33, 15)
		Me.lblDOB.TabIndex = 91
		Me.lblDOB.Text = "DOB"
		'
		'lblHoldername
		'
		Me.lblHoldername.AutoSize = True
		Me.lblHoldername.Location = New System.Drawing.Point(31, 198)
		Me.lblHoldername.Name = "lblHoldername"
		Me.lblHoldername.Size = New System.Drawing.Size(43, 15)
		Me.lblHoldername.TabIndex = 90
		Me.lblHoldername.Text = "Phone"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(122, 195)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(189, 21)
		Me.txtPhone.TabIndex = 89
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(31, 168)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(39, 15)
		Me.lblEmail.TabIndex = 88
		Me.lblEmail.Text = "Email"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(122, 165)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(189, 21)
		Me.txtEmail.TabIndex = 87
		'
		'lblInstrument
		'
		Me.lblInstrument.AutoSize = True
		Me.lblInstrument.Location = New System.Drawing.Point(31, 228)
		Me.lblInstrument.Name = "lblInstrument"
		Me.lblInstrument.Size = New System.Drawing.Size(65, 15)
		Me.lblInstrument.TabIndex = 86
		Me.lblInstrument.Text = "Instrument"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(31, 108)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(41, 15)
		Me.lblName.TabIndex = 85
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(122, 105)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(189, 21)
		Me.txtName.TabIndex = 84
		'
		'dtpDOB
		'
		Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpDOB.Location = New System.Drawing.Point(122, 135)
		Me.dtpDOB.MaxDate = New Date(2023, 2, 7, 0, 0, 0, 0)
		Me.dtpDOB.Name = "dtpDOB"
		Me.dtpDOB.Size = New System.Drawing.Size(189, 21)
		Me.dtpDOB.TabIndex = 83
		Me.dtpDOB.Value = New Date(2023, 2, 7, 0, 0, 0, 0)
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(31, 78)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(19, 15)
		Me.lblID.TabIndex = 82
		Me.lblID.Text = "ID"
		'
		'cmbInstrument
		'
		Me.cmbInstrument.FormattingEnabled = True
		Me.cmbInstrument.Items.AddRange(New Object() {"Soprano cornet", "Cornet", "Flugelhorn", "Tenor horn", "Baritone", "Euphonium", "Tenor trombone", "Bass trombone", "Eb bass", "Bb bass"})
		Me.cmbInstrument.Location = New System.Drawing.Point(122, 225)
		Me.cmbInstrument.Name = "cmbInstrument"
		Me.cmbInstrument.Size = New System.Drawing.Size(189, 23)
		Me.cmbInstrument.TabIndex = 81
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(122, 77)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(189, 21)
		Me.txtID.TabIndex = 80
		'
		'frmUserDetails
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(647, 430)
		Me.Controls.Add(Me.lblRole)
		Me.Controls.Add(Me.cmbRole)
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
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmUserDetails"
		Me.Text = "User details"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
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
