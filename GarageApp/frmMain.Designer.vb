<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(340, 225)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 53)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start fuel transaction"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Location = New System.Drawing.Point(12, 12)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnAdminLogin.TabIndex = 1
        Me.btnAdminLogin.Text = "Admin Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblName.Location = New System.Drawing.Point(306, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(190, 31)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Garages R US"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents lblName As Label
End Class
