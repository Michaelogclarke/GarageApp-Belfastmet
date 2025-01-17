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
        Me.AdminDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalFuelPumpedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnChangePrice = New System.Windows.Forms.Button()
        Me.txtboxDieselAM = New System.Windows.Forms.TextBox()
        Me.txtboxPetrolAM = New System.Windows.Forms.TextBox()
        Me.btnReturntofuel = New System.Windows.Forms.Button()
        Me.lblDiesel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPetrolPrice = New System.Windows.Forms.Label()
        Me.lblDieselPrice = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Fuel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FrmFuelPumpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalFuelPumpedBindingSource
        '
        Me.TotalFuelPumpedBindingSource.DataSource = Me.AdminDataBindingSource
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fuel, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(148, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(434, 164)
        Me.DataGridView1.TabIndex = 13
        '
        'Fuel
        '
        Me.Fuel.HeaderText = "Fuel"
        Me.Fuel.Name = "Fuel"
        Me.Fuel.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Recent Transactions"
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblDieselPrice)
        Me.Controls.Add(Me.lblPetrolPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDiesel)
        Me.Controls.Add(Me.btnReturntofuel)
        Me.Controls.Add(Me.txtboxPetrolAM)
        Me.Controls.Add(Me.txtboxDieselAM)
        Me.Controls.Add(Me.btnChangePrice)
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.AdminDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFuelPumpedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmFuelPumpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminDataBindingSource As BindingSource
    Friend WithEvents FrmFuelPumpBindingSource As BindingSource
    Friend WithEvents TotalFuelPumpedBindingSource As BindingSource
    Friend WithEvents btnChangePrice As Button
    Friend WithEvents txtboxDieselAM As TextBox
    Friend WithEvents txtboxPetrolAM As TextBox
    Friend WithEvents btnReturntofuel As Button
    Friend WithEvents lblDiesel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPetrolPrice As Label
    Friend WithEvents lblDieselPrice As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Fuel As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
