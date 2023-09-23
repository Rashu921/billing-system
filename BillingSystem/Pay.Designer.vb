<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pay
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
        Me.lblsubtot = New System.Windows.Forms.Label()
        Me.txtboxsubtot = New System.Windows.Forms.TextBox()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lbldis = New System.Windows.Forms.Label()
        Me.txtboxpay = New System.Windows.Forms.TextBox()
        Me.txtboxtot = New System.Windows.Forms.TextBox()
        Me.txtboxdis = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnpaytot = New System.Windows.Forms.Button()
        Me.btnpaybal = New System.Windows.Forms.Button()
        Me.btnpayreset = New System.Windows.Forms.Button()
        Me.btnpaybill = New System.Windows.Forms.Button()
        Me.btnpaynew = New System.Windows.Forms.Button()
        Me.btnpaydash = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblsubtot
        '
        Me.lblsubtot.AutoSize = True
        Me.lblsubtot.BackColor = System.Drawing.Color.Thistle
        Me.lblsubtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtot.Location = New System.Drawing.Point(98, 114)
        Me.lblsubtot.Name = "lblsubtot"
        Me.lblsubtot.Size = New System.Drawing.Size(121, 32)
        Me.lblsubtot.TabIndex = 0
        Me.lblsubtot.Text = "Sub Tot"
        '
        'txtboxsubtot
        '
        Me.txtboxsubtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxsubtot.Location = New System.Drawing.Point(310, 105)
        Me.txtboxsubtot.Name = "txtboxsubtot"
        Me.txtboxsubtot.Size = New System.Drawing.Size(218, 41)
        Me.txtboxsubtot.TabIndex = 1
        Me.txtboxsubtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.BackColor = System.Drawing.Color.Thistle
        Me.lblpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpay.Location = New System.Drawing.Point(95, 363)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(149, 32)
        Me.lblpay.TabIndex = 2
        Me.lblpay.Text = "Payments"
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.BackColor = System.Drawing.Color.Thistle
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(98, 444)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(126, 32)
        Me.lblbalance.TabIndex = 3
        Me.lblbalance.Text = "Balance"
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.Color.Thistle
        Me.lbltot.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.Location = New System.Drawing.Point(82, 278)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(174, 32)
        Me.lbltot.TabIndex = 4
        Me.lbltot.Text = "Net Amount"
        '
        'lbldis
        '
        Me.lbldis.AutoSize = True
        Me.lbldis.BackColor = System.Drawing.Color.Thistle
        Me.lbldis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldis.Location = New System.Drawing.Point(95, 193)
        Me.lbldis.Name = "lbldis"
        Me.lbldis.Size = New System.Drawing.Size(134, 32)
        Me.lbldis.TabIndex = 5
        Me.lbldis.Text = "Discount"
        '
        'txtboxpay
        '
        Me.txtboxpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpay.Location = New System.Drawing.Point(310, 357)
        Me.txtboxpay.Name = "txtboxpay"
        Me.txtboxpay.Size = New System.Drawing.Size(218, 41)
        Me.txtboxpay.TabIndex = 6
        Me.txtboxpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxtot
        '
        Me.txtboxtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxtot.Location = New System.Drawing.Point(310, 269)
        Me.txtboxtot.Name = "txtboxtot"
        Me.txtboxtot.Size = New System.Drawing.Size(218, 41)
        Me.txtboxtot.TabIndex = 7
        Me.txtboxtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxdis
        '
        Me.txtboxdis.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxdis.Location = New System.Drawing.Point(310, 184)
        Me.txtboxdis.Name = "txtboxdis"
        Me.txtboxdis.Size = New System.Drawing.Size(218, 41)
        Me.txtboxdis.TabIndex = 8
        Me.txtboxdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(310, 444)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(218, 41)
        Me.C.TabIndex = 9
        Me.C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 44)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "SUB TOT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnpaytot
        '
        Me.btnpaytot.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpaytot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaytot.Location = New System.Drawing.Point(228, 573)
        Me.btnpaytot.Name = "btnpaytot"
        Me.btnpaytot.Size = New System.Drawing.Size(110, 44)
        Me.btnpaytot.TabIndex = 11
        Me.btnpaytot.Text = "TOT"
        Me.btnpaytot.UseVisualStyleBackColor = False
        '
        'btnpaybal
        '
        Me.btnpaybal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpaybal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaybal.Location = New System.Drawing.Point(375, 573)
        Me.btnpaybal.Name = "btnpaybal"
        Me.btnpaybal.Size = New System.Drawing.Size(111, 44)
        Me.btnpaybal.TabIndex = 12
        Me.btnpaybal.Text = "BAL"
        Me.btnpaybal.UseVisualStyleBackColor = False
        '
        'btnpayreset
        '
        Me.btnpayreset.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpayreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayreset.Location = New System.Drawing.Point(519, 573)
        Me.btnpayreset.Name = "btnpayreset"
        Me.btnpayreset.Size = New System.Drawing.Size(165, 44)
        Me.btnpayreset.TabIndex = 13
        Me.btnpayreset.Text = "RESET"
        Me.btnpayreset.UseVisualStyleBackColor = False
        '
        'btnpaybill
        '
        Me.btnpaybill.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaybill.Location = New System.Drawing.Point(1135, 84)
        Me.btnpaybill.Name = "btnpaybill"
        Me.btnpaybill.Size = New System.Drawing.Size(144, 44)
        Me.btnpaybill.TabIndex = 14
        Me.btnpaybill.Text = "BILL"
        Me.btnpaybill.UseVisualStyleBackColor = False
        '
        'btnpaynew
        '
        Me.btnpaynew.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpaynew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaynew.Location = New System.Drawing.Point(1135, 206)
        Me.btnpaynew.Name = "btnpaynew"
        Me.btnpaynew.Size = New System.Drawing.Size(144, 43)
        Me.btnpaynew.TabIndex = 15
        Me.btnpaynew.Text = "NEW"
        Me.btnpaynew.UseVisualStyleBackColor = False
        '
        'btnpaydash
        '
        Me.btnpaydash.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpaydash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaydash.Location = New System.Drawing.Point(1135, 334)
        Me.btnpaydash.Name = "btnpaydash"
        Me.btnpaydash.Size = New System.Drawing.Size(144, 39)
        Me.btnpaydash.TabIndex = 16
        Me.btnpaydash.Text = "DASH"
        Me.btnpaydash.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1135, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 43)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "PREV"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1135, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(710, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(377, 609)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = ""
        '
        'Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.BillingSystem.My.Resources.Resources._3f483410b8f2f1eb486efa7142deefc3__1_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1323, 733)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnpaydash)
        Me.Controls.Add(Me.btnpaynew)
        Me.Controls.Add(Me.btnpaybill)
        Me.Controls.Add(Me.btnpayreset)
        Me.Controls.Add(Me.btnpaybal)
        Me.Controls.Add(Me.btnpaytot)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.txtboxdis)
        Me.Controls.Add(Me.txtboxtot)
        Me.Controls.Add(Me.txtboxpay)
        Me.Controls.Add(Me.lbldis)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.txtboxsubtot)
        Me.Controls.Add(Me.lblsubtot)
        Me.Name = "Pay"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsubtot As System.Windows.Forms.Label
    Friend WithEvents txtboxsubtot As System.Windows.Forms.TextBox
    Friend WithEvents lblpay As System.Windows.Forms.Label
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents lbldis As System.Windows.Forms.Label
    Friend WithEvents txtboxpay As System.Windows.Forms.TextBox
    Friend WithEvents txtboxtot As System.Windows.Forms.TextBox
    Friend WithEvents txtboxdis As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnpaytot As System.Windows.Forms.Button
    Friend WithEvents btnpaybal As System.Windows.Forms.Button
    Friend WithEvents btnpayreset As System.Windows.Forms.Button
    Friend WithEvents btnpaybill As System.Windows.Forms.Button
    Friend WithEvents btnpaynew As System.Windows.Forms.Button
    Friend WithEvents btnpaydash As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
