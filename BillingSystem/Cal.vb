Public Class Cal

    Dim Fnum As Decimal
    Dim Snum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False

   Private Sub btncalone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalone.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "1"
        Else
            txtboxcal.Text = "1"
        End If

    End Sub

    Private Sub btncaltwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaltwo.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "2"
        Else
            txtboxcal.Text = "2"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalthree.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "3"
        Else
            txtboxcal.Text = "3"
        End If

    End Sub

    Private Sub btncalfour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalfour.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "4"
        Else
            txtboxcal.Text = "4"
        End If

    End Sub

    Private Sub btncalfive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalfive.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "5"
        Else
            txtboxcal.Text = "5"
        End If

    End Sub

    Private Sub btncalsix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalsix.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "6"
        Else
            txtboxcal.Text = "6"
        End If

    End Sub

    Private Sub btncalseven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalseven.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "7"
        Else
            txtboxcal.Text = "7"
        End If

    End Sub

    Private Sub btncaleight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaleight.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "8"
        Else
            txtboxcal.Text = "8"
        End If

    End Sub

    Private Sub btncalnine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalnine.Click

        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "9"
        Else
            txtboxcal.Text = "9"
        End If

    End Sub

    Private Sub btncalzero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalzero.Click
        If txtboxcal.Text <> "0" Then
            txtboxcal.Text += "0"
        End If
    End Sub

    Private Sub btncaldot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaldot.Click

        If Not (txtboxcal.Text.Contains(".")) Then
            txtboxcal.Text += "."
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        txtboxcal.Text = "0"

    End Sub

    Private Sub btncaladd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaladd.Click

        Fnum = txtboxcal.Text
        txtboxcal.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +

    End Sub

    Private Sub btncalmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalmin.Click

        Fnum = txtboxcal.Text
        txtboxcal.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -

    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click

        Fnum = txtboxcal.Text
        txtboxcal.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *

    End Sub

    Private Sub btncaldiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaldiv.Click

        Fnum = txtboxcal.Text
        txtboxcal.Text = "0"
        Operator_Selector = True
        Operations = 4 ' = /

    End Sub

    Private Sub btncalspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalspace.Click

        If Operator_Selector = True Then
            Snum = txtboxcal.Text
            If Operations = 1 Then
                txtboxcal.Text = Fnum + Snum
            ElseIf Operations = 2 Then
                txtboxcal.Text = Fnum - Snum
            ElseIf Operations = 3 Then
                txtboxcal.Text = Fnum * Snum
            Else
                If Snum = 0 Then
                    txtboxcal.Text = "Error"
                Else
                    txtboxcal.Text = Fnum / Snum
                End If
            End If
            Operator_Selector = False
        End If
    End Sub

   Private Sub tabpagecurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpagecurrency.Click

    End Sub

    Dim Indian_rupee As Double = 0.22
    Dim American_usd As Double = 0.0027
    Dim British_pound As Double = 0.0023
    Dim Australlian_dollor As Double = 0.004
    Dim Japan_yen As Double = 0.38
    Dim Korean_won As Double = 3.64
    Dim Russian_ruble As Double = 0.16
    Dim Euro As Double = 0.0026

    Function CuConverter(ByVal money As Double) As Double

        If ComboBox1.Text = "USA" Then
            Return Math.Round(American_usd * money, 2)
        ElseIf ComboBox1.Text = "UK" Then
            Return Math.Round(British_pound * money, 2)
        ElseIf ComboBox1.Text = "India" Then
            Return Math.Round(Indian_rupee * money, 2)
        ElseIf ComboBox1.Text = "Australia" Then
            Return Math.Round(Australlian_dollor * money, 2)
        ElseIf ComboBox1.Text = "Russia" Then
            Return Math.Round(Russian_ruble * money, 2)
        ElseIf ComboBox1.Text = "France" Then
            Return Math.Round(Euro * money, 2)
        ElseIf ComboBox1.Text = "Japan" Then
            Return Math.Round(Japan_yen * money, 2)
        ElseIf ComboBox1.Text = "Korea" Then
            Return Math.Round(Korean_won * money, 2)
        End If
    End Function

    Private Sub Cal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox1.Text = "Choose One"
        ComboBox1.Items.Add("USA")
        ComboBox1.Items.Add("UK")
        ComboBox1.Items.Add("India")
        ComboBox1.Items.Add("Australia")
        ComboBox1.Items.Add("Russia")
        ComboBox1.Items.Add("France")
        ComboBox1.Items.Add("Japan")
        ComboBox1.Items.Add("Korea")

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Srilankan_rupee As Double = CDbl(txtboxslrupee.Text)
        txtboxforiegn.Text = CStr(CuConverter(Srilankan_rupee))
        If ComboBox1.Text = "USA" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "UK" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "India" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "Australia" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "Russia" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "France" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "Japan" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf ComboBox1.Text = "Korea" Then
            txtboxforiegn.Text = Val(txtboxforiegn.Text)
        ElseIf txtboxforiegn.Text = "Choose One" Then
            MsgBox("Select a Country", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ComboBox1.Text = "Choose One"
        txtboxslrupee.Text = ""
        txtboxforiegn.Text = ""

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Pay.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dash.Show()
        Me.Hide()

    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click

        Me.Close()

    End Sub

End Class