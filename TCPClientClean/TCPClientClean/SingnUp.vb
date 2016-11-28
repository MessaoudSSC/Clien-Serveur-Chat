Imports Oracle.DataAccess.Client


Public Class SingnUp
    Private Sub SingnUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cs As String = "data source =xe ; user id=system ; password=1386313863;"
        Dim cn As New OracleConnection(cs)
        Dim ct As String = "insert into SINGUP values ('" & nom.Text & "','" & pass.Text & "','" & prenom.Text & "')"

        Dim cmd As New OracleCommand(ct, cn)
        cmd.CommandType = CommandType.Text
        Try

            If (nom.Text = "") Or (pass.Text = "") Or (prenom.Text = "") Then

                MessageBox.Show("l'un des champs est vide ou Mal saisie")
            End If
            cn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("ajouter mriguel")
            Me.Hide()
            Form1.Show()

        Catch ex As OracleException
            If ex.ErrorCode = 1 Then
                MessageBox.Show("changer le num  il exist deja ")
            Else
                MessageBox.Show("erreur oracle: " & ex.Message)
            End If
        Catch ee As Exception
            MessageBox.Show("erreur" & ee.Message)
        Finally
            cn.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim COMMAND As OracleCommand
        Dim cs As String = "data source =xe ; user id=system ; password=1386313863;"
        Dim cn As New OracleConnection(cs)
        Dim SDA As New OracleDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        'Dim ct As String = "insert into SINGUP values ('" & nom.Text & "','" & pass.Text & "','" & prenom.Text & "')"
        'Dim cmd As New OracleCommand(ct, cn)
        'cmd.CommandType = CommandType.Text
        Try
            cn.Open()
            Dim sql = "select NOM, prenom from singup"
            COMMAND = New OracleCommand(sql, cn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource

            SDA.Update(dbDataset)

            cn.Close()


        Catch ex As OracleException
            MessageBox.Show(ex.Message)
        Finally
            cn.Dispose()


        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        change.Show()

    End Sub
End Class