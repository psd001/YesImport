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
		Select New With {.StreetNum = parts(0), .StreetName = parts(1), .Suffix = parts(2), .City = parts(3), .State = parts(4), .Street = parts(5), .CustCode_CYES = parts(6), .OptIn_flag = parts(7), .Missed_OPTIN = parts(8)}

		Cursor = Cursors.Default

		Me.Refresh()

		For Each yes In YesList
			txtStreet.Text = yes.Street
			txtStreet.Refresh()

			Dim yesord As New YES29063 With _
				{.StreetNum = yes.StreetNum, _
				 .StreetName = yes.StreetName, _
				 .Suffix = yes.Suffix, _
				 .City = yes.City, _
				 .State = yes.State, _
				 .Street = yes.Street, _
				 .CustCode_CYES = yes.CustCode_CYES, _
				 .OptIn_flag = yes.OptIn_flag, _
				 .Missed_OPTIN = yes.Missed_OPTIN
				}
			Dim db As New YesDataContext

			db.YES29063s.InsertOnSubmit(yesord)

			Try
				db.SubmitChanges()

			Catch ex As Exception
				' Need to handle duplicate keys


				Throw ex
			End Try
		Next

		btnProcessImportFile.Enabled = True

	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Application.Exit()
	End Sub
End Class
