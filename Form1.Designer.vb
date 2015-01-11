<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYESFileImport
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
		Me.btnProcessImportFile = New System.Windows.Forms.Button()
		Me.btnYesImport = New System.Windows.Forms.Button()
		Me.lblYesFile = New System.Windows.Forms.Label()
		Me.YesImportFile = New System.Windows.Forms.OpenFileDialog()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtStreet = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnProcessImportFile
		'
		Me.btnProcessImportFile.Location = New System.Drawing.Point(36, 240)
		Me.btnProcessImportFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnProcessImportFile.Name = "btnProcessImportFile"
		Me.btnProcessImportFile.Size = New System.Drawing.Size(100, 28)
		Me.btnProcessImportFile.TabIndex = 0
		Me.btnProcessImportFile.Text = "Process"
		Me.btnProcessImportFile.UseVisualStyleBackColor = True
		'
		'btnYesImport
		'
		Me.btnYesImport.Location = New System.Drawing.Point(36, 43)
		Me.btnYesImport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnYesImport.Name = "btnYesImport"
		Me.btnYesImport.Size = New System.Drawing.Size(109, 28)
		Me.btnYesImport.TabIndex = 1
		Me.btnYesImport.Text = "Choose file :"
		Me.btnYesImport.UseVisualStyleBackColor = True
		'
		'lblYesFile
		'
		Me.lblYesFile.AutoSize = True
		Me.lblYesFile.Location = New System.Drawing.Point(155, 54)
		Me.lblYesFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblYesFile.Name = "lblYesFile"
		Me.lblYesFile.Size = New System.Drawing.Size(0, 17)
		Me.lblYesFile.TabIndex = 2
		'
		'YesImportFile
		'
		Me.YesImportFile.FileName = "YesImportFile"
		Me.YesImportFile.InitialDirectory = "C:\"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(210, 240)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 28)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit App"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(33, 174)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(138, 17)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Processing Address:"
		'
		'txtStreet
		'
		Me.txtStreet.Location = New System.Drawing.Point(169, 174)
		Me.txtStreet.Name = "txtStreet"
		Me.txtStreet.Size = New System.Drawing.Size(526, 22)
		Me.txtStreet.TabIndex = 5
		'
		'frmYESFileImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1701, 505)
		Me.Controls.Add(Me.txtStreet)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.lblYesFile)
		Me.Controls.Add(Me.btnYesImport)
		Me.Controls.Add(Me.btnProcessImportFile)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "frmYESFileImport"
		Me.Text = "YES File Import"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnProcessImportFile As System.Windows.Forms.Button
	Friend WithEvents btnYesImport As System.Windows.Forms.Button
	Friend WithEvents lblYesFile As System.Windows.Forms.Label
	Friend WithEvents YesImportFile As System.Windows.Forms.OpenFileDialog
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtStreet As System.Windows.Forms.TextBox

End Class
