Imports MySql.Data.MySqlClient
Public Class FrmCadastroContrato
    Public frmCadastroJog As New FrmCadastroJog
    Private frmCadastrarAlertas As FrmCadastrarAlerta
    Private cadastrar As Boolean = True
    Private id_jogador_contrato As Integer
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private id_contrato As Integer = -1
    Private nomeJogador As String
    Private inicio As Date
    Private termino As Date
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
        lblNomeJoagador.Text = "Nome: " + nomeJogador
        conn = Conexao.getConexao
        adaptador = Contrato.getAdapter(conn)

        conn.Open()
        adaptador.SelectCommand.Parameters("@id_jogador_contrato").Value = id_jogador_contrato
        adaptador.SelectCommand.Parameters("@status_ativo_contrato").Value = "1"
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
            Loop
            cadastrar = False
            btnCadastarContrato.Text = "Salvar"
        Else
            MessageBox.Show("Jogador sem contrato ou contrato terminou!")
        End If
        conn.Close()
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
            If cadastrar Then
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

                Dim adaptador2 As MySql.Data.MySqlClient.MySqlDataAdapter
                Dim conn2 As MySql.Data.MySqlClient.MySqlConnection
                conn2 = Conexao.getConexao
                adaptador2 = Alertas.getAdapter(conn2)
                conn2.Open()
                Try
                    adaptador2.InsertCommand.Parameters("@titulo_alerta").Value = "Renovar Contrato: "
                    adaptador2.InsertCommand.Parameters("@data_inicio_alerta").Value = termino
                    adaptador2.InsertCommand.Parameters("@data_termino_alerta").Value = termino
                    adaptador2.InsertCommand.Parameters("@mensagem_alerta").Value = "O contrato do jogador " & nomeJogador & " termina em: " & termino.Day.ToString & "/" & termino.Month.ToString & "/" & termino.Year.ToString
                    adaptador2.InsertCommand.Parameters("@conta_alerta").Value = 0
                    adaptador2.InsertCommand.ExecuteNonQuery()
                    conn2.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                MessageBox.Show("Cadastro realizado com sucesso!")
            Else
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

    Private Sub btnAlertaCadastroContrato_Click(sender As Object, e As EventArgs) Handles btnAlertaCadastroContrato.Click
        MessageBox.Show(retornaTextoSelecionado())
    End Sub

    Private Function retornaTextoSelecionado()
        Dim texto As String = "Nao selecionado"
        If txtTipoContrato.SelectedText.Length > 0 Then
            texto = txtTipoContrato.SelectedText
        End If
        If txtAgenteContrato.SelectedText.Length > 0 Then
            texto = txtAgenteContrato.SelectedText
        End If
        If txtPrecoContrato.SelectedText.Length > 0 Then
            texto = txtPrecoContrato.SelectedText
        End If
        If txtRemuneracaoContrato.SelectedText.Length > 0 Then
            texto = txtRemuneracaoContrato.SelectedText
        End If
        If txtValorCarteiraContrato.SelectedText.Length > 0 Then
            texto = txtValorCarteiraContrato.SelectedText
        End If
        If txtValorContrato.SelectedText.Length > 0 Then
            texto = txtValorContrato.SelectedText
        End If
        If txtClausulasContrato.SelectedText.Length > 0 Then
            texto = txtClausulasContrato.SelectedText
        End If
        If mtxtDataInicio.SelectedText.Length > 0 Then
            texto = mtxtDataInicio.SelectedText
        End If
        If mtxtDataTermino.SelectedText.Length > 0 Then
            texto = mtxtDataTermino.SelectedText
        End If
        Return texto
    End Function
End Class