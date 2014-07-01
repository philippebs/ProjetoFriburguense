Imports MySql.Data.MySqlClient
Public Class FrmCadastroJog
    Public frmListarJogadores As New FrmListaJogador
    Private frmCadastrarAlertas As FrmCadastrarAlerta
    Public linha As ListViewItem

    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_jogador As Integer = -1

    Private Sub btnCancelarCadastroJogador_Click(sender As Object, e As EventArgs) Handles btnCancelarCadastroJogador.Click
        Me.Close()
    End Sub

    Private Sub btnCadastarJogador_Click(sender As Object, e As EventArgs) Handles btnCadastarJogador.Click
        Dim nascimento As Date = mtxtCadastroNAscimento.Text
        nascimento = Format(nascimento, "yyyy-MM-dd")
        conn = Conexao.getConexao
        adaptador = Jogadores.getAdapter(conn)

        conn.Open()
        Try
            If linha Is Nothing Then
                adaptador.InsertCommand.Parameters("@nome_jogador").Value = txtNomeJogador.Text
                adaptador.InsertCommand.Parameters("@categoria_jogador").Value = cmbCategoriaJogador.SelectedItem
                adaptador.InsertCommand.Parameters("@nascimento_jogador").Value = nascimento
                adaptador.InsertCommand.Parameters("@posicao_jogador").Value = cmbPosicaoJogador.SelectedItem
                adaptador.InsertCommand.Parameters("@numero_pos_jogador").Value = cmbPosicaoJogador.SelectedIndex
                adaptador.InsertCommand.Parameters("@contato_jogador").Value = txtContato.Text
                adaptador.InsertCommand.Parameters("@telefone_contato_jogador").Value = mtxtTelefone.Text
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                adaptador.UpdateCommand.Parameters("@id_jogador").Value = id_jogador
                adaptador.UpdateCommand.Parameters("@nome_jogador").Value = txtNomeJogador.Text
                adaptador.UpdateCommand.Parameters("@categoria_jogador").Value = cmbCategoriaJogador.SelectedItem
                adaptador.UpdateCommand.Parameters("@nascimento_jogador").Value = nascimento
                adaptador.UpdateCommand.Parameters("@posicao_jogador").Value = cmbPosicaoJogador.SelectedItem
                adaptador.UpdateCommand.Parameters("@numero_pos_jogador").Value = cmbPosicaoJogador.SelectedIndex
                adaptador.UpdateCommand.Parameters("@contato_jogador").Value = txtContato.Text
                adaptador.UpdateCommand.Parameters("@telefone_contato_jogador").Value = mtxtTelefone.Text
                adaptador.UpdateCommand.ExecuteNonQuery()
                MessageBox.Show("Alteração realizada com sucesso!!")
            End If
            conn.Close()
            frmListarJogadores.atualizar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Valores repetidos")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnAlertaCadastroJogador_Click(sender As Object, e As EventArgs) Handles btnAlertaCadastroJogador.Click
        Dim frmCadastroAlert As New FrmCadastrarAlerta()
        frmCadastroAlert.MdiParent = Me.MdiParent
        frmCadastroAlert.frmCadastroJogador = Me
        If retornaTextoSelecionado() <> "Nao selecionado" Then
            frmCadastroAlert.txtTitulo.Text = retornaTextoSelecionado()
        End If

        frmCadastroAlert.Show()
        'MessageBox.Show(retornaTextoSelecionado())
    End Sub

    Private Function retornaTextoSelecionado()
        Dim texto As String = "Nao selecionado"
        If txtNomeJogador.SelectedText.Length > 0 Then
            texto = txtNomeJogador.SelectedText
        End If
        If mtxtCadastroNAscimento.SelectedText.Length > 0 Then
            texto = mtxtCadastroNAscimento.SelectedText
        End If
        'MessageBox.Show(cmbCategoriaJogador.SelectedText.Length)
        'If cmbCategoriaJogador.SelectedText.Then Then
        '    texto = cmbCategoriaJogador.SelectedItem
        '    'MessageBox.Show(cmbCategoriaJogador.SelectedItem)
        'End If
        'If cmbPosicaoJogador.CanFocus Then
        'texto = cmbPosicaoJogador.SelectedItem
        'End If
        Return texto
    End Function

    Private Sub FrmCadastroJog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Not linha Is Nothing Then

            conn = Conexao.getConexao
            adaptador = JogadoresPeloNome.getAdapter(conn)

            conn.Open()
            adaptador.SelectCommand.Parameters("@nome_jogador").Value = linha.SubItems(0).Text
            objReader = adaptador.SelectCommand().ExecuteReader

            Do While objReader.Read
                id_jogador = objReader.GetValue(0)
                txtNomeJogador.Text = objReader.GetValue(1)
                cmbPosicaoJogador.Text = objReader.GetValue(4)
                cmbCategoriaJogador.Text = objReader.GetValue(2)
                mtxtCadastroNAscimento.Text = objReader.GetValue(3)
                txtContato.Text = objReader.GetValue(6)
                mtxtTelefone.Text = objReader.GetValue(7)
            Loop

            txtNomeJogador.Enabled = False
            cmbPosicaoJogador.Enabled = False
            cmbCategoriaJogador.Enabled = False
            mtxtCadastroNAscimento.Enabled = False
            btnAlertaCadastroJogador.Enabled = False
            txtContato.Enabled = False
            mtxtTelefone.Enabled = False
            conn.Close()
        Else
            btnAvaliacao.Enabled = False

        End If

    End Sub

    Private Sub btnEditarCadastroJogador_Click(sender As Object, e As EventArgs) Handles btnEditarCadastroJogador.Click
        txtNomeJogador.Enabled = True
        cmbPosicaoJogador.Enabled = True
        cmbCategoriaJogador.Enabled = True
        mtxtCadastroNAscimento.Enabled = True
        btnAlertaCadastroJogador.Enabled = True
        txtContato.Enabled = True
        mtxtTelefone.Enabled = True
    End Sub
    Private Sub btnContratoCadastro_Click(sender As Object, e As EventArgs) Handles btnContratoCadastro.Click
        Dim frmCadastroContrato As New FrmCadastroContrato()
        frmCadastroContrato.IdJogador(id_jogador)
        frmCadastroContrato.nomeDoJogador(txtNomeJogador.Text)
        frmCadastroContrato.MdiParent = Me.MdiParent
        frmCadastroContrato.frmCadastroJog = Me
        frmCadastroContrato.Show()
    End Sub


    Private Sub btnAvaliacao_Click(sender As Object, e As EventArgs) Handles btnAvaliacao.Click
        Dim caminho As String = "C:\Users\Philippe-i3\Desktop\Avaliacao\" + cmbCategoriaJogador.SelectedItem + "\" + txtNomeJogador.Text + ".pdf"
        Try
            Process.Start(caminho)
        Catch
            MsgBox("A avaliação desse jogador não foi cadastrada")
        End Try
    End Sub
End Class