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
        lblHeading.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(234, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(182, 30)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Freight Statistics"
        ' 
        ' lblTotalCargoWeight
        ' 
        lblTotalCargoWeight.AutoSize = True
        lblTotalCargoWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCargoWeight.Location = New Point(19, 91)
        lblTotalCargoWeight.Name = "lblTotalCargoWeight"
        lblTotalCargoWeight.Size = New Size(166, 21)
        lblTotalCargoWeight.TabIndex = 1
        lblTotalCargoWeight.Text = "Total Cargo Weight:"
        ' 
        ' lblTotalWeight
        ' 
        lblTotalWeight.BackColor = Color.White
        lblTotalWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalWeight.Location = New Point(234, 85)
        lblTotalWeight.Name = "lblTotalWeight"
        lblTotalWeight.Size = New Size(165, 32)
        lblTotalWeight.TabIndex = 2
        lblTotalWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalFreightRevenue
        ' 
        lblTotalFreightRevenue.AutoSize = True
        lblTotalFreightRevenue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFreightRevenue.Location = New Point(19, 145)
        lblTotalFreightRevenue.Name = "lblTotalFreightRevenue"
        lblTotalFreightRevenue.Size = New Size(186, 21)
        lblTotalFreightRevenue.TabIndex = 3
        lblTotalFreightRevenue.Text = "Total Freight Revenue:"
        ' 
        ' lblRevenue
        ' 
        lblRevenue.BackColor = Color.White
        lblRevenue.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRevenue.Location = New Point(234, 140)
        lblRevenue.Name = "lblRevenue"
        lblRevenue.Size = New Size(165, 31)
        lblRevenue.TabIndex = 4
        lblRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAverageWeightBooking
        ' 
        lblAverageWeightBooking.AutoSize = True
        lblAverageWeightBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageWeightBooking.Location = New Point(19, 198)
        lblAverageWeightBooking.Name = "lblAverageWeightBooking"
        lblAverageWeightBooking.Size = New Size(208, 21)
        lblAverageWeightBooking.TabIndex = 5
        lblAverageWeightBooking.Text = "Average Booking Weight:"
        ' 
        ' lblAverageWeight
        ' 
        lblAverageWeight.BackColor = Color.White
        lblAverageWeight.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverageWeight.Location = New Point(234, 193)
        lblAverageWeight.Name = "lblAverageWeight"
        lblAverageWeight.Size = New Size(165, 31)
        lblAverageWeight.TabIndex = 6
        lblAverageWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHeaviestBooking
        ' 
        lblHeaviestBooking.AutoSize = True
        lblHeaviestBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaviestBooking.Location = New Point(19, 254)
        lblHeaviestBooking.Name = "lblHeaviestBooking"
        lblHeaviestBooking.Size = New Size(150, 21)
        lblHeaviestBooking.TabIndex = 7
        lblHeaviestBooking.Text = "Heaviest Booking:"
        ' 
        ' lblHeaviest
        ' 
        lblHeaviest.BackColor = Color.White
        lblHeaviest.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaviest.Location = New Point(234, 249)
        lblHeaviest.Name = "lblHeaviest"
        lblHeaviest.Size = New Size(165, 31)
        lblHeaviest.TabIndex = 8
        lblHeaviest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLightestBooking
        ' 
        lblLightestBooking.AutoSize = True
        lblLightestBooking.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLightestBooking.Location = New Point(19, 310)
        lblLightestBooking.Name = "lblLightestBooking"
        lblLightestBooking.Size = New Size(146, 21)
        lblLightestBooking.TabIndex = 9
        lblLightestBooking.Text = "Lightest Booking:"
        ' 
        ' lblLightest
        ' 
        lblLightest.BackColor = Color.White
        lblLightest.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLightest.Location = New Point(234, 302)
        lblLightest.Name = "lblLightest"
        lblLightest.Size = New Size(165, 29)
        lblLightest.TabIndex = 10
        lblLightest.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightGray
        btnClose.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(532, 369)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(90, 30)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmStatistics
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(634, 411)
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
