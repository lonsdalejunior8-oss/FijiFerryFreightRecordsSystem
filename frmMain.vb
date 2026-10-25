Public Class frmMain

    '=========================================
    ' Function: Calculate Freight Charge
    ' Calculates freight charge based on
    ' cargo weight and rate per kilogram.
    '=========================================
    Private Function CalculateFreight(weight As Double,
                                      rate As Double) As Double

        Return weight * rate

    End Function

    '=========================================
    ' Display Selected Booking
    ' Displays the details of the selected
    ' booking in the text boxes.
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
    ' Reads cargo booking records from the
    ' selected text file into the array.
    '=========================================
    Private Sub LoadCargoFile()

        Try

            ' Display file open dialog
            If OpenFileDialog1.ShowDialog() =
                DialogResult.OK Then

                Dim lines() As String

                ' Read all lines from file
                lines = IO.File.ReadAllLines(
                    OpenFileDialog1.FileName)

                ' Retrieve number of records
                RecordCount = CInt(lines(0))

                ' Clear existing ListBox items
                lstBookings.Items.Clear()

                ' Process each cargo record
                For i As Integer = 1 To RecordCount

                    Dim fields() As String

                    ' Split record into fields
                    fields = lines(i).Split(","c)

                    ' Validate field count
                    If fields.Length <> 8 Then

                        MessageBox.Show(
                            "Invalid file format.")

                        Exit Sub

                    End If

                    ' Store record data into array
                    Cargo(i - 1).BookingID = fields(0)
                    Cargo(i - 1).CustomerName = fields(1)
                    Cargo(i - 1).Route = fields(2)
                    Cargo(i - 1).BookingDate = CDate(fields(3))
                    Cargo(i - 1).CargoType = fields(4)
                    Cargo(i - 1).WeightKg = CDbl(fields(5))
                    Cargo(i - 1).RatePerKg = CDbl(fields(6))
                    Cargo(i - 1).Status = fields(7)

                    ' Add booking ID to ListBox
                    lstBookings.Items.Add(
                        Cargo(i - 1).BookingID)

                Next

                ' Mark data as loaded
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

    ' Opens and loads a cargo booking file
    Private Sub mnuOpen_Click(sender As Object,
                          e As EventArgs) _
                          Handles mnuOpen.Click

        LoadCargoFile()

    End Sub

    ' File menu click event
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    ' Displays booking details when a booking
    ' is selected from the ListBox
    Private Sub lstBookings_SelectedIndexChanged(
    sender As Object,
    e As EventArgs) _
    Handles lstBookings.SelectedIndexChanged

        If lstBookings.SelectedIndex >= 0 Then

            DisplayBooking(
            lstBookings.SelectedIndex)

        End If

    End Sub

    ' Form load event
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '=========================================
    ' Clear Display
    ' Clears all booking information fields.
    '=========================================
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

    ' Clears all displayed data
    Private Sub btnClear_Click(sender As Object,
                       e As EventArgs) _
                       Handles btnClear.Click

        ClearDisplay()

    End Sub

    '=========================================
    ' Update Booking Status
    ' Updates the status of the selected
    ' booking record.
    '=========================================
    Private Sub btnUpdateStatus_Click(sender As Object,
                                  e As EventArgs) _
                                  Handles btnUpdateStatus.Click

        ' Check if a booking is selected
        If lstBookings.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a booking first.")

            Exit Sub

        End If

        ' Check if a status is selected
        If cboStatus.SelectedIndex = -1 Then

            MessageBox.Show(
            "Please select a status.")

            Exit Sub

        End If

        ' Update booking status
        Cargo(lstBookings.SelectedIndex).Status =
        cboStatus.Text

        txtStatus.Text = cboStatus.Text

        ' Mark data as changed
        DataChanged = True

        MessageBox.Show(
        "Booking status updated successfully.")

    End Sub

    '=========================================
    ' Save Cargo File
    ' Saves all cargo booking records to
    ' the text file.
    '=========================================
    Private Sub SaveCargoFile()

        Try

            Dim saveFile As String = "CargoBookings.txt"

            Using sw As New IO.StreamWriter(saveFile)

                ' Write record count
                sw.WriteLine(RecordCount)

                ' Write all records to file
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

    ' Saves changes to the cargo file
    Private Sub mnuSave_Click(sender As Object,
                          e As EventArgs) _
                          Handles mnuSave.Click

        SaveCargoFile()

    End Sub

    ' Opens the Statistics form
    Private Sub mnuStatistics_Click(sender As Object, e As EventArgs) Handles mnuStatistics.Click

        If Not FileLoaded OrElse RecordCount = 0 Then
            MessageBox.Show("Please load a cargo file first.")
            Return
        End If

        Using stats As New frmStatistics()
            stats.ShowDialog(Me)
        End Using
    End Sub

    ' View menu click event
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    ' Opens the Route Summary form
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

    ' Label click event
    Private Sub lblCargoBookings_Click(sender As Object, e As EventArgs) Handles lblCargoBookings.Click

    End Sub

    ' Label click event
    Private Sub lblNewStatus_Click(sender As Object, e As EventArgs) Handles lblNewStatus.Click

    End Sub

    ' MenuStrip item clicked event
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    '=========================================
    ' Exit Application
    ' Prompts user for confirmation before
    ' closing the system.
    '=========================================
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

    ' Label click event
    Private Sub lblRate_Click(sender As Object, e As EventArgs) Handles lblRate.Click

    End Sub

    ' Label click event
    Private Sub lblWeight_Click(sender As Object, e As EventArgs) Handles lblWeight.Click

    End Sub

    ' Opens the Search form
    Private Sub mnuSearch_Click(sender As Object,
                            e As EventArgs) Handles mnuSearch.Click

        Dim frm As New frmSearch
        frm.ShowDialog()

    End Sub

    ' Opens the Collected Report form
    Private Sub mnuCollectedReport_Click(sender As Object, e As EventArgs) Handles mnuCollectedReport.Click

        Dim frm As New frmCollectedReport
        frm.ShowDialog()

    End Sub

End Class