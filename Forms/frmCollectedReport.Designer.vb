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
        grpCollected.Location = New Point(12, 91)
        grpCollected.Name = "grpCollected"
        grpCollected.Size = New Size(818, 403)
        grpCollected.TabIndex = 1
        grpCollected.TabStop = False
        grpCollected.Text = "Collected Cargo Records"
        ' 
        ' lstCollectedCargo
        ' 
        lstCollectedCargo.FormattingEnabled = True
        lstCollectedCargo.Location = New Point(21, 30)
        lstCollectedCargo.Name = "lstCollectedCargo"
        lstCollectedCargo.Size = New Size(776, 329)
        lstCollectedCargo.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(647, 537)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmCollectedReport
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(842, 628)
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
End Class
