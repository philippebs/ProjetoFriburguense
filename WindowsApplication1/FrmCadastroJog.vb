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
        'Dim adaptadorJogador As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim nascimento As Date = mtxtCadastroNAscimento.Text
        'Dim inicio As Date = mtxtCadastroInicio.Text
        'Dim termino As Date = mtxtCadastroTermino.Text

        'Dim id As Integer
        nascimento = Format(nascimento, "yyyy-MM-dd")
        'inicio = Format(inicio, "yyyy-MM-dd")
        'termino = Format(termino, "yyyy-MM-dd")
        conn = Conexao.getConexao
        adaptador = Jogadores.getAdapter(conn)

        conn.Open()
        Try
            If linha Is Nothing Then
                'adaptador.InsertCommand.Parameters("@id_jogador").Value = txtIdJogador.Text
                adaptador.InsertCommand.Parameters("@nome_jogador").Value = txtNomeJogador.Text
                adaptador.InsertCommand.Parameters("@categoria_jogador").Value = cmbCategoriaJogador.SelectedItem
                adaptador.InsertCommand.Parameters("@nascimento_jogador").Value = nascimento
                adaptador.InsertCommand.Parameters("@posicao_jogador").Value = cmbPosicaoJogador.SelectedItem
                'adaptador.InsertCommand.Parameters("@agente_jogador").Value = txtAgenteJogador.Text
                'adaptador.InsertCommand.Parameters("@tipo_jogador").Value = txtTipoJogador.Text
                'adaptador.InsertCommand.Parameters("@valor_jogador").Value = txtValorJogador.Text
                'adaptador.InsertCommand.Parameters("@preco_jogador").Value = txtPrecoJogador.Text
                'adaptador.InsertCommand.Parameters("@remuneracao_jogador").Value = txtRemuneracaoJogador.Text
                'adaptador.InsertCommand.Parameters("@valor_carteira_jogador").Value = txtValorCarteiraJogador.Text
                'adaptador.InsertCommand.Parameters("@iniciado").Value = inicio
                'adaptador.InsertCommand.Parameters("@termino").Value = termino
                'adaptador.InsertCommand.Parameters("@clausulas_jogador").Value = txtClausulasJogador.Text
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                'MessageBox.Show(linha.Text)
                adaptador.UpdateCommand.Parameters("@id_jogador").Value = id_jogador
                adaptador.UpdateCommand.Parameters("@nome_jogador").Value = txtNomeJogador.Text
                adaptador.UpdateCommand.Parameters("@categoria_jogador").Value = cmbCategoriaJogador.SelectedItem
                adaptador.UpdateCommand.Parameters("@nascimento_jogador").Value = nascimento
                adaptador.UpdateCommand.Parameters("@posicao_jogador").Value = cmbPosicaoJogador.SelectedItem
                'adaptador.UpdateCommand.Parameters("@agente_jogador").Value = txtAgenteJogador.Text
                'adaptador.UpdateCommand.Parameters("@tipo_jogador").Value = txtTipoJogador.Text
                'adaptador.UpdateCommand.Parameters("@valor_jogador").Value = txtValorJogador.Text
                'adaptador.UpdateCommand.Parameters("@preco_jogador").Value = txtPrecoJogador.Text
                'adaptador.UpdateCommand.Parameters("@remuneracao_jogador").Value = txtRemuneracaoJogador.Text
                'adaptador.UpdateCommand.Parameters("@valor_carteira_jogador").Value = txtValorCarteiraJogador.Text
                'adaptador.UpdateCommand.Parameters("@iniciado").Value = inicio
                'adaptador.UpdateCommand.Parameters("@termino").Value = termino
                'adaptador.UpdateCommand.Parameters("@clausulas_jogador").Value = txtClausulasJogador.Text
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
        frmCadastroAlert.Show()

    End Sub

    Private Sub FrmCadastroJog_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If Not linha Is Nothing Then

            conn = Conexao.getConexao
            adaptador = JogadoresPeloNome.getAdapter(conn)

            conn.Open()
            adaptador.SelectCommand.Parameters("@nome_jogador").Value = linha.SubItems(0).Text
            'MessageBox.Show(linha.SubItems(0).Text)
            objReader = adaptador.SelectCommand().ExecuteReader

            Do While objReader.Read
                'Dim data As Date = String.Format(objReader.GetValue(11), "")
                id_jogador = objReader.GetValue(0)
                txtNomeJogador.Text = objReader.GetValue(1)
                cmbPosicaoJogador.Text = objReader.GetValue(4)
                cmbCategoriaJogador.Text = objReader.GetValue(2)
                mtxtCadastroNAscimento.Text = objReader.GetValue(3)
                'txtTipoJogador.Text = objReader.GetValue(6)
                'txtAgenteJogador.Text = objReader.GetValue(5)
                'txtValorJogador.Text = objReader.GetValue(7)
                'txtPrecoJogador.Text = objReader.GetValue(8)
                'txtRemuneracaoJogador.Text = objReader.GetValue(9)
                'txtValorCarteiraJogador.Text = objReader.GetValue(10)
                'Data = Format(objReader.GetValue(11), "dd/MM/yyyy")

                'mtxtCadastroInicio.Text = objReader.GetValue(11)
                'mtxtCadastroTermino.Text = objReader.GetValue(12)
                'txtClausulasJogador.Text = objReader.GetValue(13)
            Loop

            txtNomeJogador.Enabled = False
            cmbPosicaoJogador.Enabled = False
            cmbCategoriaJogador.Enabled = False
            mtxtCadastroNAscimento.Enabled = False
            'txtTipoJogador.Enabled = False
            'txtAgenteJogador.Enabled = False
            'txtValorJogador.Enabled = False
            'txtPrecoJogador.Enabled = False
            'txtRemuneracaoJogador.Enabled = False
            'txtValorCarteiraJogador.Enabled = False
            'mtxtCadastroInicio.Enabled = False
            'mtxtCadastroTermino.Enabled = False
            'txtClausulasJogador.Enabled = False
            'btnCadastarJogador.Enabled = False
            btnAlertaCadastroJogador.Enabled = False
            'cmbPosicaoJogador.Text = linha.SubItems(1).Text
            'cmbCategoriaJogador.Text = linha.SubItems(2).Text
            'MessageBox.Show(linha.SubItems(3).Text)
            conn.Close()
        Else
            'MessageBox.Show("Erro!")
            btnAvaliacao.Visible = False
        End If

    End Sub

    Private Sub btnEditarCadastroJogador_Click(sender As Object, e As EventArgs) Handles btnEditarCadastroJogador.Click
        txtNomeJogador.Enabled = True
        cmbPosicaoJogador.Enabled = True
        cmbCategoriaJogador.Enabled = True
        mtxtCadastroNAscimento.Enabled = True
        'txtTipoJogador.Enabled = True
        'txtAgenteJogador.Enabled = True
        'txtValorJogador.Enabled = True
        'txtPrecoJogador.Enabled = True
        'txtRemuneracaoJogador.Enabled = True
        'txtValorCarteiraJogador.Enabled = True
        'mtxtCadastroInicio.Enabled = True
        'mtxtCadastroTermino.Enabled = True
        'txtClausulasJogador.Enabled = True
        'btnCadastarJogador.Enabled = True
        btnAlertaCadastroJogador.Enabled = True
    End Sub
    Private Sub btnContratoCadastro_Click(sender As Object, e As EventArgs) Handles btnContratoCadastro.Click
        Dim frmCadastroContrato As New FrmCadastroContrato()
        frmCadastroContrato.IdJogador(id_jogador)
        frmCadastroContrato.MdiParent = Me.MdiParent
        frmCadastroContrato.frmCadastroJog = Me

        'MessageBox.Show(id_jogador)
        frmCadastroContrato.Show()
    End Sub


    Private Sub btnAvaliacao_Click(sender As Object, e As EventArgs) Handles btnAvaliacao.Click
        Dim caminho As String = "C:\Users\eu\Desktop\avaliacao\" + txtNomeJogador.Text + ".pdf"
        Try
            Process.Start(caminho)
        Catch
            MsgBox("A avaliação desse jogador não foi cadastrada")
        End Try
    End Sub
End Class