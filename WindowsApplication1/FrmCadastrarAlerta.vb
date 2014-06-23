Public Class FrmCadastrarAlerta

    Public frmCadastroJogador As FrmCadastroJog
    Public frmCadastroContatos As FrmCadastroContato
    Public frmCadastroNota As FrmCadastroContato
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter

    Private Sub txtTexto_Click(sender As Object, e As EventArgs) Handles txtTexto.Click
        txtTexto.Text = ""
    End Sub

    Private Sub btnAlertaCancelar_Click(sender As Object, e As EventArgs) Handles btnAlertaCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAlertaSalvar_Click(sender As Object, e As EventArgs) Handles btnAlertaSalvar.Click
        Dim inicio As Date
        Dim termino As Date = mtxtAlertaDataTermino.Text
        Dim conta As Integer = 0

        If cbConta.Checked Then
            termino = Format(termino, "yyyy-MM-dd")
            inicio = termino
            conta = 1
        Else
            inicio = mtxtAlertaDataInicio.Text
            inicio = Format(inicio, "yyyy-MM-dd")
            termino = Format(termino, "yyyy-MM-dd")
        End If

        If inicio <= termino Then
            conn = Conexao.getConexao
            adaptador = Alertas.getAdapter(conn)
            conn.Open()
            
            adaptador.InsertCommand.Parameters("@titulo_alerta").Value = txtTitulo.Text
            If conta = 1 Then
                Dim dia As Integer = termino.Day
                dia -= 3
                inicio = dia.ToString & "/" & termino.Month & "/" & termino.Year
                inicio = Format(inicio, "yyyy-MM-dd")
            End If
            adaptador.InsertCommand.Parameters("@data_inicio_alerta").Value = inicio
            adaptador.InsertCommand.Parameters("@data_termino_alerta").Value = termino
            adaptador.InsertCommand.Parameters("@mensagem_alerta").Value = txtTexto.Text

            adaptador.InsertCommand.Parameters("@conta_alerta").Value = conta
            adaptador.InsertCommand.ExecuteNonQuery()

            MessageBox.Show("Cadastro realizado com sucesso!")
            conn.Close()
            Me.Close()
        Else
            MessageBox.Show("Inicio do contrato é maior que o termino!")
        End If
    End Sub

    Private Sub cbConta_CheckedChanged(sender As Object, e As EventArgs) Handles cbConta.CheckedChanged
        mtxtAlertaDataInicio.Visible = False
        lblDataInicio.Visible = False
        lblDataFim.Text = "Data de vencimento"
    End Sub
End Class