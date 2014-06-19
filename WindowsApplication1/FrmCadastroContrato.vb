Imports MySql.Data.MySqlClient
Public Class FrmCadastroContrato
    Public frmCadastroJog As New FrmCadastroJog
    Public linha As New ListViewItem
    Private id_jogador_contrato As Integer
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_contrato As Integer = -1

    Public Sub IdJogador(ByVal id As Integer)
        If id > -1 Then
            id_jogador_contrato = id
        End If

    End Sub

    Private Sub btnCadastarJogador_Click(sender As Object, e As EventArgs) Handles btnCadastarContrato.Click
        Dim inicio As Date = mtxtDataInicio.Text
        Dim termino As Date = mtxtDataTermino.Text

        inicio = Format(inicio, "yyyy-MM-dd")
        termino = Format(termino, "yyyy-MM-dd")
        conn = Conexao.getConexao
        adaptador = Contrato.getAdapter(conn)

        conn.Open()
        Try
            If linha Is Nothing Then
                adaptador.InsertCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
                adaptador.InsertCommand.Parameters("@tipo_contrato").Value = txtTipoContrato.Text
                adaptador.InsertCommand.Parameters("@agente_contrato").Value = txtAgenteContrato.Text
                adaptador.InsertCommand.Parameters("@valor_total_contrato").Value = txtValorContrato.Text
                adaptador.InsertCommand.Parameters("@preco_exigido_contrato").Value = txtPrecoContrato.Text
                adaptador.InsertCommand.Parameters("@remuneracao_contrato").Value = txtRemuneracaoContrato.Text
                adaptador.InsertCommand.Parameters("@valor_carteira_contrato").Value = txtValorCarteiraContrato.Text
                adaptador.InsertCommand.Parameters("@data_inicio_contrato").Value = mtxtDataInicio.Text
                adaptador.InsertCommand.Parameters("@data_fim_contrato").Value = mtxtDataTermino.Text
                adaptador.InsertCommand.Parameters("@clausulas_contrato").Value = txtClausulasContrato.Text
                adaptador.InsertCommand.Parameters("@status_ativo_contrato").Value = "1"
                adaptador.InsertCommand.ExecuteNonQuery()
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
                'MessageBox.Show(linha.Text)
                adaptador.UpdateCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
                adaptador.UpdateCommand.Parameters("@tipo_contrato").Value = txtTipoContrato.Text
                adaptador.UpdateCommand.Parameters("@agente_contrato").Value = txtAgenteContrato.Text
                adaptador.UpdateCommand.Parameters("@valor_total_contrato").Value = txtValorContrato.Text
                adaptador.UpdateCommand.Parameters("@preco_exigido_contrato").Value = txtPrecoContrato.Text
                adaptador.UpdateCommand.Parameters("@remuneracao_contrato").Value = txtRemuneracaoContrato.Text
                adaptador.UpdateCommand.Parameters("@valor_carteira_contrato").Value = txtValorCarteiraContrato.Text
                adaptador.UpdateCommand.Parameters("@data_inicio_contrato").Value = mtxtDataInicio.Text
                adaptador.UpdateCommand.Parameters("@data_fim_contrato").Value = mtxtDataTermino.Text
                adaptador.UpdateCommand.Parameters("@clausulas_contrato").Value = txtClausulasContrato.Text
                adaptador.UpdateCommand.Parameters("@status_ativo_contrato").Value = 1
                adaptador.UpdateCommand.ExecuteNonQuery()
                MessageBox.Show("Alteração realizada com sucesso!!")
            End If
            conn.Close()
            'frmListarJogadores.atualizar()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Valores repetidos")
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub FrmCadastroContrato_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not linha Is Nothing Then

            conn = Conexao.getConexao
            adaptador = Contrato.getAdapter(conn)

            conn.Open()
            adaptador.SelectCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
            adaptador.SelectCommand.Parameters("@status_ativo_contrato").Value = "1"
            'MessageBox.Show(linha.SubItems(0).Text)
            objReader = adaptador.SelectCommand().ExecuteReader

            Do While objReader.Read
                txtTipoContrato.Text = objReader.GetValue(3)
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


            'cmbPosicaoJogador.Text = linha.SubItems(1).Text
            'cmbCategoriaJogador.Text = linha.SubItems(2).Text
            'MessageBox.Show(linha.SubItems(3).Text)
            conn.Close()
        Else
            MessageBox.Show("Erro!")
            MessageBox.Show(linha.Text)
        End If
    End Sub

    Private Sub btnCancelarCadastroContrato_Click(sender As Object, e As EventArgs) Handles btnCancelarCadastroContrato.Click
        Me.Close()
    End Sub
End Class