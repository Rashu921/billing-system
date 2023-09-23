Imports System.Data.OleDb

Public Class Customer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dash.Show()
        Me.Hide()

    End Sub

    Private Sub btncusdash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncusdash.Click

        Dash.Show()
        Me.Hide()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click

        txtboxname.Text = ""
        txtboxaddress.Text = ""
        txtboxphone.Text = ""
        txtboxdate.Text = ""
        txttime.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Order.Show()
        Me.Hide()

    End Sub



    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        pro = " Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LAP MART\Desktop\RAD\BillingSystem\dbrad.mdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "Insert into Table1 ([Name],[Address],[Phone],[Date],[Time]) values ('" & txtboxname.Text & "', '" & txtboxaddress.Text & "' , '" & txtboxphone.Text & "', '" & txtboxdate.Text & "', '" & txttime.Text & "' )"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(txtboxname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtboxaddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone", CType(txtboxphone.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Date", CType(txtboxdate.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Time", CType(txttime.Text, String)))
        MsgBox("saved")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtboxname.Clear()
            txtboxaddress.Clear()
            txtboxphone.Clear()
            txtboxdate.Clear()
            txttime.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class