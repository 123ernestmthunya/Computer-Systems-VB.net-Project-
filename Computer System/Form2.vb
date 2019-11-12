Public Class Form2
    Private Sub CboProcessor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcessor.SelectedIndexChanged


        If cboProcessor.SelectedIndex = 0 Then

            txtProcessorPrice.SelectedText = "545"

        ElseIf cboProcessor.SelectedIndex = 1 Then

            txtProcessorPrice.Text = "140"

        ElseIf cboProcessor.SelectedIndex = 3 Then

            txtProcessorPrice.Text = "R136"

        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboProcessor.Items.Add("")
        cboProcessor.Items.Add("INTEL CELERON")
        cboProcessor.Items.Add("INTEL CORE 15")


        cboMotherboard.Items.Add("")
        cboMotherboard.Items.Add("LPX MOtherboard")
        cboMotherboard.Items.Add("PTX Motherboard")

        cboHarddrive.Items.Add("")
        cboHarddrive.Items.Add("SATA 250BG HARDDRIVE")
        cboHarddrive.Items.Add("LENOVO")

        CboMemory.Items.Add("")
        CboMemory.Items.Add("RAM")
        CboMemory.Items.Add("DRAM")

        CboGraphics.Items.Add("")
        CboGraphics.Items.Add("AGP")
        CboGraphics.Items.Add("PCI EXPRESS")
    End Sub

    Private Sub CboMotherboard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMotherboard.SelectedIndexChanged

        If cboMotherboard.SelectedIndex = 0 Then

            txtMotherboardPrice.SelectedText = "668"

        ElseIf cboMotherboard.SelectedIndex = 1 Then

            txtMotherboardPrice.Text = "556"

        ElseIf cboMotherboard.SelectedIndex = 3 Then

            txtMotherboardPrice.Text = "5656"

        End If
    End Sub

    Private Sub CboHarddrive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHarddrive.SelectedIndexChanged
        If cboHarddrive.SelectedIndex = 0 Then

            txtHardDrivePrice.SelectedText = "665"

        ElseIf cboHarddrive.SelectedIndex = 1 Then

            txtHardDrivePrice.Text = "777"

        ElseIf cboHarddrive.SelectedIndex = 3 Then

            txtHardDrivePrice.Text = "R155.24"

        End If
    End Sub

    Private Sub CboMemory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMemory.SelectedIndexChanged
        If CboMemory.SelectedIndex = 0 Then

            txtMemoryPrice.SelectedText = "656"

        ElseIf CboMemory.SelectedIndex = 1 Then

            txtMemoryPrice.Text = "3340"

        ElseIf CboMemory.SelectedIndex = 3 Then

            txtMemoryPrice.Text = "535"

        End If
    End Sub

    Private Sub CboGraphics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGraphics.SelectedIndexChanged
        If CboGraphics.SelectedIndex = 0 Then

            txtGraphicPrice.SelectedText = "767"

        ElseIf CboGraphics.SelectedIndex = 1 Then

            txtGraphicPrice.Text = "555"

        ElseIf CboGraphics.SelectedIndex = 3 Then

            txtGraphicPrice.Text = "123"

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGraphicPrice.Clear()
        txtMemoryPrice.Clear()
        txtMotherboardPrice.Clear()
        txtProcessorPrice.Clear()
        txtHardDrivePrice.Clear()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        Dim G As Integer = Convert.ToUInt64(txtGraphicPrice.Text)
        Dim M As Integer = Convert.ToUInt64(txtMemoryPrice.Text)
        Dim MB As Integer = Convert.ToUInt64(txtMotherboardPrice.Text)
        Dim P As Integer = Convert.ToUInt64(txtProcessorPrice.Text)
        Dim D As Integer = Convert.ToUInt64(txtHardDrivePrice.Text)

        Dim Amount As Integer = (G + M + MB + P + D)
        amountLabel.Text = "Amount : R" + Amount.ToString

        Dim VAT As Integer = (Amount * (14 / 100))
        'calculating VAT
        Vatlabel.Text = "VAT :R" & VAT.ToString


        Dim Subtoatl As Integer = (Amount + VAT)


        subtotalLabel.Text = "Sub Total : R" & Subtoatl



        Dim fivePecent As Integer = (Amount * 5 / 100)
        Dim tenPercent As Integer = (Amount * 10 / 100)
        Dim twentyPercent As Integer = (Amount * 20 / 100)


        If Amount > 15000 Then
            discountLabel.Text = "Discout : R " & fivePecent

            thetotallabel.Text = "The Total : R" + (Subtoatl - fivePecent).ToString

        ElseIf Amount > 2000 Then
            discountLabel.Text = "Discount : R" & tenPercent

            thetotallabel.Text = "The Total : R" + (Subtoatl - tenPercent).ToString

        ElseIf Amount > 2500 Then

            discountLabel.Text = "Discount : R" & twentyPercent

            thetotallabel.Text = "The Total : R" + (Subtoatl - twentyPercent).ToString
        End If

        Dim Productslist As New List(Of String)



        LstComputerBoards.Items.Add(cboProcessor.SelectedItem & "R " & txtProcessorPrice.Text)
        LstComputerBoards.Items.Add("")
        LstComputerBoards.Items.Add(CboGraphics.SelectedItem & "R" & txtGraphicPrice.Text)
        LstComputerBoards.Items.Add("")
        LstComputerBoards.Items.Add(cboHarddrive.SelectedItem & "R " & txtHardDrivePrice.Text)
        LstComputerBoards.Items.Add("")
        LstComputerBoards.Items.Add(CboMemory.SelectedItem & "R " & txtMemoryPrice.Text)
        LstComputerBoards.Items.Add("")
        LstComputerBoards.Items.Add(cboMotherboard.SelectedItem & " R " & txtMotherboardPrice.Text)


    End Sub

    Private Sub LstComputerBoards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstComputerBoards.SelectedIndexChanged


    End Sub
End Class