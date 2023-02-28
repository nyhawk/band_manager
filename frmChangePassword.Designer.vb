<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtConfirm = New System.Windows.Forms.TextBox()
		Me.lblConfirm = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(27, 55)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(88, 15)
		Me.lblPassword.TabIndex = 8
		Me.lblPassword.Text = "New password"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(122, 52)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(136, 21)
		Me.txtPassword.TabIndex = 6
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.Firebrick
		Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogin.ForeColor = System.Drawing.Color.White
		Me.btnLogin.Location = New System.Drawing.Point(122, 132)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(87, 53)
		Me.btnLogin.TabIndex = 5
		Me.btnLogin.Text = "Save and login"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'txtConfirm
		'
		Me.txtConfirm.Location = New System.Drawing.Point(122, 83)
		Me.txtConfirm.Name = "txtConfirm"
		Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtConfirm.Size = New System.Drawing.Size(136, 21)
		Me.txtConfirm.TabIndex = 9
		'
		'lblConfirm
		'
		Me.lblConfirm.AutoSize = True
		Me.lblConfirm.Location = New System.Drawing.Point(27, 87)
		Me.lblConfirm.Name = "lblConfirm"
		Me.lblConfirm.Size = New System.Drawing.Size(50, 15)
		Me.lblConfirm.TabIndex = 10
		Me.lblConfirm.Text = "Confirm"
		'
		'frmChangePassword
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(370, 198)
		Me.Controls.Add(Me.lblConfirm)
		Me.Controls.Add(Me.txtConfirm)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.btnLogin)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmChangePassword"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Change password"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblPassword As Label
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents btnLogin As Button
	Friend WithEvents txtConfirm As TextBox
	Friend WithEvents lblConfirm As Label
End Class
