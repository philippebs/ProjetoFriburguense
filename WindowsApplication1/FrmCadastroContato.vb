Imports MySql.Data.MySqlClient
Public Class FrmCadastroContato

    Public frmListarContatos As New FrmListaContato
    Private frmCadastrarAlertas As New FrmCadastrarAlerta
    Public linha As ListViewItem

    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_contato As Integer = 0

    Private Sub btnCancelarCadastroContato_Click(sender As Object, e As EventArgs) Handles btnCancelarCadastroContato.Click
        Me.Close()
    End Sub

    Private Sub btnCadastarContato_Click(sender As Object, e As EventArgs) Handles btnCadastarContato.Click
        'Dim adaptadorJogador As MySql.Data.MySqlClient.MySqlDataAdapter
        'Dim id As Integer
        conn = Conexao.getConexao
        adaptador = Contatos.getAdapter(conn)

        conn.Open()
        Try
            If linha Is Nothing Then
                adaptador.InsertCommand.Parameters("@nome_contato").Value = txtNomeContato.Text
                adaptador.InsertCommand.Parameters("@email_contato").Value = txtEmailContato.Text
                adaptador.InsertCommand.Parameters("@telefone1_contato").Value = txtTel1Contato.Text
                adaptador.InsertCommand.Parameters("@telefone2_contato").Value = txtTel2Contato.Text
                adaptador.InsertCommand.Parameters("@celular_contato").Value = txtCelularContato.Text
                adaptador.InsertCommand.Parameters("@site_contato").Value = txtSiteContato.Text
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                'MessageBox.Show(linha.Text)
                adaptador.UpdateCommand.Parameters("@id_contato").Value = id_contato
                adaptador.UpdateCommand.Parameters("@nome_contato").Value = txtNomeContato.Text
                adaptador.UpdateCommand.Parameters("@email_contato").Value = txtEmailContato.Text
                adaptador.UpdateCommand.Parameters("@telefone1_contato").Value = txtTel1Contato.Text
                adaptador.UpdateCommand.Parameters("@telefone2_contato").Value = txtTel2Contato.Text
                adaptador.UpdateCommand.Parameters("@celular_contato").Value = txtCelularContato.Text
                adaptador.UpdateCommand.Parameters("@site_contato").Value = txtSiteContato.Text
                adaptador.UpdateCommand.ExecuteNonQuery()
                MessageBox.Show("Alteração realizada com sucesso!")
            End If
            conn.Close()
            frmListarContatos.atualizar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Valores repetidos")
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub btnAlertaCadastroContato_Click(sender As Object, e As EventArgs) Handles btnAlertaCadastroContato.Click
        Dim frmCadastroAlert As New FrmCadastrarAlerta()
        frmCadastroAlert.MdiParent = Me.MdiParent
        frmCadastroAlert.frmCadastroContatos = Me
        frmCadastroAlert.Show()

    End Sub

    Private Sub FrmCadastroContato_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not linha Is Nothing Then

            conn = Conexao.getConexao
            adaptador = ContatosPeloNome.getAdapter(conn)

            conn.Open()
            adaptador.SelectCommand.Parameters("@nome_contato").Value = linha.SubItems(0).Text
            'MessageBox.Show(linha.SubItems(0).Text)
            objReader = adaptador.SelectCommand().ExecuteReader

            Do While objReader.Read
                'Dim data As Date = String.Format(objReader.GetValue(11), "")
                id_contato = objReader.GetValue(0)
                txtNomeContato.Text = objReader.GetValue(1)
                txtEmailContato.Text = objReader.GetValue(2)
                txtTel1Contato.Text = objReader.GetValue(3)
                txtTel2Contato.Text = objReader.GetValue(4)
                txtCelularContato.Text = objReader.GetValue(5)
                txtSiteContato.Text = objReader.GetValue(6)
                'Data = Format(objReader.GetValue(11), "dd/MM/yyyy")


            Loop

            txtNomeContato.Enabled = False
            txtEmailContato.Enabled = False
            txtTel1Contato.Enabled = False
            txtTel2Contato.Enabled = False
            txtCelularContato.Enabled = False
            txtSiteContato.Enabled = False
            
            'cmbPosicaoJogador.Text = linha.SubItems(1).Text
            'cmbCategoriaJogador.Text = linha.SubItems(2).Text
            'MessageBox.Show(linha.SubItems(3).Text)
            conn.Close()
            btnCadastarContato.Enabled = False
            btnAlertaCadastroContato.Enabled = False

            'Else
            '    MessageBox.Show("Erro!")
        End If

    End Sub

    Private Sub btnEditarCadastroContato_Click(sender As Object, e As EventArgs) Handles btnEditarCadastroContato.Click
        txtNomeContato.Enabled = True
        txtEmailContato.Enabled = True
        txtTel1Contato.Enabled = True
        txtTel2Contato.Enabled = True
        txtCelularContato.Enabled = True
        txtSiteContato.Enabled = True
        btnCadastarContato.Enabled = True
        btnAlertaCadastroContato.Enabled = True
    End Sub

   
End Class
