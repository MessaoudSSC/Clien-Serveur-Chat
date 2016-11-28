Imports Oracle.DataAccess.Client

Public Class change
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles newpass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom As String
        Dim old As String
        cn.Open()

        old = SingnUp.pass.Text

        nom = SingnUp.nom.Text


        Dim cmd As New OracleCommand()
        cmd = New OracleCommand()

        Dim cs As String = "data source =xe ; user id=system ; password=1386313863 ;"
        Dim cn As New OracleConnection(cs)
        cn.Open()
        cmd.CommandText = "update SINGUP set password='" & newpass.Text & "' where NOM= '" & nom & "'"


        ''Dim cmd As New OracleCommand(c cn)
        cmd.Connection = cn
        ''  cmd.CommandType = CommandType.Text

        cmd.ExecuteNonQuery()

        ''cmd.CommandType = CommandType.Text
        MessageBox.Show("Password Changed")

    End Sub
End Class