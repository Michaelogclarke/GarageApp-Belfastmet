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
        Me.btnChangePrice = New System.Windows.Forms.Button()
        Me.txtboxDieselAM = New System.Windows.Forms.TextBox()
        Me.txtboxPetrolAM = New System.Windows.Forms.TextBox()
        Me.btnReturntofuel = New System.Windows.Forms.Button()
        Me.lblDiesel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPetrolPrice = New System.Windows.Forms.Label()
        Me.lblDieselPrice = New System.Windows.Forms.Label()
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
        'btnChangePrice
        '
        Me.btnChangePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePrice.Location = New System.Drawing.Point(321, 337)
        Me.btnChangePrice.Name = "btnChangePrice"
        Me.btnChangePrice.Size = New System.Drawing.Size(112, 59)
        Me.btnChangePrice.TabIndex = 5
        Me.btnChangePrice.Text = "Change Price"
        Me.btnChangePrice.UseVisualStyleBackColor = True
        '
        'txtboxDieselAM
        '
        Me.txtboxDieselAM.Location = New System.Drawing.Point(174, 276)
        Me.txtboxDieselAM.Name = "txtboxDieselAM"
        Me.txtboxDieselAM.Size = New System.Drawing.Size(100, 20)
        Me.txtboxDieselAM.TabIndex = 6
        '
        'txtboxPetrolAM
        '
        Me.txtboxPetrolAM.Location = New System.Drawing.Point(480, 276)
        Me.txtboxPetrolAM.Name = "txtboxPetrolAM"
        Me.txtboxPetrolAM.Size = New System.Drawing.Size(100, 20)
        Me.txtboxPetrolAM.TabIndex = 7
        '
        'btnReturntofuel
        '
        Me.btnReturntofuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturntofuel.Location = New System.Drawing.Point(691, 397)
        Me.btnReturntofuel.Name = "btnReturntofuel"
        Me.btnReturntofuel.Size = New System.Drawing.Size(107, 41)
        Me.btnReturntofuel.TabIndex = 8
        Me.btnReturntofuel.Text = "Return to fuel pump"
        Me.btnReturntofuel.UseVisualStyleBackColor = True
        '
        'lblDiesel
        '
        Me.lblDiesel.AutoSize = True
        Me.lblDiesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiesel.Location = New System.Drawing.Point(170, 249)
        Me.lblDiesel.Name = "lblDiesel"
        Me.lblDiesel.Size = New System.Drawing.Size(110, 24)
        Me.lblDiesel.TabIndex = 9
        Me.lblDiesel.Text = "Diesel Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Petrol Price"
        '
        'lblPetrolPrice
        '
        Me.lblPetrolPrice.AutoSize = True
        Me.lblPetrolPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetrolPrice.Location = New System.Drawing.Point(476, 299)
        Me.lblPetrolPrice.Name = "lblPetrolPrice"
        Me.lblPetrolPrice.Size = New System.Drawing.Size(106, 24)
        Me.lblPetrolPrice.TabIndex = 11
        Me.lblPetrolPrice.Text = "Petrol Price"
        '
        'lblDieselPrice
        '
        Me.lblDieselPrice.AutoSize = True
        Me.lblDieselPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDieselPrice.Location = New System.Drawing.Point(170, 299)
        Me.lblDieselPrice.Name = "lblDieselPrice"
        Me.lblDieselPrice.Size = New System.Drawing.Size(110, 24)
        Me.lblDieselPrice.TabIndex = 12
        Me.lblDieselPrice.Text = "Diesel Price"
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
        Me.Controls.Add(Me.lblDieselPrice)
        Me.Controls.Add(Me.lblPetrolPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDiesel)
        Me.Controls.Add(Me.btnReturntofuel)
        Me.Controls.Add(Me.txtboxPetrolAM)
        Me.Controls.Add(Me.txtboxDieselAM)
        Me.Controls.Add(Me.btnChangePrice)
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
    Friend WithEvents btnChangePrice As Button
    Friend WithEvents txtboxDieselAM As TextBox
    Friend WithEvents txtboxPetrolAM As TextBox
    Friend WithEvents btnReturntofuel As Button
    Friend WithEvents lblDiesel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPetrolPrice As Label
    Friend WithEvents lblDieselPrice As Label
End Class
