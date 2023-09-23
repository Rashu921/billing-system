Public Class Login

    Private Sub btblogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btblogin.Click

        Dim username As String
        Dim password As String

        username = txtloginuser.Text
        password = txtloginpw.Text

        If username.Equals("admin") And password.Equals("admin") Then
            MsgBox("Login Successful")
            Dash.Show()
            Me.Hide()
        Else
            MsgBox("Try Again")

        End If

    End Sub
End Class