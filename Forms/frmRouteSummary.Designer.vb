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
        btnGenerateSummary.BackColor = Color.SeaGreen
        btnGenerateSummary.FlatStyle = FlatStyle.Flat
        btnGenerateSummary.ForeColor = Color.White
        btnGenerateSummary.Location = New Point(1031, 397)
        btnGenerateSummary.Name = "btnGenerateSummary"
        btnGenerateSummary.Size = New Size(340, 45)
        btnGenerateSummary.TabIndex = 4
        btnGenerateSummary.Text = "Generate Summary"
        btnGenerateSummary.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.BackColor = Color.Transparent
        lblHeading.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.Navy
        lblHeading.Location = New Point(279, 27)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(274, 36)
        lblHeading.TabIndex = 6
        lblHeading.Text = "FIJIFERRY-ROUTE SUMMARY"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBookings
        ' 
        lblBookings.AutoSize = True
        lblBookings.BackColor = Color.Transparent
        lblBookings.ForeColor = Color.DarkSlateGray
        lblBookings.Location = New Point(1031, 288)
        lblBookings.Name = "lblBookings"
        lblBookings.Size = New Size(161, 28)
        lblBookings.TabIndex = 7
        lblBookings.Text = "Total Bookings:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.ForeColor = Color.DarkSlateGray
        lblTotal.Location = New Point(1031, 233)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(142, 28)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Total Weight:"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.IndianRed
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(1217, 448)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(154, 42)
        btnClose.TabIndex = 10
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblBookingCount
        ' 
        lblBookingCount.BackColor = Color.White
        lblBookingCount.ForeColor = Color.Black
        lblBookingCount.Location = New Point(1193, 283)
        lblBookingCount.Name = "lblBookingCount"
        lblBookingCount.Size = New Size(178, 32)
        lblBookingCount.TabIndex = 11
        lblBookingCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalWeight
        ' 
        lblTotalWeight.BackColor = Color.White
        lblTotalWeight.ForeColor = Color.Black
        lblTotalWeight.Location = New Point(1193, 229)
        lblTotalWeight.Name = "lblTotalWeight"
        lblTotalWeight.Size = New Size(178, 32)
        lblTotalWeight.TabIndex = 12
        lblTotalWeight.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblSummary
        ' 
        lblSummary.BackColor = Color.Transparent
        lblSummary.ForeColor = Color.Navy
        lblSummary.Location = New Point(12, 173)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(684, 34)
        lblSummary.TabIndex = 13
        lblSummary.Text = "Route Summary Details"
        lblSummary.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRoute
        ' 
        cboRoute.BackColor = Color.White
        cboRoute.ForeColor = Color.Black
        cboRoute.FormattingEnabled = True
        cboRoute.Location = New Point(223, 106)
        cboRoute.Name = "cboRoute"
        cboRoute.Size = New Size(188, 36)
        cboRoute.TabIndex = 14
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.BackColor = Color.Transparent
        lblSelect.ForeColor = Color.DarkSlateGray
        lblSelect.Location = New Point(80, 109)
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(138, 28)
        lblSelect.TabIndex = 15
        lblSelect.Text = "Select Route:"
        lblSelect.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.ForeColor = Color.DarkSlateGray
        lblDate.Location = New Point(456, 109)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(62, 28)
        lblDate.TabIndex = 16
        lblDate.Text = "Date:"
        ' 
        ' dtpSummaryDate
        ' 
        dtpSummaryDate.Format = DateTimePickerFormat.Short
        dtpSummaryDate.Location = New Point(521, 103)
        dtpSummaryDate.Name = "dtpSummaryDate"
        dtpSummaryDate.Size = New Size(203, 33)
        dtpSummaryDate.TabIndex = 17
        ' 
        ' lstSummary
        ' 
        lstSummary.Font = New Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstSummary.ForeColor = Color.Black
        lstSummary.FormattingEnabled = True
        lstSummary.Location = New Point(12, 216)
        lstSummary.Name = "lstSummary"
        lstSummary.Size = New Size(998, 279)
        lstSummary.TabIndex = 18
        ' 
        ' lblTitleRevenue
        ' 
        lblTitleRevenue.AutoSize = True
        lblTitleRevenue.BackColor = Color.Transparent
        lblTitleRevenue.ForeColor = Color.DarkSlateGray
        lblTitleRevenue.Location = New Point(1031, 341)
        lblTitleRevenue.Name = "lblTitleRevenue"
        lblTitleRevenue.Size = New Size(159, 28)
        lblTitleRevenue.TabIndex = 19
        lblTitleRevenue.Text = "Total Revenue: "
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.BackColor = Color.White
        lblTotalRevenue.ForeColor = Color.Black
        lblTotalRevenue.Location = New Point(1193, 337)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(178, 31)
        lblTotalRevenue.TabIndex = 20
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DarkOrange
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(1031, 448)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(155, 45)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnAllBookings
        ' 
        btnAllBookings.BackColor = Color.RoyalBlue
        btnAllBookings.FlatStyle = FlatStyle.Flat
        btnAllBookings.Font = New Font("Segoe UI Historic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAllBookings.ForeColor = Color.White
        btnAllBookings.Location = New Point(12, 514)
        btnAllBookings.Name = "btnAllBookings"
        btnAllBookings.Size = New Size(998, 42)
        btnAllBookings.TabIndex = 22
        btnAllBookings.Text = "Show All "
        btnAllBookings.UseVisualStyleBackColor = False
        ' 
        ' frmRouteSummary
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.FormBackground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1407, 758)
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
        ForeColor = Color.DarkSlateGray
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
