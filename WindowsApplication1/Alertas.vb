Imports MySql.Data.MySqlClient
Module Alertas
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        Dim sqlInsertCommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_inicio_alerta between ? and ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta1", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta1"
        objParam.SourceVersion = DataRowVersion.Current

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_alerta ( titulo_alerta, agente_contrato , data_inicio_contrato , data_fim_contrato , clausulas_contrato , remuneracao_contrato , preco_exigido_contrato , valor_total_contrato , valor_carteira_contrato, status_ativo_contrato) values(?,?,?,?,?,?,?,?,?,?,?)"

        objParam = sqlInsertCommand.Parameters.Add("@id_jogador_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador_contrato"
        objParam.SourceVersion = DataRowVersion.Original

        Return alertasDtAdapter

    End Function
End Module
