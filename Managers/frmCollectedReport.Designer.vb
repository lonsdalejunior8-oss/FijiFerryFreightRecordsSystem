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
        lblTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(256, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(232, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Cargo Collected Report"
        ' 
        ' grpCollected
        ' 
        grpCollected.Controls.Add(lstCollectedCargo)
        grpCollected.Location = New Point(47, 90)
        grpCollected.Name = "grpCollected"
        grpCollected.Size = New Size(657, 383)
        grpCollected.TabIndex = 1
        grpCollected.TabStop = False
        grpCollected.Text = "Collected Cargo Records"
        ' 
        ' lstCollectedCargo
        ' 
        lstCollectedCargo.FormattingEnabled = True
        lstCollectedCargo.Location = New Point(21, 30)
        lstCollectedCargo.Name = "lstCollectedCargo"
        lstCollectedCargo.Size = New Size(610, 329)
        lstCollectedCargo.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(406, 519)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(135, 39)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnExport
        ' 
        btnExport.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.Location = New Point(196, 519)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(159, 39)
        btnExport.TabIndex = 3
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' frmCollectedReport
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
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
