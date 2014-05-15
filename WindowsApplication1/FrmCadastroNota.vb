Imports MySql.Data.MySqlClient
Public Class FrmCadastroNota
    Public frmListarNotas As New FrmCadastroContato
    Private frmCadastrarAlertas As FrmCadastrarAlerta
    Public linha As ListViewItem

    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_Nota As Integer = -1
    Public n As String = "0"
    Function mandarContato(valor As String)
        n = valor
        Return valor
    End Function

    Private Sub btnCancelarCadastroNota_Click(sender As Object, e As EventArgs) Handles btnCancelarCadastroNota.Click
        Me.Close()
    End Sub

    Private Sub btnCadastarNota_Click(sender As Object, e As EventArgs) Handles btnCadastarNota.Click
        'Dim adaptadorJogador As MySql.Data.MySqlClient.MySqlDataAdapter
        conn = Conexao.getConexao

        adaptador = Notas.getAdapter(conn, n)

        conn.Open()
        Try
            If linha Is Nothing Then
                'adaptador.InsertCommand.Parameters("@id_jogador").Value = txtIdJogador.Text
                adaptador.InsertCommand.Parameters("@nota").Value = txtNota.Text
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                'MessageBox.Show(linha.Text)
                adaptador.UpdateCommand.Parameters("@id_nota").Value = id_Nota
                adaptador.UpdateCommand.Parameters("@id_contato").Value = n
                adaptador.UpdateCommand.Parameters("@nome_jogador").Value = txtNota.Text
                MessageBox.Show("Alteração realizada com sucesso!!")
            End If
            conn.Close()
            frmListarNotas.atualizar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Valores repetidos")
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    
    Private Sub FrmCadastroNota_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not linha Is Nothing Then

            conn = Conexao.getConexao
            adaptador = JogadoresPeloNome.getAdapter(conn)

            conn.Open()
            adaptador.SelectCommand.Parameters("@nota").Value = linha.SubItems(0).Text
            'MessageBox.Show(linha.SubItems(0).Text)
            objReader = adaptador.SelectCommand().ExecuteReader

            Do While objReader.Read
                'Dim data As Date = String.Format(objReader.GetValue(11), "")
                id_Nota = objReader.GetValue(0)
                txtNota.Text = objReader.GetValue(1)
                'Data = Format(objReader.GetValue(11), "dd/MM/yyyy")

            Loop

            txtNota.Enabled = False
            conn.Close()
        Else
            'MessageBox.Show("Erro!")
        End If

    End Sub

End Class