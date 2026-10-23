Public Class frmRouteSummary
    Private Sub frmRouteSummary_Load(sender As Object,
                                     e As EventArgs) Handles MyBase.Load

        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Me.Close()
            Return
        End If

        cboRoute.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            If Not cboRoute.Items.Contains(Cargo(i).Route) Then
                cboRoute.Items.Add(Cargo(i).Route)
            End If

        Next

        If cboRoute.Items.Count > 0 Then
            cboRoute.SelectedIndex = 0
        End If

    End Sub

    Private Sub btnGenerateSummary_Click(sender As Object, e As EventArgs) Handles btnGenerateSummary.Click
        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        If cboRoute.SelectedIndex = -1 Then
            MessageBox.Show("Please select a route.")
            Return
        End If

        Dim selectedRoute As String = cboRoute.Text
        Dim selectedDate As Date = dtpSummaryDate.Value.Date

        Dim bookingCount As Integer = 0
        Dim totalWeight As Decimal = 0D
        Dim totalRevenue As Decimal = 0D

        lstSummary.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            Dim BookingDate As Date

            If Cargo(i).Route = selectedRoute AndAlso
   Date.TryParse(Cargo(i).BookingDate, BookingDate) AndAlso
   BookingDate.Date = selectedDate Then

                bookingCount += 1

                totalWeight += CDec(Cargo(i).WeightKg)

                Dim freight As Decimal =
                    CalculateFreight(
                        CDec(Cargo(i).WeightKg),
                        CDec(Cargo(i).RatePerKg))

                totalRevenue += freight

                lstSummary.Items.Add(
                    Cargo(i).BookingID & " - " &
                    Cargo(i).CustomerName & " - " &
                    Cargo(i).CargoType & " - " &
                    CDec(Cargo(i).WeightKg).ToString("0.00") & " kg")

            End If

        Next

        lblBookingCount.Text = bookingCount.ToString()
        lblTotalWeight.Text = totalWeight.ToString("0.00") & " kg"
        lblTotalRevenue.Text = totalRevenue.ToString("C2")

        If bookingCount = 0 Then
            MessageBox.Show("No bookings found for the selected route and date.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the booking list
        lstSummary.Items.Clear()

        'Reset summary values
        lblBookingCount.Text = "0"
        lblTotalWeight.Text = "0.00 kg"
        lblTotalRevenue.Text = "$0.00"

        'Reset route selection
        cboRoute.SelectedIndex = -1

        'Reset booking date to today's date
        dtpSummaryDate.Value = Date.Today
    End Sub

    Private Sub btnAllBookings_Click(sender As Object, e As EventArgs) Handles btnAllBookings.Click
        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        Dim bookingCount As Integer = 0
        Dim totalWeight As Decimal = 0D
        Dim totalRevenue As Decimal = 0D

        lstSummary.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            bookingCount += 1

            totalWeight += CDec(Cargo(i).WeightKg)

            Dim freight As Decimal =
                CalculateFreight(
                    CDec(Cargo(i).WeightKg),
                    CDec(Cargo(i).RatePerKg))

            totalRevenue += freight

            lstSummary.Items.Add(
                "ID: " & Cargo(i).BookingID &
                " | Customer: " & Cargo(i).CustomerName &
                " | Route: " & Cargo(i).Route &
                " | Date: " & Cargo(i).BookingDate &
                " | Cargo: " & Cargo(i).CargoType &
                " | Weight: " & CDec(Cargo(i).WeightKg).ToString("0.00") & " kg" &
                " | Rate: " & CDec(Cargo(i).RatePerKg).ToString("C2") &
                " | Status: " & Cargo(i).Status)

        Next

        lblBookingCount.Text = bookingCount.ToString()
        lblTotalWeight.Text = totalWeight.ToString("0.00") & " kg"
        lblTotalRevenue.Text = totalRevenue.ToString("C2")

        If bookingCount = 0 Then
            MessageBox.Show("There are no bookings to display.")
        End If
    End Sub
End Class