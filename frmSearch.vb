Public Class frmSearch


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearch.Text.Trim = "" Then

            MessageBox.Show(
            "Please enter a search value.")

            Exit Sub

        End If

        lstResults.Items.Clear()


        If radBookingID.Checked Then

            SearchByBookingID()

        ElseIf radCustomerName.Checked Then

            SearchByCustomerName()

        End If


    End Sub

    Private Sub SearchByCustomerName()

        Dim Found As Boolean = False

        lstResults.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            If Cargo(i).CustomerName.ToLower().Contains(
            txtSearch.Text.Trim.ToLower()) Then

                lstResults.Items.Add(
                Cargo(i).BookingID & " - " &
                Cargo(i).CustomerName)

                Found = True

            End If

        Next

        If Not Found Then

            MessageBox.Show(
            "No matching customers found.")

        End If

    End Sub

    Private Sub SearchByBookingID()

        Dim Found As Boolean = False

        lstResults.Items.Clear()

        For i As Integer = 0 To RecordCount - 1

            If Cargo(i).BookingID.ToUpper() =
           txtSearch.Text.Trim.ToUpper() Then

                lstResults.Items.Add(
                Cargo(i).BookingID & " - " &
                Cargo(i).CustomerName)

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

        If Not Found Then

            MessageBox.Show("Booking ID not found.")

        End If

    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

        If lstResults.SelectedIndex = -1 Then Exit Sub

        Dim SelectedBookingID As String =
            lstResults.SelectedItem.ToString().Split("-"c)(0).Trim()

        For i As Integer = 0 To RecordCount - 1

            If Cargo(i).BookingID = SelectedBookingID Then

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


End Class