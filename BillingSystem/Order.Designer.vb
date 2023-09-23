<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Me.lblrice = New System.Windows.Forms.Label()
        Me.updwnrice = New System.Windows.Forms.NumericUpDown()
        Me.comboxrice = New System.Windows.Forms.ComboBox()
        Me.txtboxrice = New System.Windows.Forms.TextBox()
        Me.lblkottu = New System.Windows.Forms.Label()
        Me.lblpizza = New System.Windows.Forms.Label()
        Me.lbldrinks = New System.Windows.Forms.Label()
        Me.lbldessert = New System.Windows.Forms.Label()
        Me.comboxdess = New System.Windows.Forms.ComboBox()
        Me.comboxdrinks = New System.Windows.Forms.ComboBox()
        Me.comboxburgur = New System.Windows.Forms.ComboBox()
        Me.comboxkottu = New System.Windows.Forms.ComboBox()
        Me.updwnpizza = New System.Windows.Forms.NumericUpDown()
        Me.updwnkottu = New System.Windows.Forms.NumericUpDown()
        Me.updwndrinks = New System.Windows.Forms.NumericUpDown()
        Me.updwndess = New System.Windows.Forms.NumericUpDown()
        Me.txtboxdrinks = New System.Windows.Forms.TextBox()
        Me.txtboxpizza = New System.Windows.Forms.TextBox()
        Me.txtboxkottu = New System.Windows.Forms.TextBox()
        Me.txtboxdess = New System.Windows.Forms.TextBox()
        Me.btnorderadd = New System.Windows.Forms.Button()
        Me.btnorderreset = New System.Windows.Forms.Button()
        Me.btnorderdash = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnordernext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtordersubtot = New System.Windows.Forms.TextBox()
        CType(Me.updwnrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnpizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnkottu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwndrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwndess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblrice
        '
        Me.lblrice.AutoSize = True
        Me.lblrice.BackColor = System.Drawing.Color.Thistle
        Me.lblrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrice.Location = New System.Drawing.Point(95, 110)
        Me.lblrice.Name = "lblrice"
        Me.lblrice.Size = New System.Drawing.Size(76, 32)
        Me.lblrice.TabIndex = 0
        Me.lblrice.Text = "Rice"
        '
        'updwnrice
        '
        Me.updwnrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updwnrice.Location = New System.Drawing.Point(532, 105)
        Me.updwnrice.Name = "updwnrice"
        Me.updwnrice.Size = New System.Drawing.Size(97, 34)
        Me.updwnrice.TabIndex = 1
        Me.updwnrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comboxrice
        '
        Me.comboxrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxrice.FormattingEnabled = True
        Me.comboxrice.Location = New System.Drawing.Point(241, 104)
        Me.comboxrice.Name = "comboxrice"
        Me.comboxrice.Size = New System.Drawing.Size(221, 37)
        Me.comboxrice.TabIndex = 2
        '
        'txtboxrice
        '
        Me.txtboxrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxrice.Location = New System.Drawing.Point(699, 108)
        Me.txtboxrice.Name = "txtboxrice"
        Me.txtboxrice.Size = New System.Drawing.Size(223, 34)
        Me.txtboxrice.TabIndex = 3
        Me.txtboxrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblkottu
        '
        Me.lblkottu.AutoSize = True
        Me.lblkottu.BackColor = System.Drawing.Color.Thistle
        Me.lblkottu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkottu.Location = New System.Drawing.Point(95, 208)
        Me.lblkottu.Name = "lblkottu"
        Me.lblkottu.Size = New System.Drawing.Size(87, 32)
        Me.lblkottu.TabIndex = 4
        Me.lblkottu.Text = "Kottu"
        '
        'lblpizza
        '
        Me.lblpizza.AutoSize = True
        Me.lblpizza.BackColor = System.Drawing.Color.Thistle
        Me.lblpizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpizza.Location = New System.Drawing.Point(95, 313)
        Me.lblpizza.Name = "lblpizza"
        Me.lblpizza.Size = New System.Drawing.Size(90, 32)
        Me.lblpizza.TabIndex = 5
        Me.lblpizza.Text = "Pizza"
        '
        'lbldrinks
        '
        Me.lbldrinks.AutoSize = True
        Me.lbldrinks.BackColor = System.Drawing.Color.Thistle
        Me.lbldrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrinks.Location = New System.Drawing.Point(95, 419)
        Me.lbldrinks.Name = "lbldrinks"
        Me.lbldrinks.Size = New System.Drawing.Size(101, 32)
        Me.lbldrinks.TabIndex = 6
        Me.lbldrinks.Text = "Drinks"
        '
        'lbldessert
        '
        Me.lbldessert.AutoSize = True
        Me.lbldessert.BackColor = System.Drawing.Color.Thistle
        Me.lbldessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldessert.Location = New System.Drawing.Point(86, 523)
        Me.lbldessert.Name = "lbldessert"
        Me.lbldessert.Size = New System.Drawing.Size(119, 32)
        Me.lbldessert.TabIndex = 7
        Me.lbldessert.Text = "Dessert"
        '
        'comboxdess
        '
        Me.comboxdess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxdess.FormattingEnabled = True
        Me.comboxdess.Location = New System.Drawing.Point(241, 520)
        Me.comboxdess.Name = "comboxdess"
        Me.comboxdess.Size = New System.Drawing.Size(221, 37)
        Me.comboxdess.TabIndex = 8
        '
        'comboxdrinks
        '
        Me.comboxdrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxdrinks.FormattingEnabled = True
        Me.comboxdrinks.Location = New System.Drawing.Point(241, 414)
        Me.comboxdrinks.Name = "comboxdrinks"
        Me.comboxdrinks.Size = New System.Drawing.Size(221, 37)
        Me.comboxdrinks.TabIndex = 9
        '
        'comboxburgur
        '
        Me.comboxburgur.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxburgur.FormattingEnabled = True
        Me.comboxburgur.Location = New System.Drawing.Point(241, 308)
        Me.comboxburgur.Name = "comboxburgur"
        Me.comboxburgur.Size = New System.Drawing.Size(221, 37)
        Me.comboxburgur.TabIndex = 10
        '
        'comboxkottu
        '
        Me.comboxkottu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxkottu.FormattingEnabled = True
        Me.comboxkottu.Location = New System.Drawing.Point(241, 200)
        Me.comboxkottu.Name = "comboxkottu"
        Me.comboxkottu.Size = New System.Drawing.Size(221, 37)
        Me.comboxkottu.TabIndex = 11
        '
        'updwnpizza
        '
        Me.updwnpizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updwnpizza.Location = New System.Drawing.Point(532, 308)
        Me.updwnpizza.Name = "updwnpizza"
        Me.updwnpizza.Size = New System.Drawing.Size(97, 34)
        Me.updwnpizza.TabIndex = 12
        Me.updwnpizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updwnkottu
        '
        Me.updwnkottu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updwnkottu.Location = New System.Drawing.Point(532, 201)
        Me.updwnkottu.Name = "updwnkottu"
        Me.updwnkottu.Size = New System.Drawing.Size(97, 34)
        Me.updwnkottu.TabIndex = 13
        Me.updwnkottu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updwndrinks
        '
        Me.updwndrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updwndrinks.Location = New System.Drawing.Point(532, 409)
        Me.updwndrinks.Name = "updwndrinks"
        Me.updwndrinks.Size = New System.Drawing.Size(97, 30)
        Me.updwndrinks.TabIndex = 14
        Me.updwndrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updwndess
        '
        Me.updwndess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updwndess.Location = New System.Drawing.Point(532, 521)
        Me.updwndess.Name = "updwndess"
        Me.updwndess.Size = New System.Drawing.Size(97, 34)
        Me.updwndess.TabIndex = 15
        Me.updwndess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxdrinks
        '
        Me.txtboxdrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxdrinks.Location = New System.Drawing.Point(699, 409)
        Me.txtboxdrinks.Name = "txtboxdrinks"
        Me.txtboxdrinks.Size = New System.Drawing.Size(223, 34)
        Me.txtboxdrinks.TabIndex = 16
        Me.txtboxdrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxpizza
        '
        Me.txtboxpizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpizza.Location = New System.Drawing.Point(699, 303)
        Me.txtboxpizza.Name = "txtboxpizza"
        Me.txtboxpizza.Size = New System.Drawing.Size(223, 34)
        Me.txtboxpizza.TabIndex = 17
        Me.txtboxpizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxkottu
        '
        Me.txtboxkottu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxkottu.Location = New System.Drawing.Point(699, 200)
        Me.txtboxkottu.Name = "txtboxkottu"
        Me.txtboxkottu.Size = New System.Drawing.Size(223, 34)
        Me.txtboxkottu.TabIndex = 18
        Me.txtboxkottu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxdess
        '
        Me.txtboxdess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxdess.Location = New System.Drawing.Point(699, 517)
        Me.txtboxdess.Name = "txtboxdess"
        Me.txtboxdess.Size = New System.Drawing.Size(223, 34)
        Me.txtboxdess.TabIndex = 19
        Me.txtboxdess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnorderadd
        '
        Me.btnorderadd.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnorderadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderadd.Location = New System.Drawing.Point(990, 108)
        Me.btnorderadd.Name = "btnorderadd"
        Me.btnorderadd.Size = New System.Drawing.Size(161, 54)
        Me.btnorderadd.TabIndex = 20
        Me.btnorderadd.Text = "ADD"
        Me.btnorderadd.UseVisualStyleBackColor = False
        '
        'btnorderreset
        '
        Me.btnorderreset.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnorderreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderreset.Location = New System.Drawing.Point(989, 194)
        Me.btnorderreset.Name = "btnorderreset"
        Me.btnorderreset.Size = New System.Drawing.Size(162, 47)
        Me.btnorderreset.TabIndex = 21
        Me.btnorderreset.Text = "RESET"
        Me.btnorderreset.UseVisualStyleBackColor = False
        '
        'btnorderdash
        '
        Me.btnorderdash.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnorderdash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorderdash.Location = New System.Drawing.Point(989, 295)
        Me.btnorderdash.Name = "btnorderdash"
        Me.btnorderdash.Size = New System.Drawing.Size(162, 50)
        Me.btnorderdash.TabIndex = 22
        Me.btnorderdash.Text = "DASH"
        Me.btnorderdash.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(989, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 52)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "PREV"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnordernext
        '
        Me.btnordernext.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnordernext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnordernext.Location = New System.Drawing.Point(989, 515)
        Me.btnordernext.Name = "btnordernext"
        Me.btnordernext.Size = New System.Drawing.Size(162, 51)
        Me.btnordernext.TabIndex = 24
        Me.btnordernext.Text = "NEXT"
        Me.btnordernext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 614)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "SubTotal"
        '
        'txtordersubtot
        '
        Me.txtordersubtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtordersubtot.Location = New System.Drawing.Point(599, 612)
        Me.txtordersubtot.Name = "txtordersubtot"
        Me.txtordersubtot.Size = New System.Drawing.Size(298, 34)
        Me.txtordersubtot.TabIndex = 26
        Me.txtordersubtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.BillingSystem.My.Resources.Resources._3f483410b8f2f1eb486efa7142deefc3__1_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1257, 744)
        Me.Controls.Add(Me.txtordersubtot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnordernext)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnorderdash)
        Me.Controls.Add(Me.btnorderreset)
        Me.Controls.Add(Me.btnorderadd)
        Me.Controls.Add(Me.txtboxdess)
        Me.Controls.Add(Me.txtboxkottu)
        Me.Controls.Add(Me.txtboxpizza)
        Me.Controls.Add(Me.txtboxdrinks)
        Me.Controls.Add(Me.updwndess)
        Me.Controls.Add(Me.updwndrinks)
        Me.Controls.Add(Me.updwnkottu)
        Me.Controls.Add(Me.updwnpizza)
        Me.Controls.Add(Me.comboxkottu)
        Me.Controls.Add(Me.comboxburgur)
        Me.Controls.Add(Me.comboxdrinks)
        Me.Controls.Add(Me.comboxdess)
        Me.Controls.Add(Me.lbldessert)
        Me.Controls.Add(Me.lbldrinks)
        Me.Controls.Add(Me.lblpizza)
        Me.Controls.Add(Me.lblkottu)
        Me.Controls.Add(Me.txtboxrice)
        Me.Controls.Add(Me.comboxrice)
        Me.Controls.Add(Me.updwnrice)
        Me.Controls.Add(Me.lblrice)
        Me.Name = "Order"
        Me.Text = "Order"
        CType(Me.updwnrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnpizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnkottu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwndrinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwndess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblrice As System.Windows.Forms.Label
    Friend WithEvents updwnrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents comboxrice As System.Windows.Forms.ComboBox
    Friend WithEvents txtboxrice As System.Windows.Forms.TextBox
    Friend WithEvents lblkottu As System.Windows.Forms.Label
    Friend WithEvents lblpizza As System.Windows.Forms.Label
    Friend WithEvents lbldrinks As System.Windows.Forms.Label
    Friend WithEvents lbldessert As System.Windows.Forms.Label
    Friend WithEvents comboxdess As System.Windows.Forms.ComboBox
    Friend WithEvents comboxdrinks As System.Windows.Forms.ComboBox
    Friend WithEvents comboxburgur As System.Windows.Forms.ComboBox
    Friend WithEvents comboxkottu As System.Windows.Forms.ComboBox
    Friend WithEvents updwnpizza As System.Windows.Forms.NumericUpDown
    Friend WithEvents updwnkottu As System.Windows.Forms.NumericUpDown
    Friend WithEvents updwndrinks As System.Windows.Forms.NumericUpDown
    Friend WithEvents updwndess As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtboxdrinks As System.Windows.Forms.TextBox
    Friend WithEvents txtboxpizza As System.Windows.Forms.TextBox
    Friend WithEvents txtboxkottu As System.Windows.Forms.TextBox
    Friend WithEvents txtboxdess As System.Windows.Forms.TextBox
    Friend WithEvents btnorderadd As System.Windows.Forms.Button
    Friend WithEvents btnorderreset As System.Windows.Forms.Button
    Friend WithEvents btnorderdash As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnordernext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtordersubtot As System.Windows.Forms.TextBox
End Class
