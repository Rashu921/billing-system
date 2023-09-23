<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash
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
        Me.dashrichone = New System.Windows.Forms.RichTextBox()
        Me.lbldash = New System.Windows.Forms.Label()
        Me.btndashcus = New System.Windows.Forms.Button()
        Me.btndashorder = New System.Windows.Forms.Button()
        Me.btndashpay = New System.Windows.Forms.Button()
        Me.btndashcal = New System.Windows.Forms.Button()
        Me.btndashcurr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dashrichone
        '
        Me.dashrichone.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dashrichone.Location = New System.Drawing.Point(42, 37)
        Me.dashrichone.Name = "dashrichone"
        Me.dashrichone.Size = New System.Drawing.Size(1123, 110)
        Me.dashrichone.TabIndex = 0
        Me.dashrichone.Text = ""
        '
        'lbldash
        '
        Me.lbldash.AutoSize = True
        Me.lbldash.BackColor = System.Drawing.Color.Thistle
        Me.lbldash.Font = New System.Drawing.Font("Showcard Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldash.Location = New System.Drawing.Point(108, 66)
        Me.lbldash.Name = "lbldash"
        Me.lbldash.Size = New System.Drawing.Size(933, 60)
        Me.lbldash.TabIndex = 2
        Me.lbldash.Text = "            D     A     S     B     O     A     R     D            "
        '
        'btndashcus
        '
        Me.btndashcus.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btndashcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashcus.Location = New System.Drawing.Point(289, 195)
        Me.btndashcus.Name = "btndashcus"
        Me.btndashcus.Size = New System.Drawing.Size(675, 57)
        Me.btndashcus.TabIndex = 3
        Me.btndashcus.Text = "Customer"
        Me.btndashcus.UseVisualStyleBackColor = False
        '
        'btndashorder
        '
        Me.btndashorder.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btndashorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashorder.Location = New System.Drawing.Point(289, 282)
        Me.btndashorder.Name = "btndashorder"
        Me.btndashorder.Size = New System.Drawing.Size(675, 57)
        Me.btndashorder.TabIndex = 4
        Me.btndashorder.Text = "Order"
        Me.btndashorder.UseVisualStyleBackColor = False
        '
        'btndashpay
        '
        Me.btndashpay.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btndashpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashpay.Location = New System.Drawing.Point(289, 384)
        Me.btndashpay.Name = "btndashpay"
        Me.btndashpay.Size = New System.Drawing.Size(675, 57)
        Me.btndashpay.TabIndex = 5
        Me.btndashpay.Text = "Payments"
        Me.btndashpay.UseVisualStyleBackColor = False
        '
        'btndashcal
        '
        Me.btndashcal.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btndashcal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashcal.Location = New System.Drawing.Point(289, 481)
        Me.btndashcal.Name = "btndashcal"
        Me.btndashcal.Size = New System.Drawing.Size(675, 57)
        Me.btndashcal.TabIndex = 6
        Me.btndashcal.Text = "Calculator"
        Me.btndashcal.UseVisualStyleBackColor = False
        '
        'btndashcurr
        '
        Me.btndashcurr.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btndashcurr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashcurr.Location = New System.Drawing.Point(289, 582)
        Me.btndashcurr.Name = "btndashcurr"
        Me.btndashcurr.Size = New System.Drawing.Size(675, 57)
        Me.btndashcurr.TabIndex = 7
        Me.btndashcurr.Text = "Currency Converter"
        Me.btndashcurr.UseVisualStyleBackColor = False
        '
        'Dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.BillingSystem.My.Resources.Resources.Gourmet_Black_And_White_Sketch_Blackboard_Drawing_Background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1198, 751)
        Me.Controls.Add(Me.btndashcurr)
        Me.Controls.Add(Me.btndashcal)
        Me.Controls.Add(Me.btndashpay)
        Me.Controls.Add(Me.btndashorder)
        Me.Controls.Add(Me.btndashcus)
        Me.Controls.Add(Me.lbldash)
        Me.Controls.Add(Me.dashrichone)
        Me.Name = "Dash"
        Me.Text = "Dash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dashrichone As System.Windows.Forms.RichTextBox
    Friend WithEvents lbldash As System.Windows.Forms.Label
    Friend WithEvents btndashcus As System.Windows.Forms.Button
    Friend WithEvents btndashorder As System.Windows.Forms.Button
    Friend WithEvents btndashpay As System.Windows.Forms.Button
    Friend WithEvents btndashcal As System.Windows.Forms.Button
    Friend WithEvents btndashcurr As System.Windows.Forms.Button
End Class
