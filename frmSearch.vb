Public Class frmSearch

    '=========================================
    ' Search Button
    ' Validates search input and performs
    ' search based on selected criteria.
    '=========================================
    Private Sub btnSearch_Click(sender As Object,
                            e As EventArgs) Handles btnSearch.Click

        ' Check if search textbox is empty
        If txtSearch.Text.Trim = "" Then

            MessageBox.Show(
            "Please enter a search value.",
            "Search",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        ' Check if a search option is selected
        If Not radBookingID.Checked AndAlso
       Not radCustomerName.Checked Then

            MessageBox.Show(
            "Please select Booking ID or Customer Name.",
            "Search",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub

        End If

        ' Clear previous search results
        lstResults.Items.Clear()

        ' Search according to selected option
        If radBookingID.Checked Then

            SearchByBookingID()

        ElseIf radCustomerName.Checked Then

            SearchByCustomerName()

        End If

    End Sub

    '=========================================
    ' Search By Customer Name
    ' Searches for records containing the
    ' entered customer name.
    '=========================================
    Private Sub SearchByCustomerName()

        Dim Found As Boolean = False

        ' Clear previous search results
        lstResults.Items.Clear()

        ' Loop through all records
        For i As Integer = 0 To RecordCount - 1

            ' Check if customer name contains search text
            If Cargo(i).CustomerName.ToLower().Contains(
            txtSearch.Text.Trim.ToLower()) Then

                ' Display matching record
                lstResults.Items.Add(
                Cargo(i).BookingID & " - " &
                Cargo(i).CustomerName)

                Found = True

            End If

        Next

        ' Display message if no records found
        If Not Found Then

            MessageBox.Show(
            "Customer Name not Found !")

        End If

    End Sub

    '=========================================
    ' Search By Booking ID
    ' Searches for a booking using the
    ' entered Booking ID.
    '=========================================
    Private Sub SearchByBookingID()

        Dim Found As Boolean = False

        ' Clear previous search results
        lstResults.Items.Clear()

        ' Loop through all records
        For i As Integer = 0 To RecordCount - 1

            ' Check for matching Booking ID
            If Cargo(i).BookingID.ToUpper() =
           txtSearch.Text.Trim.ToUpper() Then

                ' Add result to ListBox
                lstResults.Items.Add(
                Cargo(i).BookingID & " - " &
                Cargo(i).CustomerName)

                ' Display booking details
                txtBookingID.Text = Cargo(i).BookingID
                txtCustomerName.Text = Cargo(i).CustomerName
                txtRoute.Text = Cargo(i).Route
                txtDate.Text = Cargo(i).BookingDate.ToShortDateString()
                txtCargoType.Text = Cargo(i).CargoType
                txtWeight.Text = Cargo(i).WeightKg.ToString()
                txtStatus.Text = Cargo(i).Status

                Found = True
                Exit For

            End If

        Next

        ' Display message if booking not found
        If Not Found Then

            MessageBox.Show("Booking ID not Found!.")

        End If

    End Sub

    '=========================================
    ' Result Selection Changed
    ' Displays selected booking details
    ' from the search results.
    '=========================================
    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

        ' Exit if nothing is selected
        If lstResults.SelectedIndex = -1 Then Exit Sub

        ' Get selected Booking ID
        Dim SelectedBookingID As String =
            lstResults.SelectedItem.ToString().Split("-"c)(0).Trim()

        ' Find corresponding record
        For i As Integer = 0 To RecordCount - 1

            If Cargo(i).BookingID = SelectedBookingID Then

                ' Display booking information
                txtBookingID.Text = Cargo(i).BookingID
                txtCustomerName.Text = Cargo(i).CustomerName
                txtRoute.Text = Cargo(i).Route
                txtDate.Text = Cargo(i).BookingDate.ToShortDateString()
                txtCargoType.Text = Cargo(i).CargoType
                txtWeight.Text = Cargo(i).WeightKg.ToString()
                txtStatus.Text = Cargo(i).Status

                Exit For

            End If

        Next

    End Sub

    '=========================================
    ' Clear Button
    ' Clears search fields, search results,
    ' and displayed booking information.
    '=========================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear search textbox
        txtSearch.Clear()

        ' Clear search results
        lstResults.Items.Clear()

        ' Clear displayed booking details
        txtBookingID.Clear()
        txtCustomerName.Clear()
        txtRoute.Clear()
        txtDate.Clear()
        txtCargoType.Clear()
        txtWeight.Clear()
        txtStatus.Clear()

        ' Reset radio buttons
        radBookingID.Checked = False
        radCustomerName.Checked = False

        ' Return focus to search box
        txtSearch.Focus()

    End Sub

    '=========================================
    ' Close Button
    ' Closes the Search form.
    '=========================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    '=========================================
    ' Form Load Event
    ' Executes when the Search form opens.
    '=========================================
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class