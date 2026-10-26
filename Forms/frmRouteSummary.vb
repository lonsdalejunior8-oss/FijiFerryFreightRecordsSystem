Public Class frmRouteSummary

    '=========================================
    ' Form Load Event
    ' Loads available routes into the
    ' Route ComboBox when the form opens.
    '=========================================
    Private Sub frmRouteSummary_Load(sender As Object,
                                     e As EventArgs) Handles MyBase.Load

        ' Ensure a cargo file has been loaded
        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Me.Close()
            Return
        End If

        ' Clear existing route entries
        cboRoute.Items.Clear()

        ' Add unique routes to ComboBox
        For i As Integer = 0 To RecordCount - 1

            If Not cboRoute.Items.Contains(Cargo(i).Route) Then
                cboRoute.Items.Add(Cargo(i).Route)
            End If

        Next

        ' Select first route by default
        If cboRoute.Items.Count > 0 Then
            cboRoute.SelectedIndex = 0
        End If

    End Sub

    '=========================================
    ' Generate Route Summary
    ' Generates a summary report based on
    ' the selected route and date.
    '=========================================
    Private Sub btnGenerateSummary_Click(sender As Object, e As EventArgs) Handles btnGenerateSummary.Click

        ' Ensure cargo data is loaded
        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        ' Ensure a route is selected
        If cboRoute.SelectedIndex = -1 Then
            MessageBox.Show("Please select a route.")
            Return
        End If

        ' Store selected route and date
        Dim selectedRoute = cboRoute.Text
        Dim selectedDate = dtpSummaryDate.Value.Date

        ' Initialize summary variables
        Dim bookingCount = 0
        Dim totalWeight = 0D
        Dim totalRevenue = 0D

        ' Clear previous summary results
        lstSummary.Items.Clear()

        ' Search matching bookings
        For i = 0 To RecordCount - 1

            Dim BookingDate As Date

            If Cargo(i).Route = selectedRoute AndAlso
   Date.TryParse(Cargo(i).BookingDate, BookingDate) AndAlso
   BookingDate.Date = selectedDate Then

                ' Increment booking count
                bookingCount += 1

                ' Add weight to total
                totalWeight += CDec(Cargo(i).WeightKg)

                ' Calculate freight charge
                Dim freight =
                    CalculateFreight(
                        Cargo(i).WeightKg,
                        Cargo(i).RatePerKg)

                ' Add freight to total revenue
                totalRevenue += freight

                ' Display booking details
                lstSummary.Items.Add(
                    Cargo(i).BookingID & " - " &
                    Cargo(i).CustomerName & " - " &
                    Cargo(i).CargoType & " - " &
                    CDec(Cargo(i).WeightKg).ToString("0.00") & " kg")

            End If

        Next

        ' Display summary statistics
        lblBookingCount.Text = bookingCount.ToString
        lblTotalWeight.Text = totalWeight.ToString("0.00") & " kg"
        lblTotalRevenue.Text = totalRevenue.ToString("C2")

        ' Inform user if no records found
        If bookingCount = 0 Then
            MessageBox.Show("No bookings found for the selected route and date.")
        End If

    End Sub

    '=========================================
    ' Close Button
    ' Closes the Route Summary form.
    '=========================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '=========================================
    ' Clear Button
    ' Resets all summary information and
    ' restores default control values.
    '=========================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear the booking list
        lstSummary.Items.Clear()

        ' Reset summary values
        lblBookingCount.Text = "0"
        lblTotalWeight.Text = "0.00 kg"
        lblTotalRevenue.Text = "$0.00"

        ' Reset route selection
        cboRoute.SelectedIndex = -1

        ' Reset booking date to today's date
        dtpSummaryDate.Value = Date.Today

    End Sub

    '=========================================
    ' Display All Bookings
    ' Shows all booking records and
    ' calculates overall totals.
    '=========================================
    Private Sub btnAllBookings_Click(sender As Object, e As EventArgs) Handles btnAllBookings.Click

        ' Ensure cargo data is loaded
        If FileLoaded = False Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        ' Initialize summary variables
        Dim bookingCount As Integer = 0
        Dim totalWeight As Decimal = 0D
        Dim totalRevenue As Decimal = 0D

        ' Clear previous results
        lstSummary.Items.Clear()

        ' Process all booking records
        For i As Integer = 0 To RecordCount - 1

            bookingCount += 1

            totalWeight += CDec(Cargo(i).WeightKg)

            ' Calculate freight charge
            Dim freight As Decimal =
                CalculateFreight(
                    CDec(Cargo(i).WeightKg),
                    CDec(Cargo(i).RatePerKg))

            totalRevenue += freight

            ' Display full booking details
            lstSummary.Items.Add(
                Cargo(i).BookingID &
                " | " & Cargo(i).CustomerName &
                " | " & Cargo(i).Route &
                " | " & Cargo(i).BookingDate &
                " | " & Cargo(i).CargoType &
                " | " & CDec(Cargo(i).WeightKg).ToString("0.00") & " kg" &
                " | " & CDec(Cargo(i).RatePerKg).ToString("C2") &
                " | " & Cargo(i).Status)

        Next

        ' Display calculated totals
        lblBookingCount.Text = bookingCount.ToString()
        lblTotalWeight.Text = totalWeight.ToString("0.00") & " kg"
        lblTotalRevenue.Text = totalRevenue.ToString("C2")

        ' Inform user if no bookings exist
        If bookingCount = 0 Then
            MessageBox.Show("There are no bookings to display.")
        End If

    End Sub

    Private Sub lstSummary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSummary.SelectedIndexChanged

    End Sub
End Class