Imports MySql.Data.MySqlClient
Public Class FrmCadastroContrato
    Public frmCadastroJog As New FrmCadastroJog
    Private cadastrar As Boolean = True
    Private id_jogador_contrato As Integer
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_contrato As Integer = -1
    Private nomeJogador As String
    Private inicio As Date
    Private termino As Date
    'Dim inicio As Date = mtxtDataInicio.Text
    'Dim termino As Date = mtxtDataTermino.Text
    Public Sub IdJogador(ByVal id As Integer)
        If id > -1 Then
            id_jogador_contrato = id
        End If
    End Sub

    Public Sub nomeDoJogador(ByVal nome As String)
        nomeJogador = nome
    End Sub

    Public Sub CadastrarJogador(ByVal cad As Boolean)
        cadastrar = cad
    End Sub

    Private Sub btnCadastarJogador_Click(sender As Object, e As EventArgs) Handles btnCadastarContrato.Click
        inicio = mtxtDataInicio.Text
        termino = mtxtDataTermino.Text
        inicio = Format(inicio, "yyyy-MM-dd")
        termino = Format(termino, "yyyy-MM-dd")

        If inicio < termino Then
            cadastrarAlterar(1)
            Me.Close()
        Else
            MessageBox.Show("Inicio do contrato é maior que o termino!")
        End If
        
    End Sub


    Private Sub FrmCadastroContrato_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'If Not linha Is Nothing Then
        lblNomeJoagador.Text = "Nome: " + nomeJogador
        conn = Conexao.getConexao
        adaptador = Contrato.getAdapter(conn)

        conn.Open()
        adaptador.SelectCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
        adaptador.SelectCommand.Parameters("@status_ativo_contrato").Value = "1"
        'MessageBox.Show(linha.SubItems(0).Text)
        objReader = adaptador.SelectCommand().ExecuteReader
        If objReader.HasRows Then
            Do While objReader.Read
                id_contrato = objReader.GetValue(0)
                txtTipoContrato.Text = objReader.GetValue(2)
                txtAgenteContrato.Text = objReader.GetValue(3)
                mtxtDataInicio.Text = objReader.GetValue(4)
                mtxtDataTermino.Text = objReader.GetValue(5)
                txtClausulasContrato.Text = objReader.GetValue(6)
                txtRemuneracaoContrato.Text = objReader.GetValue(7)
                txtPrecoContrato.Text = objReader.GetValue(8)
                txtValorContrato.Text = objReader.GetValue(9)
                txtValorCarteiraContrato.Text = objReader.GetValue(10)

                '    'Dim data As Date = String.Format(objReader.GetValue(11), "")
                '    id_contrato = objReader.GetValue(0)
                '    id_jogador_contrato = objReader.GetValue(1)
                'txtNomeJogador.Text = objReader.GetValue(2)
                'cmbPosicaoJogador.Text = objReader.GetValue(4)
                'cmbCategoriaJogador.Text = objReader.GetValue(2)
                'mtxtCadastroNAscimento.Text = objReader.GetValue(3)
                'txtTipoJogador.Text = objReader.GetValue(6)
                'txtAgenteJogador.Text = objReader.GetValue(5)
                'txtValorJogador.Text = objReader.GetValue(7)
                'txtPrecoJogador.Text = objReader.GetValue(8)
                'txtRemuneracaoJogador.Text = objReader.GetValue(9)
                'txtValorCarteiraJogador.Text = objReader.GetValue(10)
                ''Data = Format(objReader.GetValue(11), "dd/MM/yyyy")
                'MessageBox.Show("TEste")
                'mtxtCadastroInicio.Text = objReader.GetValue(11)
                'mtxtCadastroTermino.Text = objReader.GetValue(12)
                'txtClausulasJogador.Text = objReader.GetValue(13)
            Loop
            cadastrar = False
            btnCadastarContrato.Text = "Salvar"
            'cmbPosicaoJogador.Text = linha.SubItems(1).Text
            'cmbCategoriaJogador.Text = linha.SubItems(2).Text
            'MessageBox.Show(linha.SubItems(3).Text)

        Else
            MessageBox.Show("Jogador sem contrato ou contrato terminou!")
        End If
        conn.Close()
        'MessageBox.Show(linha.Text)
        'End If
    End Sub

    Private Sub btnCancelarCadastroContrato_Click(sender As Object, e As EventArgs) Handles btnCancelarCadastroContrato.Click
        Me.Close()
    End Sub

    Private Sub btnRenovarContrato_Click(sender As Object, e As EventArgs) Handles btnRenovarContrato.Click
        If Not cadastrar Then
            cadastrarAlterar(0)
            limparCampos()
            cadastrar = True
        End If

    End Sub

    Private Sub cadastrarAlterar(ByVal ativo As Integer)
        

        inicio = Format(inicio, "yyyy-MM-dd")
        termino = Format(termino, "yyyy-MM-dd")
        conn = Conexao.getConexao
        adaptador = Contrato.getAdapter(conn)

        conn.Open()
        Try
            'MessageBox.Show(linha.SubItems(0).ToString)
            If cadastrar Then
                ''linha Is Nothing Then
                adaptador.InsertCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
                adaptador.InsertCommand.Parameters("@tipo_contrato").Value = txtTipoContrato.Text
                adaptador.InsertCommand.Parameters("@agente_contrato").Value = txtAgenteContrato.Text
                adaptador.InsertCommand.Parameters("@valor_total_contrato").Value = txtValorContrato.Text
                adaptador.InsertCommand.Parameters("@preco_exigido_contrato").Value = txtPrecoContrato.Text
                adaptador.InsertCommand.Parameters("@remuneracao_contrato").Value = txtRemuneracaoContrato.Text
                adaptador.InsertCommand.Parameters("@valor_carteira_contrato").Value = txtValorCarteiraContrato.Text
                adaptador.InsertCommand.Parameters("@data_inicio_contrato").Value = inicio
                adaptador.InsertCommand.Parameters("@data_fim_contrato").Value = termino
                adaptador.InsertCommand.Parameters("@clausulas_contrato").Value = txtClausulasContrato.Text
                adaptador.InsertCommand.Parameters("@status_ativo_contrato").Value = ativo
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                'MessageBox.Show(linha.Text)
                adaptador.UpdateCommand.Parameters("@id_contrato").Value = id_contrato
                adaptador.UpdateCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
                adaptador.UpdateCommand.Parameters("@tipo_contrato").Value = txtTipoContrato.Text
                adaptador.UpdateCommand.Parameters("@agente_contrato").Value = txtAgenteContrato.Text
                adaptador.UpdateCommand.Parameters("@valor_total_contrato").Value = txtValorContrato.Text
                adaptador.UpdateCommand.Parameters("@preco_exigido_contrato").Value = txtPrecoContrato.Text
                adaptador.UpdateCommand.Parameters("@remuneracao_contrato").Value = txtRemuneracaoContrato.Text
                adaptador.UpdateCommand.Parameters("@valor_carteira_contrato").Value = txtValorCarteiraContrato.Text
                adaptador.UpdateCommand.Parameters("@data_inicio_contrato").Value = inicio
                adaptador.UpdateCommand.Parameters("@data_fim_contrato").Value = termino
                adaptador.UpdateCommand.Parameters("@clausulas_contrato").Value = txtClausulasContrato.Text
                adaptador.UpdateCommand.Parameters("@status_ativo_contrato").Value = ativo
                adaptador.UpdateCommand.ExecuteNonQuery()
                If ativo = 1 Then
                    MessageBox.Show("Alteração realizada com sucesso!!")
                End If
                End If
                conn.Close()
                'frmListarJogadores.atualizar()
        Catch ex As Exception
            MessageBox.Show("Valores repetidos")
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub limparCampos()
        txtTipoContrato.Text = ""
        txtAgenteContrato.Text = ""
        txtValorContrato.Text = ""
        txtPrecoContrato.Text = ""
        txtRemuneracaoContrato.Text = ""
        txtValorCarteiraContrato.Text = ""
        mtxtDataInicio.Text = ""
        mtxtDataTermino.Text = ""
        txtClausulasContrato.Text = ""
    End Sub

End Class