<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.richboxcustomer = New System.Windows.Forms.RichTextBox()
        Me.lblcusdetails = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txtboxname = New System.Windows.Forms.TextBox()
        Me.txtboxphone = New System.Windows.Forms.TextBox()
        Me.txtboxaddress = New System.Windows.Forms.TextBox()
        Me.txtboxdate = New System.Windows.Forms.TextBox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncusdash = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richboxcustomer
        '
        Me.richboxcustomer.BackColor = System.Drawing.Color.Gainsboro
        Me.richboxcustomer.Location = New System.Drawing.Point(45, 39)
        Me.richboxcustomer.Name = "richboxcustomer"
        Me.richboxcustomer.Size = New System.Drawing.Size(1133, 96)
        Me.richboxcustomer.TabIndex = 0
        Me.richboxcustomer.Text = ""
        '
        'lblcusdetails
        '
        Me.lblcusdetails.AutoSize = True
        Me.lblcusdetails.BackColor = System.Drawing.Color.RosyBrown
        Me.lblcusdetails.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusdetails.Location = New System.Drawing.Point(90, 66)
        Me.lblcusdetails.Name = "lblcusdetails"
        Me.lblcusdetails.Size = New System.Drawing.Size(1015, 50)
        Me.lblcusdetails.TabIndex = 1
        Me.lblcusdetails.Text = "          C   U   S   T   O   M   E   R         D   E   T   A   I   L   S        " & _
            "  "
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Thistle
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(271, 179)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(96, 36)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.Color.Thistle
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(255, 264)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(133, 36)
        Me.lbladdress.TabIndex = 3
        Me.lbladdress.Text = "Address"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.BackColor = System.Drawing.Color.Thistle
        Me.lblphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.Location = New System.Drawing.Point(255, 355)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(107, 36)
        Me.lblphone.TabIndex = 4
        Me.lblphone.Text = "Phone"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Thistle
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(271, 444)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(80, 36)
        Me.lbldate.TabIndex = 5
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Thistle
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(271, 538)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(83, 36)
        Me.lbltime.TabIndex = 6
        Me.lbltime.Text = "Time"
        '
        'txtboxname
        '
        Me.txtboxname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxname.Location = New System.Drawing.Point(456, 179)
        Me.txtboxname.Name = "txtboxname"
        Me.txtboxname.Size = New System.Drawing.Size(503, 41)
        Me.txtboxname.TabIndex = 7
        Me.txtboxname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxphone
        '
        Me.txtboxphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxphone.Location = New System.Drawing.Point(456, 358)
        Me.txtboxphone.Name = "txtboxphone"
        Me.txtboxphone.Size = New System.Drawing.Size(503, 41)
        Me.txtboxphone.TabIndex = 8
        Me.txtboxphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxaddress
        '
        Me.txtboxaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxaddress.Location = New System.Drawing.Point(456, 264)
        Me.txtboxaddress.Name = "txtboxaddress"
        Me.txtboxaddress.Size = New System.Drawing.Size(503, 41)
        Me.txtboxaddress.TabIndex = 9
        Me.txtboxaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxdate
        '
        Me.txtboxdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxdate.Location = New System.Drawing.Point(456, 447)
        Me.txtboxdate.Name = "txtboxdate"
        Me.txtboxdate.Size = New System.Drawing.Size(503, 41)
        Me.txtboxdate.TabIndex = 10
        Me.txtboxdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttime
        '
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(456, 538)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(503, 41)
        Me.txttime.TabIndex = 11
        Me.txttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "P R E V"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btncusdash
        '
        Me.btncusdash.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btncusdash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncusdash.Location = New System.Drawing.Point(306, 641)
        Me.btncusdash.Name = "btncusdash"
        Me.btncusdash.Size = New System.Drawing.Size(139, 47)
        Me.btncusdash.TabIndex = 13
        Me.btncusdash.Text = "D A S H"
        Me.btncusdash.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(729, 641)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(160, 47)
        Me.btnreset.TabIndex = 14
        Me.btnreset.Text = "R E S E T"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(940, 641)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 47)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "N E X T"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(520, 641)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 47)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "S A V E"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.BillingSystem.My.Resources.Resources._3f483410b8f2f1eb486efa7142deefc3__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 733)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncusdash)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.txtboxdate)
        Me.Controls.Add(Me.txtboxaddress)
        Me.Controls.Add(Me.txtboxphone)
        Me.Controls.Add(Me.txtboxname)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblcusdetails)
        Me.Controls.Add(Me.richboxcustomer)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents richboxcustomer As System.Windows.Forms.RichTextBox
    Friend WithEvents lblcusdetails As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblphone As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents txtboxname As System.Windows.Forms.TextBox
    Friend WithEvents txtboxphone As System.Windows.Forms.TextBox
    Friend WithEvents txtboxaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtboxdate As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btncusdash As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
