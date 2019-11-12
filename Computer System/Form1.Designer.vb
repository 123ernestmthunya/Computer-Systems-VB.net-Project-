<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtSave = New System.Windows.Forms.Button()
        Me.txtClear = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SHOP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(40, 58)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(62, 12)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "Username :"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(42, 121)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(60, 12)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Password :"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(156, 58)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(144, 19)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(156, 118)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(144, 19)
        Me.txtpassword.TabIndex = 3
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(27, 193)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(75, 23)
        Me.txtSave.TabIndex = 4
        Me.txtSave.Text = "Save"
        Me.txtSave.UseVisualStyleBackColor = True
        '
        'txtClear
        '
        Me.txtClear.Location = New System.Drawing.Point(281, 193)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(75, 23)
        Me.txtClear.TabIndex = 5
        Me.txtClear.Text = "Clear"
        Me.txtClear.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(128, 14)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(126, 23)
        Me.lblWelcome.TabIndex = 6
        Me.lblWelcome.Text = "WELCOME"
        '
        'SHOP
        '
        Me.SHOP.AutoSize = True
        Me.SHOP.Location = New System.Drawing.Point(163, 181)
        Me.SHOP.Name = "SHOP"
        Me.SHOP.Size = New System.Drawing.Size(36, 12)
        Me.SHOP.TabIndex = 7
        Me.SHOP.Text = "SHOP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 280)
        Me.Controls.Add(Me.SHOP)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.txtClear)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblusername)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents lbl As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtSave As Button
    Friend WithEvents txtClear As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents SHOP As Label
End Class
