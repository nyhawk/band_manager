<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayerEventsResponse
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlayerEventsResponse))
		Me.lstPlayers = New System.Windows.Forms.ListView()
		Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colInstrument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnBack = New System.Windows.Forms.Button()
		Me.lblIdDate = New System.Windows.Forms.Label()
		Me.lblAddress = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lstPlayers
		'
		Me.lstPlayers.BackColor = System.Drawing.Color.White
		Me.lstPlayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colInstrument})
		Me.lstPlayers.HideSelection = False
		Me.lstPlayers.Location = New System.Drawing.Point(14, 76)
		Me.lstPlayers.Name = "lstPlayers"
		Me.lstPlayers.Size = New System.Drawing.Size(581, 544)
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
		Me.btnBack.BackColor = System.Drawing.Color.Firebrick
		Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(509, 43)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(87, 27)
		Me.btnBack.TabIndex = 1
		Me.btnBack.Text = "Back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'lblIdDate
		'
		Me.lblIdDate.AutoSize = True
		Me.lblIdDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIdDate.Location = New System.Drawing.Point(14, 21)
		Me.lblIdDate.Name = "lblIdDate"
		Me.lblIdDate.Size = New System.Drawing.Size(123, 18)
		Me.lblIdDate.TabIndex = 2
		Me.lblIdDate.Text = "Event ID and date"
		'
		'lblAddress
		'
		Me.lblAddress.AutoSize = True
		Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress.Location = New System.Drawing.Point(14, 48)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(62, 18)
		Me.lblAddress.TabIndex = 3
		Me.lblAddress.Text = "Address"
		'
		'frmPlayerEventsResponse
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(644, 635)
		Me.Controls.Add(Me.lblAddress)
		Me.Controls.Add(Me.lblIdDate)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.lstPlayers)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmPlayerEventsResponse"
		Me.Text = "Event responses"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lstPlayers As ListView
	Friend WithEvents colID As ColumnHeader
	Friend WithEvents colName As ColumnHeader
	Friend WithEvents colInstrument As ColumnHeader
	Friend WithEvents btnBack As Button
	Friend WithEvents lblIdDate As Label
	Friend WithEvents lblAddress As Label
End Class
