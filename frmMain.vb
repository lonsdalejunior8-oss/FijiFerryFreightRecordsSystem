Public Class frmMain

    '=========================================
    ' Function: Calculate Freight Charge

    Private Function CalculateFreight(weight As Double,
                                      rate As Double) As Double

        Return weight * rate

    End Function

    '=========================================
    ' Display Selected Booking
    '=========================================
    Private Sub DisplayBooking(index As Integer)

        txtBookingID.Text = Cargo(index).BookingID
        txtCustomerName.Text = Cargo(index).CustomerName
        txtRoute.Text = Cargo(index).Route
        txtDate.Text = Cargo(index).BookingDate.ToShortDateString()
        txtCargoType.Text = Cargo(index).CargoType
        txtWeight.Text = Cargo(index).WeightKg.ToString("N2")
        txtRate.Text = Cargo(index).RatePerKg.ToString("C2")
        txtStatus.Text = Cargo(index).Status

        txtFreightCharge.Text =
            CalculateFreight(
                Cargo(index).WeightKg,
                Cargo(index).RatePerKg).ToString("C2")

    End Sub

    '=========================================
    ' Load Cargo File
    '=========================================
    Private Sub LoadCargoFile()

        Try

            If OpenFileDialog1.ShowDialog() =
                DialogResult.OK Then

                Dim lines() As String

                lines = IO.File.ReadAllLines(
                    OpenFileDialog1.FileName)

                RecordCount = CInt(lines(0))

                lstBookings.Items.Clear()

                For i As Integer = 1 To RecordCount

                    Dim fields() As String

                    fields = lines(i).Split(","c)

                    If fields.Length <> 8 Then

                        MessageBox.Show(
                            "Invalid file format.")

                        Exit Sub

                    End If

                    Cargo(i - 1).BookingID = fields(0)
                    Cargo(i - 1).CustomerName = fields(1)
                    Cargo(i - 1).Route = fields(2)
                    Cargo(i - 1).BookingDate = CDate(fields(3))
                    Cargo(i - 1).CargoType = fields(4)
                    Cargo(i - 1).WeightKg = CDbl(fields(5))
                    Cargo(i - 1).RatePerKg = CDbl(fields(6))
                    Cargo(i - 1).Status = fields(7)

                    lstBookings.Items.Add(
                        Cargo(i - 1).BookingID)

                Next

                FileLoaded = True

                MessageBox.Show(
                    "Cargo file loaded successfully.")

            End If

        Catch ex As Exception

            MessageBox.Show(
                "Error loading file: " &
                ex.Message)

        End Try

    End Sub

    Private Sub mnuOpen_Click(sender As Object,
                          e As EventArgs) _
                          Handles mnuOpen.Click

        LoadCargoFile()

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub lstBookings_SelectedIndexChanged(
    sender As Object,
    e As EventArgs) _
    Handles lstBookings.SelectedIndexChanged

        If lstBookings.SelectedIndex >= 0 Then

            DisplayBooking(
            lstBookings.SelectedIndex)

        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearDisplay()

        txtBookingID.Clear()
        txtCustomerName.Clear()
        txtRoute.Clear()
        txtDate.Clear()
        txtCargoType.Clear()
        txtWeight.Clear()
        txtRate.Clear()
        txtStatus.Clear()
        txtFreightCharge.Clear()

        cboStatus.SelectedIndex = -1

    End Sub

    Private Sub btnClear_Click(sender As Object,
                           e As EventArgs) _
                           Handles btnClear.Click, btnClear.Click

        ClearDisplay()

    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object,
                                  e As EventArgs) _
                                  Handles btnUpdateStatus.Click

        If lstBookings.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a booking first.")

            Exit Sub

        End If

        If cboStatus.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a status.")

            Exit Sub

        End If

        Cargo(lstBookings.SelectedIndex).Status =
        cboStatus.Text

        txtStatus.Text = cboStatus.Text

        DataChanged = True

        MessageBox.Show(
        "Booking status updated successfully.")

    End Sub

    Private Sub SaveCargoFile()

        Try

            Dim saveFile As String = "CargoBookings.txt"

            Using sw As New IO.StreamWriter(saveFile)

                sw.WriteLine(RecordCount)

                For i As Integer = 0 To RecordCount - 1

                    sw.WriteLine(
                        Cargo(i).BookingID & "," &
                        Cargo(i).CustomerName & "," &
                        Cargo(i).Route & "," &
                        Cargo(i).BookingDate.ToString("yyyy-MM-dd") & "," &
                        Cargo(i).CargoType & "," &
                        Cargo(i).WeightKg & "," &
                        Cargo(i).RatePerKg & "," &
                        Cargo(i).Status)

                Next

            End Using

            DataChanged = False

            MessageBox.Show(
                "Cargo file saved successfully.")

        Catch ex As Exception

            MessageBox.Show(
                "Error saving file: " &
                ex.Message)

        End Try

    End Sub

    Private Sub mnuSave_Click(sender As Object,
                          e As EventArgs) _
                          Handles mnuSave.Click

        SaveCargoFile()

    End Sub

    Private Sub mnuStatistics_Click(sender As Object, e As EventArgs) Handles mnuStatistics.Click


        If Not FileLoaded OrElse RecordCount = 0 Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        Using stats As New frmStatistics()
            stats.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub mnuRouteSummary_Click(sender As Object, e As EventArgs) Handles mnuRouteSummary.Click

        If RecordCount = 0 Then

            MessageBox.Show(
            "Please load a valid cargo bookings file first.")

            Return

        End If

        Using frm As New frmRouteSummary()

            frm.ShowDialog(Me)

        End Using

    End Sub

    Private Sub lblCargoBookings_Click(sender As Object, e As EventArgs) Handles lblCargoBookings.Click

    End Sub

    Private Sub lblNewStatus_Click(sender As Object, e As EventArgs) Handles lblNewStatus.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim result As DialogResult

        result = MessageBox.Show(
            "Are you sure you want to exit FijiFerry Freight Records System?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub lblRate_Click(sender As Object, e As EventArgs) Handles lblRate.Click

    End Sub

    Private Sub lblWeight_Click(sender As Object, e As EventArgs) Handles lblWeight.Click

    End Sub
End Class
