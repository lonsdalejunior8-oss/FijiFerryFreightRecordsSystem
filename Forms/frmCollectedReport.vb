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
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub
End Class