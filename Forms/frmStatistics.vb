Public Class frmStatistics
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowFreightStatistics()

    End Sub
    Private Sub ShowFreightStatistics()

        If Not FileLoaded OrElse RecordCount = 0 Then
            MessageBox.Show("Please load a valid cargo file first.")
            Me.Close()
            Return
        End If

        Dim totalWeight As Decimal = 0D
        Dim totalRevenue As Decimal = 0D
        Dim heaviestIndex As Integer = 0
        Dim lightestIndex As Integer = 0

        For i As Integer = 0 To RecordCount - 1

            totalWeight += Cargo(i).WeightKg

            totalRevenue += CalculateFreight(
                Cargo(i).WeightKg,
                Cargo(i).RatePerKg)

            If Cargo(i).WeightKg >
               Cargo(heaviestIndex).WeightKg Then
                heaviestIndex = i
            End If

            If Cargo(i).WeightKg <
               Cargo(lightestIndex).WeightKg Then
                lightestIndex = i
            End If

        Next

        lblTotalWeight.Text = totalWeight.ToString("N2") & " kg"
        lblRevenue.Text = totalRevenue.ToString("C2")
        lblAverageWeight.Text =
            (totalWeight / RecordCount).ToString("N2") & " kg"

        lblHeaviest.Text =
            Cargo(heaviestIndex).BookingID & " - " &
            Cargo(heaviestIndex).CustomerName & " (" &
            Cargo(heaviestIndex).WeightKg.ToString("N2") & " kg)"

        lblLightest.Text =
            Cargo(lightestIndex).BookingID & " - " &
            Cargo(lightestIndex).CustomerName & " (" &
            Cargo(lightestIndex).WeightKg.ToString("N2") & " kg)"

    End Sub
    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class