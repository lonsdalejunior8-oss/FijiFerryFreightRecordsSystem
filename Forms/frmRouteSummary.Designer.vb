<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouteSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnGenerateSummary = New Button()
        lblHeading = New Label()
        lblBookings = New Label()
        lblTotal = New Label()
        btnClose = New Button()
        lblBookingCount = New Label()
        lblTotalWeight = New Label()
        lblSummary = New Label()
        cboRoute = New ComboBox()
        lblSelect = New Label()
        lblDate = New Label()
        dtpSummaryDate = New DateTimePicker()
        lstSummary = New ListBox()
        lblTitleRevenue = New Label()
        lblTotalRevenue = New Label()
        btnClear = New Button()
        btnAllBookings = New Button()
        SuspendLayout()
        ' 
        ' btnGenerateSummary
        ' 
        btnGenerateSummary.BackColor = Color.DarkGray
        btnGenerateSummary.Location = New Point(572, 347)
        btnGenerateSummary.Name = "btnGenerateSummary"
        btnGenerateSummary.Size = New Size(250, 45)
        btnGenerateSummary.TabIndex = 4
        btnGenerateSummary.Text = "Generate Summary"
        btnGenerateSummary.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(279, 25)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(274, 21)
        lblHeading.TabIndex = 6
        lblHeading.Text = "FIJIFERRY-ROUTE SUMMARY"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBookings
        ' 
        lblBookings.AutoSize = True
        lblBookings.Location = New Point(572, 256)
        lblBookings.Name = "lblBookings"
        lblBookings.Size = New Size(112, 17)
        lblBookings.TabIndex = 7
        lblBookings.Text = "Total Bookings:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(572, 201)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(98, 17)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Total Weight:"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Tan
        btnClose.Location = New Point(768, 440)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(54, 25)
        btnClose.TabIndex = 10
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblBookingCount
        ' 
        lblBookingCount.BackColor = SystemColors.ActiveCaption
        lblBookingCount.Location = New Point(687, 248)
        lblBookingCount.Name = "lblBookingCount"
        lblBookingCount.Size = New Size(123, 32)
        lblBookingCount.TabIndex = 11
        lblBookingCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalWeight
        ' 
        lblTotalWeight.BackColor = SystemColors.ActiveCaption
        lblTotalWeight.Location = New Point(687, 193)
        lblTotalWeight.Name = "lblTotalWeight"
        lblTotalWeight.Size = New Size(123, 32)
        lblTotalWeight.TabIndex = 12
        lblTotalWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSummary
        ' 
        lblSummary.BackColor = Color.DimGray
        lblSummary.ForeColor = SystemColors.Control
        lblSummary.Location = New Point(12, 151)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(865, 24)
        lblSummary.TabIndex = 13
        lblSummary.Text = "Route Summary Details"
        lblSummary.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRoute
        ' 
        cboRoute.FormattingEnabled = True
        cboRoute.Location = New Point(223, 91)
        cboRoute.Name = "cboRoute"
        cboRoute.Size = New Size(137, 25)
        cboRoute.TabIndex = 14
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Location = New Point(121, 94)
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(96, 17)
        lblSelect.TabIndex = 15
        lblSelect.Text = "Select Route:"
        lblSelect.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(461, 94)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(43, 17)
        lblDate.TabIndex = 16
        lblDate.Text = "Date:"
        ' 
        ' dtpSummaryDate
        ' 
        dtpSummaryDate.Format = DateTimePickerFormat.Short
        dtpSummaryDate.Location = New Point(521, 88)
        dtpSummaryDate.Name = "dtpSummaryDate"
        dtpSummaryDate.Size = New Size(137, 25)
        dtpSummaryDate.TabIndex = 17
        ' 
        ' lstSummary
        ' 
        lstSummary.FormattingEnabled = True
        lstSummary.Location = New Point(12, 175)
        lstSummary.Name = "lstSummary"
        lstSummary.Size = New Size(554, 276)
        lstSummary.TabIndex = 18
        ' 
        ' lblTitleRevenue
        ' 
        lblTitleRevenue.AutoSize = True
        lblTitleRevenue.Location = New Point(572, 309)
        lblTitleRevenue.Name = "lblTitleRevenue"
        lblTitleRevenue.Size = New Size(112, 17)
        lblTitleRevenue.TabIndex = 19
        lblTitleRevenue.Text = "Total Revenue: "
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.BackColor = SystemColors.ActiveCaption
        lblTotalRevenue.Location = New Point(687, 302)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(123, 31)
        lblTotalRevenue.TabIndex = 20
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ActiveCaption
        btnClear.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(572, 398)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(249, 36)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAllBookings
        ' 
        btnAllBookings.BackColor = Color.Gainsboro
        btnAllBookings.Font = New Font("Segoe UI Historic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAllBookings.Location = New Point(12, 440)
        btnAllBookings.Name = "btnAllBookings"
        btnAllBookings.Size = New Size(756, 25)
        btnAllBookings.TabIndex = 22
        btnAllBookings.Text = "Show All "
        btnAllBookings.UseVisualStyleBackColor = False
        ' 
        ' frmRouteSummary
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(834, 471)
        Controls.Add(btnAllBookings)
        Controls.Add(btnClear)
        Controls.Add(lblTotalRevenue)
        Controls.Add(lblTitleRevenue)
        Controls.Add(lstSummary)
        Controls.Add(dtpSummaryDate)
        Controls.Add(lblDate)
        Controls.Add(lblSelect)
        Controls.Add(cboRoute)
        Controls.Add(lblSummary)
        Controls.Add(lblTotalWeight)
        Controls.Add(lblBookingCount)
        Controls.Add(btnClose)
        Controls.Add(lblTotal)
        Controls.Add(lblBookings)
        Controls.Add(lblHeading)
        Controls.Add(btnGenerateSummary)
        Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MinimizeBox = False
        Name = "frmRouteSummary"
        StartPosition = FormStartPosition.CenterParent
        Text = "FijiFerry-Route Summary "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGenerateSummary As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblBookings As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvRouteSummary As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents lblBookingCount As Label
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents cboRoute As ComboBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpSummaryDate As DateTimePicker
    Friend WithEvents lstSummary As ListBox
    Friend WithEvents lblTitleRevenue As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAllBookings As Button
End Class
