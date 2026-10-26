<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectedReport
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
        lblTitle = New Label()
        grpCollected = New GroupBox()
        lstCollectedCargo = New ListBox()
        btnClose = New Button()
        btnExport = New Button()
        grpCollected.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Navy
        lblTitle.Location = New Point(256, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(232, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Cargo Collected Report"
        ' 
        ' grpCollected
        ' 
        grpCollected.Controls.Add(lstCollectedCargo)
        grpCollected.ForeColor = Color.Navy
        grpCollected.Location = New Point(47, 90)
        grpCollected.Name = "grpCollected"
        grpCollected.Size = New Size(657, 383)
        grpCollected.TabIndex = 1
        grpCollected.TabStop = False
        grpCollected.Text = "Collected Cargo Records"
        ' 
        ' lstCollectedCargo
        ' 
        lstCollectedCargo.BackColor = Color.White
        lstCollectedCargo.ForeColor = Color.Black
        lstCollectedCargo.FormattingEnabled = True
        lstCollectedCargo.Location = New Point(21, 30)
        lstCollectedCargo.Name = "lstCollectedCargo"
        lstCollectedCargo.Size = New Size(610, 329)
        lstCollectedCargo.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.IndianRed
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(404, 519)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(135, 53)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.RoyalBlue
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(196, 519)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(159, 53)
        btnExport.TabIndex = 3
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' frmCollectedReport
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.FormBackground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(842, 599)
        Controls.Add(btnExport)
        Controls.Add(btnClose)
        Controls.Add(grpCollected)
        Controls.Add(lblTitle)
        Name = "frmCollectedReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cargo Collected Report"
        grpCollected.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpCollected As GroupBox
    Friend WithEvents lstCollectedCargo As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExport As Button
End Class
