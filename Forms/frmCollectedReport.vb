Imports System.IO
Public Class frmCollectedReport

    Private Sub frmCollectedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCollectedCargo.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            If Cargo(i).Status = "Collected" Then

                lstCollectedCargo.Items.Add(
                    Cargo(i).BookingID & " - " &
                    Cargo(i).CustomerName)

            End If

        Next

        If lstCollectedCargo.Items.Count = 0 Then

            MessageBox.Show(
                "No collected cargo records found.",
                "Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try

            Dim FilePath As String =
                IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "collectedCargoReport.txt")

            Dim sw As New StreamWriter(FilePath)

            sw.WriteLine("Collected Cargo Report")
            sw.WriteLine("======================")
            sw.WriteLine()

            For i As Integer = 0 To RecordCount - 1

                If Cargo(i).Status = "Collected" Then

                    sw.WriteLine(
                        Cargo(i).BookingID & " - " &
                        Cargo(i).CustomerName)

                End If

            Next

            sw.Close()

            MessageBox.Show(
                "Report exported successfully to:" &
                Environment.NewLine &
                FilePath,
                "Export",
                MessageBoxButtons.OK)


        Catch ex As Exception

            MessageBox.Show(
                "Error exporting report: " &
                ex.Message)

        End Try


    End Sub

End Class