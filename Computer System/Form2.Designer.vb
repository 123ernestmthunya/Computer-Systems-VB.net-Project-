<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblHardDrive = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblGraphicCard = New System.Windows.Forms.Label()
        Me.cboProcessor = New System.Windows.Forms.ComboBox()
        Me.cboMotherboard = New System.Windows.Forms.ComboBox()
        Me.cboHarddrive = New System.Windows.Forms.ComboBox()
        Me.CboMemory = New System.Windows.Forms.ComboBox()
        Me.CboGraphics = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtProcessorPrice = New System.Windows.Forms.TextBox()
        Me.txtGraphicPrice = New System.Windows.Forms.TextBox()
        Me.txtMemoryPrice = New System.Windows.Forms.TextBox()
        Me.txtHardDrivePrice = New System.Windows.Forms.TextBox()
        Me.txtMotherboardPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LstComputerBoards = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMont = New System.Windows.Forms.Label()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.Vatlabel = New System.Windows.Forms.Label()
        Me.thetotallabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProcessor
        '
        Me.lblProcessor.AutoSize = True
        Me.lblProcessor.Location = New System.Drawing.Point(12, 26)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(56, 12)
        Me.lblProcessor.TabIndex = 0
        Me.lblProcessor.Text = "Processor"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 81)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(67, 12)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Motherboard"
        '
        'lblHardDrive
        '
        Me.lblHardDrive.AutoSize = True
        Me.lblHardDrive.Location = New System.Drawing.Point(12, 119)
        Me.lblHardDrive.Name = "lblHardDrive"
        Me.lblHardDrive.Size = New System.Drawing.Size(59, 12)
        Me.lblHardDrive.TabIndex = 2
        Me.lblHardDrive.Text = "Hard Drive"
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Location = New System.Drawing.Point(12, 160)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(45, 12)
        Me.lblMemory.TabIndex = 3
        Me.lblMemory.Text = "Memory"
        '
        'lblGraphicCard
        '
        Me.lblGraphicCard.AutoSize = True
        Me.lblGraphicCard.Location = New System.Drawing.Point(12, 198)
        Me.lblGraphicCard.Name = "lblGraphicCard"
        Me.lblGraphicCard.Size = New System.Drawing.Size(78, 12)
        Me.lblGraphicCard.TabIndex = 4
        Me.lblGraphicCard.Text = "Grapphic Card"
        '
        'cboProcessor
        '
        Me.cboProcessor.FormattingEnabled = True
        Me.cboProcessor.Location = New System.Drawing.Point(12, 58)
        Me.cboProcessor.Name = "cboProcessor"
        Me.cboProcessor.Size = New System.Drawing.Size(121, 20)
        Me.cboProcessor.TabIndex = 5
        '
        'cboMotherboard
        '
        Me.cboMotherboard.FormattingEnabled = True
        Me.cboMotherboard.Location = New System.Drawing.Point(14, 96)
        Me.cboMotherboard.Name = "cboMotherboard"
        Me.cboMotherboard.Size = New System.Drawing.Size(121, 20)
        Me.cboMotherboard.TabIndex = 6
        '
        'cboHarddrive
        '
        Me.cboHarddrive.FormattingEnabled = True
        Me.cboHarddrive.Location = New System.Drawing.Point(12, 134)
        Me.cboHarddrive.Name = "cboHarddrive"
        Me.cboHarddrive.Size = New System.Drawing.Size(121, 20)
        Me.cboHarddrive.TabIndex = 7
        '
        'CboMemory
        '
        Me.CboMemory.FormattingEnabled = True
        Me.CboMemory.Location = New System.Drawing.Point(12, 175)
        Me.CboMemory.Name = "CboMemory"
        Me.CboMemory.Size = New System.Drawing.Size(121, 20)
        Me.CboMemory.TabIndex = 8
        '
        'CboGraphics
        '
        Me.CboGraphics.FormattingEnabled = True
        Me.CboGraphics.Location = New System.Drawing.Point(14, 214)
        Me.CboGraphics.Name = "CboGraphics"
        Me.CboGraphics.Size = New System.Drawing.Size(121, 20)
        Me.CboGraphics.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(38, 288)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(140, 288)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(254, 288)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtProcessorPrice
        '
        Me.txtProcessorPrice.Location = New System.Drawing.Point(254, 59)
        Me.txtProcessorPrice.Name = "txtProcessorPrice"
        Me.txtProcessorPrice.Size = New System.Drawing.Size(100, 19)
        Me.txtProcessorPrice.TabIndex = 13
        '
        'txtGraphicPrice
        '
        Me.txtGraphicPrice.Location = New System.Drawing.Point(254, 214)
        Me.txtGraphicPrice.Name = "txtGraphicPrice"
        Me.txtGraphicPrice.Size = New System.Drawing.Size(100, 19)
        Me.txtGraphicPrice.TabIndex = 14
        '
        'txtMemoryPrice
        '
        Me.txtMemoryPrice.Location = New System.Drawing.Point(254, 176)
        Me.txtMemoryPrice.Name = "txtMemoryPrice"
        Me.txtMemoryPrice.Size = New System.Drawing.Size(100, 19)
        Me.txtMemoryPrice.TabIndex = 15
        '
        'txtHardDrivePrice
        '
        Me.txtHardDrivePrice.Location = New System.Drawing.Point(254, 135)
        Me.txtHardDrivePrice.Name = "txtHardDrivePrice"
        Me.txtHardDrivePrice.Size = New System.Drawing.Size(100, 19)
        Me.txtHardDrivePrice.TabIndex = 16
        '
        'txtMotherboardPrice
        '
        Me.txtMotherboardPrice.Location = New System.Drawing.Point(254, 97)
        Me.txtMotherboardPrice.Name = "txtMotherboardPrice"
        Me.txtMotherboardPrice.Size = New System.Drawing.Size(100, 19)
        Me.txtMotherboardPrice.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Price"
        '
        'LstComputerBoards
        '
        Me.LstComputerBoards.HideSelection = False
        Me.LstComputerBoards.Location = New System.Drawing.Point(446, 43)
        Me.LstComputerBoards.Name = "LstComputerBoards"
        Me.LstComputerBoards.Size = New System.Drawing.Size(228, 234)
        Me.LstComputerBoards.TabIndex = 24
        Me.LstComputerBoards.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 25
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(369, 43)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(0, 12)
        Me.lblAmount.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 12)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Label7"
        '
        'lblMont
        '
        Me.lblMont.AutoSize = True
        Me.lblMont.Location = New System.Drawing.Point(409, 58)
        Me.lblMont.Name = "lblMont"
        Me.lblMont.Size = New System.Drawing.Size(0, 12)
        Me.lblMont.TabIndex = 28
        '
        'amountLabel
        '
        Me.amountLabel.AutoSize = True
        Me.amountLabel.Location = New System.Drawing.Point(369, 161)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(0, 12)
        Me.amountLabel.TabIndex = 29
        '
        'discountLabel
        '
        Me.discountLabel.AutoSize = True
        Me.discountLabel.Location = New System.Drawing.Point(369, 247)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(0, 12)
        Me.discountLabel.TabIndex = 30
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Location = New System.Drawing.Point(369, 222)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(0, 12)
        Me.subtotalLabel.TabIndex = 31
        '
        'Vatlabel
        '
        Me.Vatlabel.AutoSize = True
        Me.Vatlabel.Location = New System.Drawing.Point(369, 183)
        Me.Vatlabel.Name = "Vatlabel"
        Me.Vatlabel.Size = New System.Drawing.Size(0, 12)
        Me.Vatlabel.TabIndex = 32
        '
        'thetotallabel
        '
        Me.thetotallabel.AutoSize = True
        Me.thetotallabel.Location = New System.Drawing.Point(369, 274)
        Me.thetotallabel.Name = "thetotallabel"
        Me.thetotallabel.Size = New System.Drawing.Size(12, 12)
        Me.thetotallabel.TabIndex = 33
        Me.thetotallabel.Text = "S"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.thetotallabel)
        Me.Controls.Add(Me.Vatlabel)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.amountLabel)
        Me.Controls.Add(Me.lblMont)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstComputerBoards)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMotherboardPrice)
        Me.Controls.Add(Me.txtHardDrivePrice)
        Me.Controls.Add(Me.txtMemoryPrice)
        Me.Controls.Add(Me.txtGraphicPrice)
        Me.Controls.Add(Me.txtProcessorPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.CboGraphics)
        Me.Controls.Add(Me.CboMemory)
        Me.Controls.Add(Me.cboHarddrive)
        Me.Controls.Add(Me.cboMotherboard)
        Me.Controls.Add(Me.cboProcessor)
        Me.Controls.Add(Me.lblGraphicCard)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.lblHardDrive)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblProcessor)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProcessor As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblHardDrive As Label
    Friend WithEvents lblMemory As Label
    Friend WithEvents lblGraphicCard As Label
    Friend WithEvents cboProcessor As ComboBox
    Friend WithEvents cboMotherboard As ComboBox
    Friend WithEvents cboHarddrive As ComboBox
    Friend WithEvents CboMemory As ComboBox
    Friend WithEvents CboGraphics As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtProcessorPrice As TextBox
    Friend WithEvents txtGraphicPrice As TextBox
    Friend WithEvents txtMemoryPrice As TextBox
    Friend WithEvents txtHardDrivePrice As TextBox
    Friend WithEvents txtMotherboardPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LstComputerBoards As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMont As Label
    Friend WithEvents amountLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents subtotalLabel As Label
    Friend WithEvents Vatlabel As Label
    Friend WithEvents thetotallabel As Label
End Class
