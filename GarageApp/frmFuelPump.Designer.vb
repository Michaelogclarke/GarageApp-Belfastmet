﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelPump
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.btnPumpFuel = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.rbpetrol = New System.Windows.Forms.RadioButton()
        Me.rbDiesel = New System.Windows.Forms.RadioButton()
        Me.lbLitres = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPriceAmount = New System.Windows.Forms.Label()
        Me.lblLitresAmount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.petrolPriceTmr = New System.Windows.Forms.Timer(Me.components)
        Me.DieselPricetmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminData1 = New GarageApp.AdminData()
        CType(Me.AdminData1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnCloseProgram.Location = New System.Drawing.Point(698, 407)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(78, 31)
        Me.btnCloseProgram.TabIndex = 0
        Me.btnCloseProgram.Text = "Close"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'btnPumpFuel
        '
        Me.btnPumpFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnPumpFuel.Location = New System.Drawing.Point(366, 245)
        Me.btnPumpFuel.Name = "btnPumpFuel"
        Me.btnPumpFuel.Size = New System.Drawing.Size(75, 33)
        Me.btnPumpFuel.TabIndex = 1
        Me.btnPumpFuel.Text = "Start Fuel"
        Me.btnPumpFuel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnPay.Location = New System.Drawing.Point(366, 320)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 36)
        Me.btnPay.TabIndex = 2
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'rbpetrol
        '
        Me.rbpetrol.AutoSize = True
        Me.rbpetrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.rbpetrol.Location = New System.Drawing.Point(305, 174)
        Me.rbpetrol.Name = "rbpetrol"
        Me.rbpetrol.Size = New System.Drawing.Size(76, 28)
        Me.rbpetrol.TabIndex = 3
        Me.rbpetrol.TabStop = True
        Me.rbpetrol.Text = "Petrol"
        Me.rbpetrol.UseVisualStyleBackColor = True
        '
        'rbDiesel
        '
        Me.rbDiesel.AutoSize = True
        Me.rbDiesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.rbDiesel.Location = New System.Drawing.Point(441, 174)
        Me.rbDiesel.Name = "rbDiesel"
        Me.rbDiesel.Size = New System.Drawing.Size(80, 28)
        Me.rbDiesel.TabIndex = 4
        Me.rbDiesel.TabStop = True
        Me.rbDiesel.Text = "Diesel"
        Me.rbDiesel.UseVisualStyleBackColor = True
        '
        'lbLitres
        '
        Me.lbLitres.AutoSize = True
        Me.lbLitres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lbLitres.Location = New System.Drawing.Point(329, 50)
        Me.lbLitres.Name = "lbLitres"
        Me.lbLitres.Size = New System.Drawing.Size(54, 24)
        Me.lbLitres.TabIndex = 5
        Me.lbLitres.Text = "Litres"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblPrice.Location = New System.Drawing.Point(329, 89)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(53, 24)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price"
        '
        'lblPriceAmount
        '
        Me.lblPriceAmount.AutoSize = True
        Me.lblPriceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblPriceAmount.Location = New System.Drawing.Point(430, 89)
        Me.lblPriceAmount.Name = "lblPriceAmount"
        Me.lblPriceAmount.Size = New System.Drawing.Size(55, 24)
        Me.lblPriceAmount.TabIndex = 7
        Me.lblPriceAmount.Text = "£0.00"
        '
        'lblLitresAmount
        '
        Me.lblLitresAmount.AutoSize = True
        Me.lblLitresAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblLitresAmount.Location = New System.Drawing.Point(427, 50)
        Me.lblLitresAmount.Name = "lblLitresAmount"
        Me.lblLitresAmount.Size = New System.Drawing.Size(55, 24)
        Me.lblLitresAmount.TabIndex = 8
        Me.lblLitresAmount.Text = "0.00L"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'petrolPriceTmr
        '
        '
        'DieselPricetmr
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(378, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hold"
        '
        'AdminData1
        '
        Me.AdminData1.DataSetName = "AdminData"
        Me.AdminData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmFuelPump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLitresAmount)
        Me.Controls.Add(Me.lblPriceAmount)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lbLitres)
        Me.Controls.Add(Me.rbDiesel)
        Me.Controls.Add(Me.rbpetrol)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnPumpFuel)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Name = "frmFuelPump"
        Me.Text = "frmFuelPump"
        CType(Me.AdminData1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents btnPumpFuel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents rbpetrol As RadioButton
    Friend WithEvents rbDiesel As RadioButton
    Friend WithEvents lbLitres As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPriceAmount As Label
    Friend WithEvents lblLitresAmount As Label
    Public WithEvents Timer1 As Timer
    Friend WithEvents petrolPriceTmr As Timer
    Friend WithEvents DieselPricetmr As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents AdminData1 As AdminData
End Class
