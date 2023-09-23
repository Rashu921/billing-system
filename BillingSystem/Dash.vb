Public Class Dash

    Private Sub btndashcus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashcus.Click

        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub btndashorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashorder.Click

        Order.Show()
        Me.Hide()

    End Sub

    Private Sub btndashpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashpay.Click

        Pay.Show()
        Me.Hide()

    End Sub

    Private Sub btndashcal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashcal.Click

        Cal.Show()
        Me.Hide()

    End Sub

    Private Sub btndashcurr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashcurr.Click

        Cal.Show()
        Me.Hide()

    End Sub
End Class