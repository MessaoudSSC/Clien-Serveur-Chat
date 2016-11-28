Imports Oracle.DataAccess.Client

Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        SingnUp.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ct As OracleDataAdapter
        Dim ds As DataSet
        Dim cs As String = "data source =xe ; user id=system ; password=1386313863;"
        Dim cn As New OracleConnection(cs)
        ct = New OracleDataAdapter("select NOM, PASSWORD from singup where NOM='" & Nom.Text & "' And PASSWORD ='" & pass.Text & "'", cs)

        '' Dim cmd As New OracleCommand(ct, cn)
        ''cmd.CommandType = CommandType.Text
        ds = New DataSet()

        ct.Fill(ds, "login")
        If (ds.Tables("login").Rows.Count > 0) Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("mot de passe ou nom incorrecte alors verefier ou s'il vous plais SINGUP pour chating avec vouz amis ")

        End If

    End Sub
End Class