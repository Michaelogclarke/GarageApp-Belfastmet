<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTotalFuel = New System.Windows.Forms.Label()
        Me.AdminDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminData = New GarageApp.AdminData()
        Me.TotalFuelPumpedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmFuelPumpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalFuel
        '
        Me.lblTotalFuel.AutoSize = True
        Me.lblTotalFuel.Location = New System.Drawing.Point(360, 100)
        Me.lblTotalFuel.Name = "lblTotalFuel"
        Me.lblTotalFuel.Size = New System.Drawing.Size(54, 13)
        Me.lblTotalFuel.TabIndex = 0
        Me.lblTotalFuel.Text = "Total Fuel"
        '
        'AdminDataBindingSource
        '
        Me.AdminDataBindingSource.DataSource = Me.AdminData
        Me.AdminDataBindingSource.Position = 0
        '
        'AdminData
        '
        Me.AdminData.DataSetName = "AdminData"
        Me.AdminData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalFuelPumpedBindingSource
        '
        Me.TotalFuelPumpedBindingSource.DataMember = "Total Fuel pumped"
        Me.TotalFuelPumpedBindingSource.DataSource = Me.AdminDataBindingSource
        '
        'FrmFuelPumpBindingSource
        '
        Me.FrmFuelPumpBindingSource.DataSource = GetType(GarageApp.frmFuelPump)
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalFuel)
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalFuel As Label
    Friend WithEvents AdminDataBindingSource As BindingSource
    Friend WithEvents AdminData As AdminData
    Friend WithEvents FrmFuelPumpBindingSource As BindingSource
    Friend WithEvents TotalFuelPumpedBindingSource As BindingSource
End Class
