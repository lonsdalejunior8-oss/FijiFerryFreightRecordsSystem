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
        ToolStripMenuItem1 = New ToolStripMenuItem()
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
        lblCargoBookings = New Label()
        grpStatusManagement = New GroupBox()
        MenuStrip1.SuspendLayout()
        grpBookingDetails.SuspendLayout()
        grpStatusManagement.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ViewToolStripMenuItem, SearchToolStripMenuItem, ReportsToolStripMenuItem, mnuExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 1, 0, 1)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1014, 31)
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
        mnuOpen.Size = New Size(242, 34)
        mnuOpen.Text = "Open Cargo File"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.Size = New Size(242, 34)
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
        mnuStatistics.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        mnuStatistics.Name = "mnuStatistics"
        mnuStatistics.Size = New Size(242, 34)
        mnuStatistics.Text = "Freight Statistics"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(274, 34)
        ToolStripMenuItem1.Text = "ToolStripMenuItem1"
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
        lstBookings.Location = New Point(41, 120)
        lstBookings.Margin = New Padding(2)
        lstBookings.Name = "lstBookings"
        lstBookings.Size = New Size(224, 604)
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
        grpBookingDetails.Location = New Point(334, 120)
        grpBookingDetails.Margin = New Padding(2)
        grpBookingDetails.Name = "grpBookingDetails"
        grpBookingDetails.Padding = New Padding(2)
        grpBookingDetails.Size = New Size(636, 604)
        grpBookingDetails.TabIndex = 2
        grpBookingDetails.TabStop = False
        grpBookingDetails.Text = "Booking Details"
        ' 
        ' txtFreightCharge
        ' 
        txtFreightCharge.Location = New Point(199, 412)
        txtFreightCharge.Margin = New Padding(2)
        txtFreightCharge.Name = "txtFreightCharge"
        txtFreightCharge.ReadOnly = True
        txtFreightCharge.Size = New Size(392, 31)
        txtFreightCharge.TabIndex = 19
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(199, 362)
        txtStatus.Margin = New Padding(2)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(392, 31)
        txtStatus.TabIndex = 18
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(199, 314)
        txtRate.Margin = New Padding(2)
        txtRate.Name = "txtRate"
        txtRate.ReadOnly = True
        txtRate.Size = New Size(392, 31)
        txtRate.TabIndex = 17
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(199, 266)
        txtWeight.Margin = New Padding(2)
        txtWeight.Name = "txtWeight"
        txtWeight.ReadOnly = True
        txtWeight.Size = New Size(392, 31)
        txtWeight.TabIndex = 16
        ' 
        ' txtCargoType
        ' 
        txtCargoType.Location = New Point(199, 218)
        txtCargoType.Margin = New Padding(2)
        txtCargoType.Name = "txtCargoType"
        txtCargoType.ReadOnly = True
        txtCargoType.Size = New Size(392, 31)
        txtCargoType.TabIndex = 15
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(199, 172)
        txtDate.Margin = New Padding(2)
        txtDate.Name = "txtDate"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(392, 31)
        txtDate.TabIndex = 14
        ' 
        ' txtRoute
        ' 
        txtRoute.Location = New Point(199, 124)
        txtRoute.Margin = New Padding(2)
        txtRoute.Name = "txtRoute"
        txtRoute.ReadOnly = True
        txtRoute.Size = New Size(392, 31)
        txtRoute.TabIndex = 13
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(199, 76)
        txtCustomerName.Margin = New Padding(2)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(392, 31)
        txtCustomerName.TabIndex = 12
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Location = New Point(199, 32)
        txtBookingID.Margin = New Padding(2)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.ReadOnly = True
        txtBookingID.Size = New Size(392, 31)
        txtBookingID.TabIndex = 11
        ' 
        ' lblFreightCharge
        ' 
        lblFreightCharge.AutoSize = True
        lblFreightCharge.Location = New Point(27, 418)
        lblFreightCharge.Margin = New Padding(2, 0, 2, 0)
        lblFreightCharge.Name = "lblFreightCharge"
        lblFreightCharge.Size = New Size(132, 25)
        lblFreightCharge.TabIndex = 10
        lblFreightCharge.Text = "Freight Charge:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(27, 368)
        lblStatus.Margin = New Padding(2, 0, 2, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(64, 25)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status:"
        ' 
        ' lblRate
        ' 
        lblRate.AutoSize = True
        lblRate.Location = New Point(27, 320)
        lblRate.Margin = New Padding(2, 0, 2, 0)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(106, 25)
        lblRate.TabIndex = 8
        lblRate.Text = "Rate Per Kg:"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(27, 272)
        lblWeight.Margin = New Padding(2, 0, 2, 0)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(108, 25)
        lblWeight.TabIndex = 7
        lblWeight.Text = "Weight (Kg):"
        ' 
        ' lblCargoType
        ' 
        lblCargoType.AutoSize = True
        lblCargoType.Location = New Point(27, 224)
        lblCargoType.Margin = New Padding(2, 0, 2, 0)
        lblCargoType.Name = "lblCargoType"
        lblCargoType.Size = New Size(106, 25)
        lblCargoType.TabIndex = 6
        lblCargoType.Text = "Cargo Type:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(27, 178)
        lblDate.Margin = New Padding(2, 0, 2, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(53, 25)
        lblDate.TabIndex = 5
        lblDate.Text = "Date:"
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Location = New Point(27, 130)
        lblRoute.Margin = New Padding(2, 0, 2, 0)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(62, 25)
        lblRoute.TabIndex = 4
        lblRoute.Text = "Route:"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(27, 82)
        lblCustomerName.Margin = New Padding(2, 0, 2, 0)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(145, 25)
        lblCustomerName.TabIndex = 3
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblBookingID
        ' 
        lblBookingID.AutoSize = True
        lblBookingID.Location = New Point(27, 38)
        lblBookingID.Margin = New Padding(2, 0, 2, 0)
        lblBookingID.Name = "lblBookingID"
        lblBookingID.Size = New Size(105, 25)
        lblBookingID.TabIndex = 2
        lblBookingID.Text = "Booking ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 31)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 3
        ' 
        ' lblNewStatus
        ' 
        lblNewStatus.AutoSize = True
        lblNewStatus.Location = New Point(37, 51)
        lblNewStatus.Margin = New Padding(2, 0, 2, 0)
        lblNewStatus.Name = "lblNewStatus"
        lblNewStatus.Size = New Size(104, 25)
        lblNewStatus.TabIndex = 4
        lblNewStatus.Text = "New Status:"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"Booked", "Loaded", "Collected"})
        cboStatus.Location = New Point(153, 43)
        cboStatus.Margin = New Padding(2)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(438, 33)
        cboStatus.TabIndex = 5
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Location = New Point(252, 135)
        btnUpdateStatus.Margin = New Padding(2)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(140, 50)
        btnUpdateStatus.TabIndex = 6
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(451, 135)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(140, 50)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' lblCargoBookings
        ' 
        lblCargoBookings.AutoSize = True
        lblCargoBookings.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCargoBookings.Location = New Point(38, 84)
        lblCargoBookings.Name = "lblCargoBookings"
        lblCargoBookings.Size = New Size(143, 25)
        lblCargoBookings.TabIndex = 9
        lblCargoBookings.Text = "Cargo Bookings"
        ' 
        ' grpStatusManagement
        ' 
        grpStatusManagement.Controls.Add(cboStatus)
        grpStatusManagement.Controls.Add(lblNewStatus)
        grpStatusManagement.Controls.Add(btnClear)
        grpStatusManagement.Controls.Add(btnUpdateStatus)
        grpStatusManagement.Location = New Point(334, 788)
        grpStatusManagement.Name = "grpStatusManagement"
        grpStatusManagement.Size = New Size(636, 210)
        grpStatusManagement.TabIndex = 10
        grpStatusManagement.TabStop = False
        grpStatusManagement.Text = "Status Management  "
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 1050)
        Controls.Add(grpStatusManagement)
        Controls.Add(lblCargoBookings)
        Controls.Add(Label1)
        Controls.Add(grpBookingDetails)
        Controls.Add(lstBookings)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FijiFerry Freight Records System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        grpBookingDetails.ResumeLayout(False)
        grpBookingDetails.PerformLayout()
        grpStatusManagement.ResumeLayout(False)
        grpStatusManagement.PerformLayout()
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblCargoBookings As Label
    Friend WithEvents grpStatusManagement As GroupBox

End Class
