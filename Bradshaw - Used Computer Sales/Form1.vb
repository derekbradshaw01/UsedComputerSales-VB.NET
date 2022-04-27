Public Class UsedComputerSales
    'Derek Bradshaw
    '9/20/2021
    'CPT 341 -  VB.NET NJIT Fall 2021 Semester





    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Decalre variables
        Dim decCPUCost As Decimal
        Dim decMonitorCost As Decimal
        Dim decAddOns As Decimal
        Dim decSubTotal As Decimal
        Dim decTax As Decimal
        Dim decGrandTotal As Decimal

        Try 'storing CPU Cost as a decimal
            decCPUCost = CDec(lblCPUCost.Text)
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal cost for 'CPU Price'", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblCPUCost.Clear()
        End Try
        Try 'storing Monitor Cost as a decimal
            decMonitorCost = CDec(lblMonitorCost.Text)
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("Please enter a valid decimal cost for 'Monitor Price'", "Value Invalid",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMonitorCost.Clear()
        End Try

        'START OF TOTAL CHARGES BOX - Everything formatted to 2 decimal places to react as normal currency

        'CPU picked and price, Monitor picked adn price
        lblCPUCostBreakDown.Text = cboCPUSelect.Text & " --  $ " & decCPUCost.ToString("F2")
        lblMonitorCostBreakDown.Text = cboMonitorSelect.Text & " --  $ " & decMonitorCost.ToString("F2")

        'Add-Ons check & amount added
        If chkMaintanceOption.Checked = True Then
            decAddOns = decAddOns + 250
        End If
        If chkWarrantyOption.Checked = True Then
            decAddOns = decAddOns + 125
        End If
        lblAddOnCostBreakDown.Text = "$ " & decAddOns

        'Sub-Total 
        decSubTotal = decCPUCost + decMonitorCost + decAddOns
        lblSubTotalCostBreakDown.Text = "$ " & decSubTotal.ToString("F2")

        'Taxes
        decTax = decSubTotal * 0.0625
        lblTaxCostBreakDown.Text = "$ " & decTax.ToString("F2")

        'Grand Total   
        decGrandTotal = decSubTotal + decTax
        lblGrandTotalCostBreakDown.Text = "$ " & decGrandTotal.ToString("F2")


    End Sub

    Private Sub ClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        'Clearing the whole form, Dropdowns are reset, txt/chkboxes are cleared

        lblCPUCost.Clear()
        cboCPUSelect.SelectedIndex = -1 'Set to -1 to clear dropdown, Would like a way to reset the text
        lblMonitorCost.Clear()
        cboMonitorSelect.SelectedIndex = -1 'Set to -1 to clear dropdown, Would like a way to reset the text

        'Clearing Breakdown Section

        lblCPUCostBreakDown.Clear()
        lblMonitorCostBreakDown.Clear()
        lblAddOnCostBreakDown.Clear()
        chkMaintanceOption.Checked = False 'Set Both to False to clear the CheckBoxes 
        chkWarrantyOption.Checked = False
        lblSubTotalCostBreakDown.Clear()
        lblTaxCostBreakDown.Clear()
        lblGrandTotalCostBreakDown.Clear()
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        'Closes the form
        Me.Close()
    End Sub


End Class
