<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playerEventsResponse
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
		Me.lstPlayers = New System.Windows.Forms.ListView()
		Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colInstrument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnBack = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lstPlayers
		'
		Me.lstPlayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colInstrument})
		Me.lstPlayers.HideSelection = False
		Me.lstPlayers.Location = New System.Drawing.Point(128, 36)
		Me.lstPlayers.Name = "lstPlayers"
		Me.lstPlayers.Size = New System.Drawing.Size(499, 255)
		Me.lstPlayers.TabIndex = 0
		Me.lstPlayers.UseCompatibleStateImageBehavior = False
		Me.lstPlayers.View = System.Windows.Forms.View.Details
		'
		'colID
		'
		Me.colID.Text = "Player ID"
		'
		'colName
		'
		Me.colName.Text = "Name"
		Me.colName.Width = 200
		'
		'colInstrument
		'
		Me.colInstrument.Text = "Instrument"
		Me.colInstrument.Width = 150
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(515, 343)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(75, 23)
		Me.btnBack.TabIndex = 1
		Me.btnBack.Text = "Back"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'playerEventsResponse
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.lstPlayers)
		Me.Name = "playerEventsResponse"
		Me.Text = "playerEventsResponse"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lstPlayers As ListView
	Friend WithEvents colID As ColumnHeader
	Friend WithEvents colName As ColumnHeader
	Friend WithEvents colInstrument As ColumnHeader
	Friend WithEvents btnBack As Button
End Class
