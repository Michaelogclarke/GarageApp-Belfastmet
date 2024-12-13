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
        Me.lblrecent = New System.Windows.Forms.Label()
        Me.AdminDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminData = New GarageApp.AdminData()
        Me.TotalFuelPumpedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblFueltxt = New System.Windows.Forms.Label()
        Me.lblPricetxt = New System.Windows.Forms.Label()
        Me.FrmFuelPumpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblrecent
        '
        Me.lblrecent.AutoSize = True
        Me.lblrecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecent.Location = New System.Drawing.Point(287, 85)
        Me.lblrecent.Name = "lblrecent"
        Me.lblrecent.Size = New System.Drawing.Size(165, 24)
        Me.lblrecent.TabIndex = 0
        Me.lblrecent.Text = "Recent transaction"
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
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuel.Location = New System.Drawing.Point(170, 141)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(119, 24)
        Me.lblFuel.TabIndex = 1
        Me.lblFuel.Text = "Fuel Amount"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(476, 141)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(124, 24)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price Amount"
        '
        'lblFueltxt
        '
        Me.lblFueltxt.AutoSize = True
        Me.lblFueltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFueltxt.Location = New System.Drawing.Point(170, 185)
        Me.lblFueltxt.Name = "lblFueltxt"
        Me.lblFueltxt.Size = New System.Drawing.Size(119, 24)
        Me.lblFueltxt.TabIndex = 3
        Me.lblFueltxt.Text = "Fuel Amount"
        '
        'lblPricetxt
        '
        Me.lblPricetxt.AutoSize = True
        Me.lblPricetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricetxt.Location = New System.Drawing.Point(476, 185)
        Me.lblPricetxt.Name = "lblPricetxt"
        Me.lblPricetxt.Size = New System.Drawing.Size(124, 24)
        Me.lblPricetxt.TabIndex = 4
        Me.lblPricetxt.Text = "Price Amount"
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
        Me.Controls.Add(Me.lblPricetxt)
        Me.Controls.Add(Me.lblFueltxt)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblFuel)
        Me.Controls.Add(Me.lblrecent)
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblrecent As Label
    Friend WithEvents AdminDataBindingSource As BindingSource
    Friend WithEvents AdminData As AdminData
    Friend WithEvents FrmFuelPumpBindingSource As BindingSource
    Friend WithEvents TotalFuelPumpedBindingSource As BindingSource
    Friend WithEvents lblFuel As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblFueltxt As Label
    Friend WithEvents lblPricetxt As Label
End Class
