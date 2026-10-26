<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        lblHeading = New Label()
        lblTotalCargoWeight = New Label()
        lblTotalWeight = New Label()
        lblTotalFreightRevenue = New Label()
        lblRevenue = New Label()
        lblAverageWeightBooking = New Label()
        lblAverageWeight = New Label()
        lblHeaviestBooking = New Label()
        lblHeaviest = New Label()
        lblLightestBooking = New Label()
        lblLightest = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.Transparent
        lblHeading.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.Navy
        lblHeading.Location = New Point(334, 19)
        lblHeading.Margin = New Padding(4, 0, 4, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(272, 45)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Freight Statistics"
        ' 
        ' lblTotalCargoWeight
        ' 
        lblTotalCargoWeight.AutoSize = True
        lblTotalCargoWeight.BackColor = Color.Transparent
        lblTotalCargoWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCargoWeight.ForeColor = Color.Navy
        lblTotalCargoWeight.Location = New Point(27, 152)
        lblTotalCargoWeight.Margin = New Padding(4, 0, 4, 0)
        lblTotalCargoWeight.Name = "lblTotalCargoWeight"
        lblTotalCargoWeight.Size = New Size(245, 32)
        lblTotalCargoWeight.TabIndex = 1
        lblTotalCargoWeight.Text = "Total Cargo Weight:"
        ' 
        ' lblTotalWeight
        ' 
        lblTotalWeight.BackColor = Color.White
        lblTotalWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalWeight.ForeColor = Color.Navy
        lblTotalWeight.Location = New Point(348, 142)
        lblTotalWeight.Margin = New Padding(4, 0, 4, 0)
        lblTotalWeight.Name = "lblTotalWeight"
        lblTotalWeight.Size = New Size(348, 53)
        lblTotalWeight.TabIndex = 2
        lblTotalWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalFreightRevenue
        ' 
        lblTotalFreightRevenue.AutoSize = True
        lblTotalFreightRevenue.BackColor = Color.Transparent
        lblTotalFreightRevenue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFreightRevenue.ForeColor = Color.Navy
        lblTotalFreightRevenue.Location = New Point(27, 242)
        lblTotalFreightRevenue.Margin = New Padding(4, 0, 4, 0)
        lblTotalFreightRevenue.Name = "lblTotalFreightRevenue"
        lblTotalFreightRevenue.Size = New Size(276, 32)
        lblTotalFreightRevenue.TabIndex = 3
        lblTotalFreightRevenue.Text = "Total Freight Revenue:"
        ' 
        ' lblRevenue
        ' 
        lblRevenue.BackColor = Color.White
        lblRevenue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRevenue.ForeColor = Color.SeaGreen
        lblRevenue.Location = New Point(348, 233)
        lblRevenue.Margin = New Padding(4, 0, 4, 0)
        lblRevenue.Name = "lblRevenue"
        lblRevenue.Size = New Size(348, 52)
        lblRevenue.TabIndex = 4
        lblRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAverageWeightBooking
        ' 
        lblAverageWeightBooking.AutoSize = True
        lblAverageWeightBooking.BackColor = Color.Transparent
        lblAverageWeightBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageWeightBooking.ForeColor = Color.Navy
        lblAverageWeightBooking.Location = New Point(27, 330)
        lblAverageWeightBooking.Margin = New Padding(4, 0, 4, 0)
        lblAverageWeightBooking.Name = "lblAverageWeightBooking"
        lblAverageWeightBooking.Size = New Size(308, 32)
        lblAverageWeightBooking.TabIndex = 5
        lblAverageWeightBooking.Text = "Average Booking Weight:"
        ' 
        ' lblAverageWeight
        ' 
        lblAverageWeight.BackColor = Color.White
        lblAverageWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageWeight.ForeColor = Color.DarkBlue
        lblAverageWeight.Location = New Point(348, 322)
        lblAverageWeight.Margin = New Padding(4, 0, 4, 0)
        lblAverageWeight.Name = "lblAverageWeight"
        lblAverageWeight.Size = New Size(348, 52)
        lblAverageWeight.TabIndex = 6
        lblAverageWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHeaviestBooking
        ' 
        lblHeaviestBooking.AutoSize = True
        lblHeaviestBooking.BackColor = Color.Transparent
        lblHeaviestBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaviestBooking.ForeColor = Color.Navy
        lblHeaviestBooking.Location = New Point(27, 423)
        lblHeaviestBooking.Margin = New Padding(4, 0, 4, 0)
        lblHeaviestBooking.Name = "lblHeaviestBooking"
        lblHeaviestBooking.Size = New Size(222, 32)
        lblHeaviestBooking.TabIndex = 7
        lblHeaviestBooking.Text = "Heaviest Booking:"
        ' 
        ' lblHeaviest
        ' 
        lblHeaviest.BackColor = Color.White
        lblHeaviest.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaviest.ForeColor = Color.Maroon
        lblHeaviest.Location = New Point(348, 416)
        lblHeaviest.Margin = New Padding(4, 0, 4, 0)
        lblHeaviest.Name = "lblHeaviest"
        lblHeaviest.Size = New Size(348, 52)
        lblHeaviest.TabIndex = 8
        lblHeaviest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLightestBooking
        ' 
        lblLightestBooking.AutoSize = True
        lblLightestBooking.BackColor = Color.Transparent
        lblLightestBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLightestBooking.ForeColor = Color.White
        lblLightestBooking.Location = New Point(27, 517)
        lblLightestBooking.Margin = New Padding(4, 0, 4, 0)
        lblLightestBooking.Name = "lblLightestBooking"
        lblLightestBooking.Size = New Size(215, 32)
        lblLightestBooking.TabIndex = 9
        lblLightestBooking.Text = "Lightest Booking:"
        ' 
        ' lblLightest
        ' 
        lblLightest.BackColor = Color.White
        lblLightest.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLightest.ForeColor = Color.Teal
        lblLightest.Location = New Point(348, 503)
        lblLightest.Margin = New Padding(4, 0, 4, 0)
        lblLightest.Name = "lblLightest"
        lblLightest.Size = New Size(348, 48)
        lblLightest.TabIndex = 10
        lblLightest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.IndianRed
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(760, 616)
        btnClose.Margin = New Padding(4, 5, 4, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(129, 50)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmStatistics
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.FormBackground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(906, 684)
        Controls.Add(btnClose)
        Controls.Add(lblLightest)
        Controls.Add(lblLightestBooking)
        Controls.Add(lblHeaviest)
        Controls.Add(lblHeaviestBooking)
        Controls.Add(lblAverageWeight)
        Controls.Add(lblAverageWeightBooking)
        Controls.Add(lblRevenue)
        Controls.Add(lblTotalFreightRevenue)
        Controls.Add(lblTotalWeight)
        Controls.Add(lblTotalCargoWeight)
        Controls.Add(lblHeading)
        ForeColor = Color.Navy
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmStatistics"
        StartPosition = FormStartPosition.CenterParent
        Text = "FijiFerry-Freight Statistics"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTotalCargoWeight As Label
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents lblTotalFreightRevenue As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblAverageWeightBooking As Label
    Friend WithEvents lblAverageWeight As Label
    Friend WithEvents lblHeaviestBooking As Label
    Friend WithEvents lblHeaviest As Label
    Friend WithEvents lblLightestBooking As Label
    Friend WithEvents lblLightest As Label
    Friend WithEvents btnClose As Button
End Class
