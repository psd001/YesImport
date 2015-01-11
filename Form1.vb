Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class frmYESFileImport

	Private Sub btnYesImport_Click(sender As Object, e As EventArgs) Handles btnYesImport.Click

		YesImportFile.Title = "Please Select a CSV File"

		YesImportFile.InitialDirectory = "C:\"

		YesImportFile.ShowDialog()

	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles YesImportFile.FileOk


		Dim strm As System.IO.Stream


		strm = YesImportFile.OpenFile()


		lblYesFile.Text = YesImportFile.FileName.ToString()


	End Sub

	Private Sub btnProcessImportFile_Click(sender As Object, e As EventArgs) Handles btnProcessImportFile.Click

		btnProcessImportFile.Enabled = False

		Cursor = Cursors.WaitCursor

		Me.Refresh()

		Dim allLines() As String = File.ReadAllLines(lblYesFile.Text)

		Dim YesList = From line In allLines _
		Let parts = line.Split(",") _
		Where parts(7).Trim() = "OPTIN" _
		Select New With {.StreetNum = parts(0), .StreetName = parts(1), .Suffix = parts(2), .City = parts(3), .State = parts(4), .Street = parts(5), .CustCode_CYES = parts(6), .OptIn_flag = parts(7), .Missed_OPTIN = parts(8)}

		Cursor = Cursors.Default

		Me.Refresh()

		For Each yes In YesList
			txtStreet.Text = yes.Street
			txtStreet.Refresh()
		Next

		btnProcessImportFile.Enabled = True

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Application.Exit()
	End Sub
End Class
