<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsedComputerSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsedComputerSales))
        Me.Selections = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMonitorCost = New System.Windows.Forms.TextBox()
        Me.lblCPUCost = New System.Windows.Forms.TextBox()
        Me.cboMonitorSelect = New System.Windows.Forms.ComboBox()
        Me.cboCPUSelect = New System.Windows.Forms.ComboBox()
        Me.Charges = New System.Windows.Forms.GroupBox()
        Me.chkWarrantyOption = New System.Windows.Forms.CheckBox()
        Me.chkMaintanceOption = New System.Windows.Forms.CheckBox()
        Me.Totals = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CPU = New System.Windows.Forms.Label()
        Me.lblGrandTotalCostBreakDown = New System.Windows.Forms.TextBox()
        Me.lblTaxCostBreakDown = New System.Windows.Forms.TextBox()
        Me.lblSubTotalCostBreakDown = New System.Windows.Forms.TextBox()
        Me.lblAddOnCostBreakDown = New System.Windows.Forms.TextBox()
        Me.lblMonitorCostBreakDown = New System.Windows.Forms.TextBox()
        Me.lblCPUCostBreakDown = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Selections.SuspendLayout()
        Me.Charges.SuspendLayout()
        Me.Totals.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Selections
        '
        Me.Selections.Controls.Add(Me.Label9)
        Me.Selections.Controls.Add(Me.Label8)
        Me.Selections.Controls.Add(Me.Label7)
        Me.Selections.Controls.Add(Me.Label6)
        Me.Selections.Controls.Add(Me.lblMonitorCost)
        Me.Selections.Controls.Add(Me.lblCPUCost)
        Me.Selections.Controls.Add(Me.cboMonitorSelect)
        Me.Selections.Controls.Add(Me.cboCPUSelect)
        Me.Selections.Location = New System.Drawing.Point(246, 12)
        Me.Selections.Name = "Selections"
        Me.Selections.Size = New System.Drawing.Size(670, 154)
        Me.Selections.TabIndex = 0
        Me.Selections.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Monitor Cost"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "CPU Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Available Monitors In Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Available CPUs In Stock"
        '
        'lblMonitorCost
        '
        Me.lblMonitorCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorCost.Location = New System.Drawing.Point(402, 101)
        Me.lblMonitorCost.Name = "lblMonitorCost"
        Me.lblMonitorCost.Size = New System.Drawing.Size(186, 23)
        Me.lblMonitorCost.TabIndex = 4
        '
        'lblCPUCost
        '
        Me.lblCPUCost.BackColor = System.Drawing.SystemColors.Window
        Me.lblCPUCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUCost.Location = New System.Drawing.Point(60, 101)
        Me.lblCPUCost.Name = "lblCPUCost"
        Me.lblCPUCost.Size = New System.Drawing.Size(186, 23)
        Me.lblCPUCost.TabIndex = 3
        '
        'cboMonitorSelect
        '
        Me.cboMonitorSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonitorSelect.FormattingEnabled = True
        Me.cboMonitorSelect.Items.AddRange(New Object() {"Dell 5230 21"" LCD", "Dell 6500 32"" LCD", "HP Series 2 18"" LCD", "HP GFx 27"" LCD", "IBM 3500 23"" LCD", "Sonic 32"" Curved LCD"})
        Me.cboMonitorSelect.Location = New System.Drawing.Point(402, 42)
        Me.cboMonitorSelect.Name = "cboMonitorSelect"
        Me.cboMonitorSelect.Size = New System.Drawing.Size(186, 24)
        Me.cboMonitorSelect.TabIndex = 2
        Me.cboMonitorSelect.Text = "--Select Your Monitor--"
        '
        'cboCPUSelect
        '
        Me.cboCPUSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCPUSelect.FormattingEnabled = True
        Me.cboCPUSelect.Items.AddRange(New Object() {"Lenovo Model 34", "Lenovo Model 77B", "IBM PS/2 1000 33G", "Dell 7630", "Dell 53Gx", "HP 4500", "HP 4550", "HP 950T"})
        Me.cboCPUSelect.Location = New System.Drawing.Point(60, 42)
        Me.cboCPUSelect.Name = "cboCPUSelect"
        Me.cboCPUSelect.Size = New System.Drawing.Size(186, 24)
        Me.cboCPUSelect.TabIndex = 0
        Me.cboCPUSelect.Text = "--Select Your CPU--"
        '
        'Charges
        '
        Me.Charges.Controls.Add(Me.chkWarrantyOption)
        Me.Charges.Controls.Add(Me.chkMaintanceOption)
        Me.Charges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Charges.Location = New System.Drawing.Point(246, 190)
        Me.Charges.Name = "Charges"
        Me.Charges.Size = New System.Drawing.Size(530, 112)
        Me.Charges.TabIndex = 1
        Me.Charges.TabStop = False
        Me.Charges.Text = "Additional Charges"
        '
        'chkWarrantyOption
        '
        Me.chkWarrantyOption.AutoSize = True
        Me.chkWarrantyOption.Location = New System.Drawing.Point(75, 64)
        Me.chkWarrantyOption.Name = "chkWarrantyOption"
        Me.chkWarrantyOption.Size = New System.Drawing.Size(256, 24)
        Me.chkWarrantyOption.TabIndex = 3
        Me.chkWarrantyOption.Text = "2-Year Warranty (+ $125.00)"
        Me.chkWarrantyOption.UseVisualStyleBackColor = True
        '
        'chkMaintanceOption
        '
        Me.chkMaintanceOption.AutoSize = True
        Me.chkMaintanceOption.Location = New System.Drawing.Point(75, 25)
        Me.chkMaintanceOption.Name = "chkMaintanceOption"
        Me.chkMaintanceOption.Size = New System.Drawing.Size(283, 24)
        Me.chkMaintanceOption.TabIndex = 2
        Me.chkMaintanceOption.Text = "Yearly Maintenance (+ $250.00)"
        Me.chkMaintanceOption.UseVisualStyleBackColor = True
        '
        'Totals
        '
        Me.Totals.Controls.Add(Me.Label5)
        Me.Totals.Controls.Add(Me.Label4)
        Me.Totals.Controls.Add(Me.Label3)
        Me.Totals.Controls.Add(Me.Label2)
        Me.Totals.Controls.Add(Me.Label1)
        Me.Totals.Controls.Add(Me.CPU)
        Me.Totals.Controls.Add(Me.lblGrandTotalCostBreakDown)
        Me.Totals.Controls.Add(Me.lblTaxCostBreakDown)
        Me.Totals.Controls.Add(Me.lblSubTotalCostBreakDown)
        Me.Totals.Controls.Add(Me.lblAddOnCostBreakDown)
        Me.Totals.Controls.Add(Me.lblMonitorCostBreakDown)
        Me.Totals.Controls.Add(Me.lblCPUCostBreakDown)
        Me.Totals.Enabled = False
        Me.Totals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totals.Location = New System.Drawing.Point(12, 308)
        Me.Totals.Name = "Totals"
        Me.Totals.Size = New System.Drawing.Size(904, 240)
        Me.Totals.TabIndex = 2
        Me.Totals.TabStop = False
        Me.Totals.Text = "Total Breakdown"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(63, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Charges:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tax (6.25%):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SubTotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Add-Ons:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Monitor:"
        '
        'CPU
        '
        Me.CPU.AutoSize = True
        Me.CPU.Location = New System.Drawing.Point(63, 44)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(50, 20)
        Me.CPU.TabIndex = 6
        Me.CPU.Text = "CPU:"
        '
        'lblGrandTotalCostBreakDown
        '
        Me.lblGrandTotalCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblGrandTotalCostBreakDown.Location = New System.Drawing.Point(234, 198)
        Me.lblGrandTotalCostBreakDown.Name = "lblGrandTotalCostBreakDown"
        Me.lblGrandTotalCostBreakDown.Size = New System.Drawing.Size(246, 26)
        Me.lblGrandTotalCostBreakDown.TabIndex = 5
        '
        'lblTaxCostBreakDown
        '
        Me.lblTaxCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblTaxCostBreakDown.Location = New System.Drawing.Point(234, 166)
        Me.lblTaxCostBreakDown.Name = "lblTaxCostBreakDown"
        Me.lblTaxCostBreakDown.Size = New System.Drawing.Size(246, 26)
        Me.lblTaxCostBreakDown.TabIndex = 4
        '
        'lblSubTotalCostBreakDown
        '
        Me.lblSubTotalCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblSubTotalCostBreakDown.Location = New System.Drawing.Point(234, 134)
        Me.lblSubTotalCostBreakDown.Name = "lblSubTotalCostBreakDown"
        Me.lblSubTotalCostBreakDown.Size = New System.Drawing.Size(246, 26)
        Me.lblSubTotalCostBreakDown.TabIndex = 3
        '
        'lblAddOnCostBreakDown
        '
        Me.lblAddOnCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblAddOnCostBreakDown.Location = New System.Drawing.Point(234, 102)
        Me.lblAddOnCostBreakDown.Name = "lblAddOnCostBreakDown"
        Me.lblAddOnCostBreakDown.Size = New System.Drawing.Size(512, 26)
        Me.lblAddOnCostBreakDown.TabIndex = 2
        '
        'lblMonitorCostBreakDown
        '
        Me.lblMonitorCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblMonitorCostBreakDown.Location = New System.Drawing.Point(234, 70)
        Me.lblMonitorCostBreakDown.Name = "lblMonitorCostBreakDown"
        Me.lblMonitorCostBreakDown.Size = New System.Drawing.Size(512, 26)
        Me.lblMonitorCostBreakDown.TabIndex = 1
        '
        'lblCPUCostBreakDown
        '
        Me.lblCPUCostBreakDown.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblCPUCostBreakDown.Location = New System.Drawing.Point(234, 38)
        Me.lblCPUCostBreakDown.Name = "lblCPUCostBreakDown"
        Me.lblCPUCostBreakDown.Size = New System.Drawing.Size(512, 26)
        Me.lblCPUCostBreakDown.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(812, 197)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(812, 238)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 23)
        Me.btnClearForm.TabIndex = 4
        Me.btnClearForm.Text = "Clear"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitApp.Location = New System.Drawing.Point(812, 279)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(75, 23)
        Me.btnExitApp.TabIndex = 5
        Me.btnExitApp.Text = "Exit"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bradshaw___Used_Computer_Sales.My.Resources.Resources.Workstation
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Local PC Super-Center"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "123 North Main Street"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Louisville, KY 40018"
        '
        'UsedComputerSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 591)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Totals)
        Me.Controls.Add(Me.Charges)
        Me.Controls.Add(Me.Selections)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(950, 630)
        Me.MinimumSize = New System.Drawing.Size(950, 630)
        Me.Name = "UsedComputerSales"
        Me.Text = "Bradshaw - Used Computer Sales Fall 2021"
        Me.Selections.ResumeLayout(False)
        Me.Selections.PerformLayout()
        Me.Charges.ResumeLayout(False)
        Me.Charges.PerformLayout()
        Me.Totals.ResumeLayout(False)
        Me.Totals.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Selections As GroupBox
    Friend WithEvents Charges As GroupBox
    Friend WithEvents Totals As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExitApp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMonitorCost As TextBox
    Friend WithEvents lblCPUCost As TextBox
    Friend WithEvents cboMonitorSelect As ComboBox
    Friend WithEvents cboCPUSelect As ComboBox
    Friend WithEvents chkWarrantyOption As CheckBox
    Friend WithEvents chkMaintanceOption As CheckBox
    Friend WithEvents lblCPUCostBreakDown As TextBox
    Friend WithEvents CPU As Label
    Friend WithEvents lblGrandTotalCostBreakDown As TextBox
    Friend WithEvents lblTaxCostBreakDown As TextBox
    Friend WithEvents lblSubTotalCostBreakDown As TextBox
    Friend WithEvents lblAddOnCostBreakDown As TextBox
    Friend WithEvents lblMonitorCostBreakDown As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
