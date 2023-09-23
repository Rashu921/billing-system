<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblloginuser = New System.Windows.Forms.Label()
        Me.lblloginpw = New System.Windows.Forms.Label()
        Me.btblogin = New System.Windows.Forms.Button()
        Me.txtloginuser = New System.Windows.Forms.TextBox()
        Me.txtloginpw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblloginuser
        '
        Me.lblloginuser.AutoSize = True
        Me.lblloginuser.BackColor = System.Drawing.Color.Thistle
        Me.lblloginuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloginuser.Location = New System.Drawing.Point(240, 261)
        Me.lblloginuser.Name = "lblloginuser"
        Me.lblloginuser.Size = New System.Drawing.Size(277, 55)
        Me.lblloginuser.TabIndex = 0
        Me.lblloginuser.Text = "User Name"
        '
        'lblloginpw
        '
        Me.lblloginpw.AutoSize = True
        Me.lblloginpw.BackColor = System.Drawing.Color.Thistle
        Me.lblloginpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloginpw.Location = New System.Drawing.Point(255, 398)
        Me.lblloginpw.Name = "lblloginpw"
        Me.lblloginpw.Size = New System.Drawing.Size(244, 55)
        Me.lblloginpw.TabIndex = 1
        Me.lblloginpw.Text = "Password"
        '
        'btblogin
        '
        Me.btblogin.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btblogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btblogin.Location = New System.Drawing.Point(437, 491)
        Me.btblogin.Name = "btblogin"
        Me.btblogin.Size = New System.Drawing.Size(246, 87)
        Me.btblogin.TabIndex = 2
        Me.btblogin.Text = "Login"
        Me.btblogin.UseVisualStyleBackColor = False
        '
        'txtloginuser
        '
        Me.txtloginuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginuser.Location = New System.Drawing.Point(566, 260)
        Me.txtloginuser.Name = "txtloginuser"
        Me.txtloginuser.Size = New System.Drawing.Size(360, 56)
        Me.txtloginuser.TabIndex = 3
        Me.txtloginuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtloginpw
        '
        Me.txtloginpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginpw.Location = New System.Drawing.Point(566, 397)
        Me.txtloginpw.Name = "txtloginpw"
        Me.txtloginpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtloginpw.Size = New System.Drawing.Size(360, 56)
        Me.txtloginpw.TabIndex = 4
        Me.txtloginpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.BillingSystem.My.Resources.Resources.Gourmet_Hand_Painted_Menu_Recipes_Baked_Baguette_Bread_Cake_Poster_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1167, 750)
        Me.Controls.Add(Me.txtloginpw)
        Me.Controls.Add(Me.txtloginuser)
        Me.Controls.Add(Me.btblogin)
        Me.Controls.Add(Me.lblloginpw)
        Me.Controls.Add(Me.lblloginuser)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblloginuser As System.Windows.Forms.Label
    Friend WithEvents lblloginpw As System.Windows.Forms.Label
    Friend WithEvents btblogin As System.Windows.Forms.Button
    Friend WithEvents txtloginuser As System.Windows.Forms.TextBox
    Friend WithEvents txtloginpw As System.Windows.Forms.TextBox
End Class
