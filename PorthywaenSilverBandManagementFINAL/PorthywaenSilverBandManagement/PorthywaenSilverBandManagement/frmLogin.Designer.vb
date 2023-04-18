<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.lblName = New System.Windows.Forms.Label()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.Firebrick
		Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogin.ForeColor = System.Drawing.Color.White
		Me.btnLogin.Location = New System.Drawing.Point(48, 115)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(87, 46)
		Me.btnLogin.TabIndex = 0
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(133, 73)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(116, 21)
		Me.txtPassword.TabIndex = 1
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(133, 43)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(116, 21)
		Me.txtName.TabIndex = 2
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(44, 76)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(61, 15)
		Me.lblPassword.TabIndex = 3
		Me.lblPassword.Text = "Password"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(44, 46)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(41, 15)
		Me.lblName.TabIndex = 4
		Me.lblName.Text = "Name"
		'
		'btnReset
		'
		Me.btnReset.BackColor = System.Drawing.Color.Firebrick
		Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnReset.ForeColor = System.Drawing.Color.White
		Me.btnReset.Location = New System.Drawing.Point(142, 115)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(87, 46)
		Me.btnReset.TabIndex = 5
		Me.btnReset.Text = "Reset password"
		Me.btnReset.UseVisualStyleBackColor = False
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(370, 198)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.btnLogin)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmLogin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLogin As Button
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents lblPassword As Label
	Friend WithEvents lblName As Label
	Friend WithEvents btnReset As Button
End Class
