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
        End If

    End Sub

    Private Sub SearchByBookingID()

        MessageBox.Show("Booking ID Search Works!")

    End Sub
End Class