Public Class frmStatistics

    '=========================================
    ' Form Load Event
    ' Automatically displays freight
    ' statistics when the form opens.
    '=========================================
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowFreightStatistics()

    End Sub

    '=========================================
    ' Show Freight Statistics
    ' Calculates and displays overall cargo
    ' statistics from the loaded file.
    '=========================================
    Private Sub ShowFreightStatistics()

        ' Ensure a valid cargo file is loaded
        If Not FileLoaded OrElse RecordCount = 0 Then
            MessageBox.Show("Please load a valid cargo file first.")
            Me.Close()
            Return
        End If

        ' Variables used to calculate statistics
        Dim totalWeight As Decimal = 0D
        Dim totalRevenue As Decimal = 0D
        Dim heaviestIndex As Integer = 0
        Dim lightestIndex As Integer = 0

        ' Process all cargo records
        For i As Integer = 0 To RecordCount - 1

            ' Add cargo weight to total weight
            totalWeight += Cargo(i).WeightKg

            ' Add freight charge to total revenue
            totalRevenue += CalculateFreight(
                Cargo(i).WeightKg,
                Cargo(i).RatePerKg)

            ' Check for heaviest cargo record
            If Cargo(i).WeightKg >
               Cargo(heaviestIndex).WeightKg Then
                heaviestIndex = i
            End If

            ' Check for lightest cargo record
            If Cargo(i).WeightKg <
               Cargo(lightestIndex).WeightKg Then
                lightestIndex = i
            End If

        Next

        ' Display total cargo weight
        lblTotalWeight.Text = totalWeight.ToString("N2") & " kg"

        ' Display total freight revenue
        lblRevenue.Text = totalRevenue.ToString("C2")

        ' Display average cargo weight
        lblAverageWeight.Text =
            (totalWeight / RecordCount).ToString("N2") & " kg"

        ' Display heaviest cargo record
        lblHeaviest.Text =
            Cargo(heaviestIndex).BookingID & " - " &
            Cargo(heaviestIndex).CustomerName & " (" &
            Cargo(heaviestIndex).WeightKg.ToString("N2") & " kg)"

        ' Display lightest cargo record
        lblLightest.Text =
            Cargo(lightestIndex).BookingID & " - " &
            Cargo(lightestIndex).CustomerName & " (" &
            Cargo(lightestIndex).WeightKg.ToString("N2") & " kg)"

    End Sub

    '=========================================
    ' Close Button
    ' Closes the Statistics form.
    '=========================================
    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class