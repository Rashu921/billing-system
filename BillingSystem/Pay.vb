Public Class Pay

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        txtboxsubtot.Text = tot1 + tot2 + tot3 + tot4 + tot5

    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        Order.Show()
        Me.Hide()

    End Sub


    Private Sub btnpayreset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnpayreset.Click

        txtboxsubtot.Text = ""
        txtboxdis.Text = ""
        txtboxtot.Text = ""
        txtboxpay.Text = ""
        C.Text = ""

    End Sub

    Private Sub btnpaynew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnpaynew.Click

        RichTextBox1.Text = ""

    End Sub


    Private Sub btnpaytot_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaytot.Click

        Dim dis As Double
        Dim Subtot As Double

        Subtot = txtboxsubtot.Text

        dis = Subtot * 5 / 100

        txtboxdis.Text = dis

        txtboxtot.Text = Subtot - dis

    End Sub

    Private Sub btnpaybal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaybal.Click

        Dim tot As Double
        Dim res As Double

        tot = txtboxtot.Text
        res = txtboxpay.Text
        C.Text = res - tot

    End Sub

    Private Sub btnpaybill_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaybill.Click

        RichTextBox1.Clear()
        RichTextBox1.AppendText("                                                       " & vbNewLine)
        RichTextBox1.AppendText(vbTab & "     ARALIYA  RESTAURANT     " & vbTab & vbNewLine)
        RichTextBox1.AppendText(vbTab & "         Bank Side           " & vbTab & vbTab & vbNewLine)
        RichTextBox1.AppendText(vbTab & "        Anuradhapura         " & vbTab & vbTab & vbNewLine)

        RichTextBox1.AppendText("******************************************************" & vbNewLine & vbNewLine)

        RichTextBox1.AppendText(vbTab & "Rice" & vbTab & vbTab & tot1 & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Kottu" & vbTab & vbTab & tot2 & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Burger" & vbTab & vbTab & tot3 & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Drink" & vbTab & vbTab & tot4 & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Dessert" & vbTab & tot5 & vbNewLine)


        RichTextBox1.AppendText("******************************************************" & vbNewLine & vbNewLine)

        RichTextBox1.AppendText(vbTab & "SubTotal" & vbTab & vbTab & txtboxsubtot.Text & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Discount" & vbTab & vbTab & txtboxdis.Text & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Amount" & vbTab & vbTab & txtboxtot.Text & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Cash" & vbTab & vbTab & vbTab & txtboxpay.Text & vbNewLine)
        RichTextBox1.AppendText(vbTab & "Balance" & vbTab & vbTab & C.Text & vbNewLine)

        RichTextBox1.AppendText("******************************************************" & vbNewLine & vbNewLine)

        RichTextBox1.AppendText(vbTab & "Thank you For coming" & vbTab & vbTab & vbNewLine)
        RichTextBox1.AppendText(vbTab & "We Hope to see you again" & vbTab & vbTab & vbNewLine)

    End Sub

    Private Sub btnpaydash_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpaydash.Click

        Dash.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Cal.Show()
        Me.Hide()

    End Sub

End Class