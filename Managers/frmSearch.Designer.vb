<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        lblSearchBy = New Label()
        txtSearch = New TextBox()
        lblTitle = New Label()
        radBookingID = New RadioButton()
        radCustomerName = New RadioButton()
        btnSearch = New Button()
        btnClear = New Button()
        grpResults = New GroupBox()
        lstResults = New ListBox()
        grpDetails = New GroupBox()
        txtStatus = New TextBox()
        txtWeight = New TextBox()
        txtCargoType = New TextBox()
        txtDate = New TextBox()
        txtRoute = New TextBox()
        txtCustomerName = New TextBox()
        txtBookingID = New TextBox()
        lblStatus = New Label()
        lblWeight = New Label()
        lblCargoType = New Label()
        lblDate = New Label()
        lblRoute = New Label()
        lblCustomerName = New Label()
        lblBookingID = New Label()
        btnClose = New Button()
        grpResults.SuspendLayout()
        grpDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSearchBy
        ' 
        lblSearchBy.AutoSize = True
        lblSearchBy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearchBy.Location = New Point(199, 95)
        lblSearchBy.Name = "lblSearchBy"
        lblSearchBy.Size = New Size(121, 25)
        lblSearchBy.TabIndex = 0
        lblSearchBy.Text = "Search Value:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(326, 89)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(260, 31)
        txtSearch.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(277, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(301, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Search Cargo Booking Records"
        ' 
        ' radBookingID
        ' 
        radBookingID.AutoSize = True
        radBookingID.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radBookingID.Location = New Point(204, 172)
        radBookingID.Name = "radBookingID"
        radBookingID.Size = New Size(133, 29)
        radBookingID.TabIndex = 3
        radBookingID.TabStop = True
        radBookingID.Text = "Booking ID:"
        radBookingID.UseVisualStyleBackColor = True
        ' 
        ' radCustomerName
        ' 
        radCustomerName.AutoSize = True
        radCustomerName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radCustomerName.Location = New Point(204, 207)
        radCustomerName.Name = "radCustomerName"
        radCustomerName.Size = New Size(176, 29)
        radCustomerName.TabIndex = 4
        radCustomerName.TabStop = True
        radCustomerName.Text = "Customer Name:"
        radCustomerName.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(206, 274)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(131, 34)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(365, 274)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(125, 34)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' grpResults
        ' 
        grpResults.Controls.Add(lstResults)
        grpResults.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpResults.Location = New Point(218, 362)
        grpResults.Name = "grpResults"
        grpResults.Size = New Size(500, 193)
        grpResults.TabIndex = 7
        grpResults.TabStop = False
        grpResults.Text = "Search Results"
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.Location = New Point(22, 26)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(472, 154)
        lstResults.TabIndex = 0
        ' 
        ' grpDetails
        ' 
        grpDetails.Controls.Add(txtStatus)
        grpDetails.Controls.Add(txtWeight)
        grpDetails.Controls.Add(txtCargoType)
        grpDetails.Controls.Add(txtDate)
        grpDetails.Controls.Add(txtRoute)
        grpDetails.Controls.Add(txtCustomerName)
        grpDetails.Controls.Add(txtBookingID)
        grpDetails.Controls.Add(lblStatus)
        grpDetails.Controls.Add(lblWeight)
        grpDetails.Controls.Add(lblCargoType)
        grpDetails.Controls.Add(lblDate)
        grpDetails.Controls.Add(lblRoute)
        grpDetails.Controls.Add(lblCustomerName)
        grpDetails.Controls.Add(lblBookingID)
        grpDetails.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpDetails.Location = New Point(221, 623)
        grpDetails.Name = "grpDetails"
        grpDetails.Size = New Size(500, 384)
        grpDetails.TabIndex = 8
        grpDetails.TabStop = False
        grpDetails.Text = "Booking Details"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(193, 303)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(233, 31)
        txtStatus.TabIndex = 13
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(193, 262)
        txtWeight.Name = "txtWeight"
        txtWeight.ReadOnly = True
        txtWeight.Size = New Size(233, 31)
        txtWeight.TabIndex = 12
        ' 
        ' txtCargoType
        ' 
        txtCargoType.Location = New Point(193, 213)
        txtCargoType.Name = "txtCargoType"
        txtCargoType.ReadOnly = True
        txtCargoType.Size = New Size(233, 31)
        txtCargoType.TabIndex = 11
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(193, 168)
        txtDate.Name = "txtDate"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(233, 31)
        txtDate.TabIndex = 10
        ' 
        ' txtRoute
        ' 
        txtRoute.Location = New Point(193, 124)
        txtRoute.Name = "txtRoute"
        txtRoute.ReadOnly = True
        txtRoute.Size = New Size(233, 31)
        txtRoute.TabIndex = 9
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(193, 85)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(233, 31)
        txtCustomerName.TabIndex = 8
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Location = New Point(193, 41)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.ReadOnly = True
        txtBookingID.Size = New Size(233, 31)
        txtBookingID.TabIndex = 7
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(96, 306)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(63, 25)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Location = New Point(83, 265)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(76, 25)
        lblWeight.TabIndex = 5
        lblWeight.Text = "Weight:"
        ' 
        ' lblCargoType
        ' 
        lblCargoType.AutoSize = True
        lblCargoType.Location = New Point(50, 213)
        lblCargoType.Name = "lblCargoType"
        lblCargoType.Size = New Size(109, 25)
        lblCargoType.TabIndex = 4
        lblCargoType.Text = "Cargo Type:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(104, 168)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(55, 25)
        lblDate.TabIndex = 3
        lblDate.Text = "Date:"
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Location = New Point(93, 124)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(66, 25)
        lblRoute.TabIndex = 2
        lblRoute.Text = "Route:"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Location = New Point(15, 85)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(151, 25)
        lblCustomerName.TabIndex = 1
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblBookingID
        ' 
        lblBookingID.AutoSize = True
        lblBookingID.Location = New Point(51, 47)
        lblBookingID.Name = "lblBookingID"
        lblBookingID.Size = New Size(108, 25)
        lblBookingID.TabIndex = 0
        lblBookingID.Text = "Booking ID:"
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(221, 1042)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1117, 1050)
        Controls.Add(btnClose)
        Controls.Add(grpDetails)
        Controls.Add(grpResults)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(radCustomerName)
        Controls.Add(radBookingID)
        Controls.Add(lblTitle)
        Controls.Add(txtSearch)
        Controls.Add(lblSearchBy)
        Name = "frmSearch"
        Text = "Search Cargo Booking"
        grpResults.ResumeLayout(False)
        grpDetails.ResumeLayout(False)
        grpDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearchBy As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents radBookingID As RadioButton
    Friend WithEvents radCustomerName As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblCargoType As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblBookingID As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtCargoType As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtRoute As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClose As Button
End Class
