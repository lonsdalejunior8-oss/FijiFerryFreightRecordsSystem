Imports System.IO

Public Class frmCollectedReport

    '=========================================
    ' Form Load Event
    ' Loads all cargo records with a status
    ' of "Collected" into the ListBox.
    '=========================================
    Private Sub frmCollectedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Clear any existing items
        lstCollectedCargo.Items.Clear()

        ' Loop through all cargo records
        For i As Integer = 0 To RecordCount - 1

            ' Check for collected cargo
            If Cargo(i).Status = "Collected" Then

                ' Add booking details to ListBox
                lstCollectedCargo.Items.Add(
                    Cargo(i).BookingID & " - " &
                    Cargo(i).CustomerName)

            End If

        Next

        ' Display message if no collected records exist
        If lstCollectedCargo.Items.Count = 0 Then

            MessageBox.Show(
                "No collected cargo records found.",
                "Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

        End If

    End Sub

    '=========================================
    ' Close Button
    ' Closes the Collected Report form.
    '=========================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    '=========================================
    ' Export Report
    ' Exports all collected cargo records
    ' to a text file in My Documents.
    '=========================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Try

            ' Define export file location
            Dim FilePath As String =
                IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "collectedCargoReport.txt")

            ' Create text file for writing
            Dim sw As New StreamWriter(FilePath)

            ' Write report title
            sw.WriteLine("Collected Cargo Report")
            sw.WriteLine("======================")
            sw.WriteLine()

            ' Loop through all cargo records
            For i As Integer = 0 To RecordCount - 1

                ' Export only collected cargo
                If Cargo(i).Status = "Collected" Then

                    sw.WriteLine(
                        Cargo(i).BookingID & " - " &
                        Cargo(i).CustomerName)

                End If

            Next

            ' Close file after writing
            sw.Close()

            ' Display successful export message
            MessageBox.Show(
                "Report exported successfully to:" &
                Environment.NewLine &
                FilePath,
                "Export",
                MessageBoxButtons.OK)

        Catch ex As Exception

            ' Display error message if export fails
            MessageBox.Show(
                "Error exporting report: " &
                ex.Message)

        End Try

    End Sub

End Class