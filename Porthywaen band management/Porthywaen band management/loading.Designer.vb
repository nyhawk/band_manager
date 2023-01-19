<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loading))
		Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.SuspendLayout()
		'
		'tmrLoading
		'
		Me.tmrLoading.Enabled = True
		Me.tmrLoading.Interval = 50
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.Color.Firebrick
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(267, 103)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(500, 31)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.Text = "Porthywaen Silver Band Management"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(12, 497)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
		Me.ProgressBar1.TabIndex = 2
		'
		'loading
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(961, 532)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.lblTitle)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "loading"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents tmrLoading As Timer
	Friend WithEvents lblTitle As Label
	Friend WithEvents ProgressBar1 As ProgressBar
End Class
