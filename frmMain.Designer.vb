<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuOpen = New ToolStripMenuItem()
        mnuSave = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        mnuStatistics = New ToolStripMenuItem()
        mnuRouteSummary = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        mnuSearch = New ToolStripMenuItem()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        mnuCollectedReport = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lstBookings = New ListBox()
        grpBookingDetails = New GroupBox()
        txtFreightCharge = New TextBox()
        txtStatus = New TextBox()
        txtRate = New TextBox()
        txtWeight = New TextBox()
        txtCargoType = New TextBox()
        txtDate = New TextBox()
        txtRoute = New TextBox()
        txtCustomerName = New TextBox()
        txtBookingID = New TextBox()
        lblFreightCharge = New Label()
        lblStatus = New Label()
        lblRate = New Label()
        lblWeight = New Label()
        lblCargoType = New Label()
        lblDate = New Label()
        lblRoute = New Label()
        lblCustomerName = New Label()
        lblBookingID = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblNewStatus = New Label()
        cboStatus = New ComboBox()
        btnUpdateStatus = New Button()
        btnClear = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        grpBookingDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ViewToolStripMenuItem, SearchToolStripMenuItem, ReportsToolStripMenuItem, mnuExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1014, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuOpen, mnuSave})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuOpen
        ' 
        mnuOpen.Name = "mnuOpen"
        mnuOpen.Size = New Size(270, 34)
        mnuOpen.Text = "Open Cargo File"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.Size = New Size(270, 34)
        mnuSave.Text = "Save Cargo File"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuStatistics, mnuRouteSummary})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(65, 29)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' mnuStatistics
        ' 
        mnuStatistics.Name = "mnuStatistics"
        mnuStatistics.Size = New Size(242, 34)
        mnuStatistics.Text = "Freight Statistics"
        ' 
        ' mnuRouteSummary
        ' 
        mnuRouteSummary.Name = "mnuRouteSummary"
        mnuRouteSummary.Size = New Size(242, 34)
        mnuRouteSummary.Text = "Route Summary"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuSearch})
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(80, 29)
        SearchToolStripMenuItem.Text = "Search"
        ' 
        ' mnuSearch
        ' 
        mnuSearch.Name = "mnuSearch"
        mnuSearch.Size = New Size(219, 34)
        mnuSearch.Text = "Find Booking"
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuCollectedReport})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(89, 29)
        ReportsToolStripMenuItem.Text = "Reports"
        ' 
        ' mnuCollectedReport
        ' 
        mnuCollectedReport.Name = "mnuCollectedReport"
        mnuCollectedReport.Size = New Size(298, 34)
        mnuCollectedReport.Text = "Cargo Collected Report"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(55, 29)
        mnuExit.Text = "Exit"
        ' 
        ' lstBookings
        ' 
        lstBookings.FormattingEnabled = True
        lstBookings.Location = New Point(41, 76)
        lstBookings.Name = "lstBookings"
        lstBookings.Size = New Size(352, 504)
        lstBookings.TabIndex = 1
        ' 
        ' grpBookingDetails
        ' 
        grpBookingDetails.Controls.Add(txtFreightCharge)
        grpBookingDetails.Controls.Add(txtStatus)
        grpBookingDetails.Controls.Add(txtRate)
        grpBookingDetails.Controls.Add(txtWeight)
        grpBookingDetails.Controls.Add(txtCargoType)
        grpBookingDetails.Controls.Add(txtDate)
        grpBookingDetails.Controls.Add(txtRoute)
        grpBookingDetails.Controls.Add(txtCustomerName)
        grpBookingDetails.Controls.Add(txtBookingID)
        grpBookingDetails.Controls.Add(lblFreightCharge)
        grpBookingDetails.Controls.Add(lblStatus)
        grpBookingDetails.Controls.Add(lblRate)
        grpBookingDetails.Controls.Add(lblWeight)
        grpBookingDetails.Controls.Add(lblCargoType)
        grpBookingDetails.Controls.Add(lblDate)
        grpBookingDetails.Controls.Add(lblRoute)
        grpBookingDetails.Controls.Add(lblCustomerName)
        grpBookingDetails.Controls.Add(lblBookingID)
        grpBookingDetails.Controls.Add(Label2)
        grpBookingDetails.Location = New Point(438, 76)
        grpBookingDetails.Name = "grpBookingDetails"
        grpBookingDetails.Size = New Size(532, 506)
        grpBookingDetails.TabIndex = 2
        grpBookingDetails.TabStop = False
        grpBookingDetails.Text = "Booking Details"
        ' 
        ' txtFreightCharge
        ' 
        txtFreightCharge.Location = New Point(183, 412)
        txtFreightCharge.Name = "txtFreightCharge"
        txtFreightCharge.ReadOnly = True
        txtFreightCharge.Size = New Size(303, 31)
        txtFreightCharge.TabIndex = 19
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(183, 362)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(303, 31)
        txtStatus.TabIndex = 18
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(183, 314)
        txtRate.Name = "txtRate"
        txtRate.ReadOnly = True
        txtRate.Size = New Size(303, 31)
        txtRate.TabIndex = 17
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(183, 266)
        txtWeight.Name = "txtWeight"
        txtWeight.ReadOnly = True
        txtWeight.Size = New Size(303, 31)
        txtWeight.TabIndex = 16
        ' 
        ' txtCargoType
        ' 
        txtCargoType.Location = New Point(183, 218)
        txtCargoType.Name = "txtCargoType"
        txtCargoType.ReadOnly = True
        txtCargoType.Size = New Size(303, 31)
        txtCargoType.TabIndex = 15
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(183, 172)
        txtDate.Name = "txtDate"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(303, 31)
        txtDate.TabIndex = 14
        ' 
        ' txtRoute
        ' 
        txtRoute.Location = New Point(183, 124)
        txtRoute.Name = "txtRoute"
        txtRoute.ReadOnly = True
        txtRoute.Size = New Size(303, 31)
        txtRoute.TabIndex = 13
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(183, 76)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(303, 31)
        txtCustomerName.TabIndex = 12
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Location = New Point(183, 32)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.ReadOnly = True
        txtBookingID.Size = New Size(303, 31)
        txtBookingID.TabIndex = 11
        ' 
        ' lblFreightCharge
        ' 
        lblFreightCharge.AutoSize = True
        lblFreightCharge.Location = New Point(34, 418)
        lblFreightCharge.Name = "lblFreightCharge"
        lblFreightCharge.Size = New Size(132, 25)
        lblFreightCharge.TabIndex = 10
        lblFreightCharge.Text = "Freight Charge:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(36, 368)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(64, 25)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status:"
        ' 
        ' lblRate
        ' 
        lblRate.AutoSize = True
        lblRate.Location = New Point(38, 320)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(106, 25)
        lblRate.TabIndex = 8
        lblRate.Text = "Rate Per Kg:"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(37, 272)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(108, 25)
        lblWeight.TabIndex = 7
        lblWeight.Text = "Weight (Kg):"
        ' 
        ' lblCargoType
        ' 
        lblCargoType.AutoSize = True
        lblCargoType.Location = New Point(34, 224)
        lblCargoType.Name = "lblCargoType"
        lblCargoType.Size = New Size(106, 25)
        lblCargoType.TabIndex = 6
        lblCargoType.Text = "Cargo Type:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(34, 178)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(53, 25)
        lblDate.TabIndex = 5
        lblDate.Text = "Date:"
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Location = New Point(34, 130)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(62, 25)
        lblRoute.TabIndex = 4
        lblRoute.Text = "Route:"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(34, 82)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(145, 25)
        lblCustomerName.TabIndex = 3
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblBookingID
        ' 
        lblBookingID.AutoSize = True
        lblBookingID.Location = New Point(34, 39)
        lblBookingID.Name = "lblBookingID"
        lblBookingID.Size = New Size(105, 25)
        lblBookingID.TabIndex = 2
        lblBookingID.Text = "Booking ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 3
        ' 
        ' lblNewStatus
        ' 
        lblNewStatus.AutoSize = True
        lblNewStatus.Location = New Point(235, 651)
        lblNewStatus.Name = "lblNewStatus"
        lblNewStatus.Size = New Size(104, 25)
        lblNewStatus.TabIndex = 4
        lblNewStatus.Text = "New Status:"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Booked", "Loaded", "Collected", "Delivered"})
        cboStatus.Location = New Point(351, 643)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(310, 33)
        cboStatus.TabIndex = 5
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Location = New Point(292, 724)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(140, 34)
        btnUpdateStatus.TabIndex = 6
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(466, 724)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(140, 34)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 862)
        Controls.Add(btnClear)
        Controls.Add(btnUpdateStatus)
        Controls.Add(cboStatus)
        Controls.Add(lblNewStatus)
        Controls.Add(Label1)
        Controls.Add(grpBookingDetails)
        Controls.Add(lstBookings)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FijiFerry Freight Records System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        grpBookingDetails.ResumeLayout(False)
        grpBookingDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuStatistics As ToolStripMenuItem
    Friend WithEvents mnuRouteSummary As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCollectedReport As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lstBookings As ListBox
    Friend WithEvents grpBookingDetails As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBookingID As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblCargoType As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblFreightCharge As Label
    Friend WithEvents txtFreightCharge As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtCargoType As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtRoute As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
