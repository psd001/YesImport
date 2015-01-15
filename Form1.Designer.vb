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
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnProcessImportFile
		'
		Me.btnProcessImportFile.Enabled = False
		Me.btnProcessImportFile.Location = New System.Drawing.Point(27, 195)
		Me.btnProcessImportFile.Name = "btnProcessImportFile"
		Me.btnProcessImportFile.Size = New System.Drawing.Size(75, 23)
		Me.btnProcessImportFile.TabIndex = 0
		Me.btnProcessImportFile.Text = "Process"
		Me.btnProcessImportFile.UseVisualStyleBackColor = True
		'
		'btnYesImport
		'
		Me.btnYesImport.Location = New System.Drawing.Point(27, 35)
		Me.btnYesImport.Name = "btnYesImport"
		Me.btnYesImport.Size = New System.Drawing.Size(82, 23)
		Me.btnYesImport.TabIndex = 1
		Me.btnYesImport.Text = "Choose file :"
		Me.btnYesImport.UseVisualStyleBackColor = True
		'
		'lblYesFile
		'
		Me.lblYesFile.AutoSize = True
		Me.lblYesFile.Location = New System.Drawing.Point(116, 44)
		Me.lblYesFile.Name = "lblYesFile"
		Me.lblYesFile.Size = New System.Drawing.Size(0, 13)
		Me.lblYesFile.TabIndex = 2
		'
		'YesImportFile
		'
		Me.YesImportFile.FileName = "YesImportFile"
		Me.YesImportFile.InitialDirectory = "C:\"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(158, 195)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit App"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(26, 78)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(103, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Processing Address:"
		'
		'txtStreet
		'
		Me.txtStreet.Location = New System.Drawing.Point(134, 78)
		Me.txtStreet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtStreet.Name = "txtStreet"
		Me.txtStreet.Size = New System.Drawing.Size(396, 20)
		Me.txtStreet.TabIndex = 5
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Location = New System.Drawing.Point(134, 138)
		Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 13)
		Me.lblStatus.TabIndex = 6
		'
		'frmYESFileImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1276, 410)
		Me.Controls.Add(Me.lblStatus)
		Me.Controls.Add(Me.txtStreet)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.lblYesFile)
		Me.Controls.Add(Me.btnYesImport)
		Me.Controls.Add(Me.btnProcessImportFile)
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
	Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
