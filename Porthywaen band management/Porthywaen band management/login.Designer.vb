<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblID = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(194, 37)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(75, 23)
		Me.btnLogin.TabIndex = 0
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(59, 39)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(100, 20)
		Me.txtID.TabIndex = 1
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(59, 76)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(100, 20)
		Me.txtName.TabIndex = 2
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(26, 39)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(18, 13)
		Me.lblID.TabIndex = 3
		Me.lblID.Text = "ID"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(18, 79)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 4
		Me.lblName.Text = "Name"
		'
		'login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(317, 172)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.btnLogin)
		Me.Name = "login"
		Me.Text = "login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogin As Button
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents lblID As Label
	Friend WithEvents lblName As Label
End Class
