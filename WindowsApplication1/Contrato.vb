Imports MySql.Data.MySqlClient

Module Contrato
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim contratoDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_contrato where id_jogador_contrato = ? and status_ativo_contrato = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@id_jogador_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador_contrato"
        objParam.SourceVersion = DataRowVersion.Original

        objParam = sqlSelectcommand.Parameters.Add("@status_ativo_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "status_ativo_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        contratoDtAdapter.SelectCommand = sqlSelectcommand

        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_contrato set  tipo_contrato = ?, agente_contrato = ?, data_inicio_contrato = ?, data_fim_contrato =?, clausulas_contrato = ?, remuneracao_contrato = ?, preco_exigido_contrato = ?, valor_total_contrato = ?, valor_carteira_contrato = ?, status_ativo_contrato = ? where id_contrato = ? and id_jogador_contrato = ?"

        objParam = sqlUpdateCommand.Parameters.Add("@tipo_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "tipo_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@agente_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "agente_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@data_inicio_contrato", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@data_fim_contrato", MySqlDbType.Date)
        objParam.SourceColumn = "data_fim_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@clausulas_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "clausulas_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@remuneracao_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "remuneracao_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@preco_exigido_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "preco_exigido_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@valor_total_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_total_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@valor_carteira_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_carteira_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@status_ativo_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "status_ativo_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_contrato"
        objParam.SourceVersion = DataRowVersion.Original

        objParam = sqlUpdateCommand.Parameters.Add("@id_jogador_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador_contrato"
        objParam.SourceVersion = DataRowVersion.Original

        contratoDtAdapter.UpdateCommand = sqlUpdateCommand

        Dim sqlInsertCommand As New MySqlCommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_contrato ( id_jogador_contrato,tipo_contrato , agente_contrato , data_inicio_contrato , data_fim_contrato , clausulas_contrato , remuneracao_contrato , preco_exigido_contrato , valor_total_contrato , valor_carteira_contrato, status_ativo_contrato) values(?,?,?,?,?,?,?,?,?,?,?)"

        objParam = sqlInsertCommand.Parameters.Add("@id_jogador_contrato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador_contrato"
        objParam.SourceVersion = DataRowVersion.Original

        objParam = sqlInsertCommand.Parameters.Add("@tipo_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "tipo_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@agente_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "agente_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@data_inicio_contrato", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@data_fim_contrato", MySqlDbType.Date)
        objParam.SourceColumn = "data_fim_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@clausulas_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "clausulas_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@remuneracao_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "remuneracao_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@preco_exigido_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "preco_exigido_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@valor_total_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_total_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@valor_carteira_contrato", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_carteira_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@status_ativo_contrato", MySqlDbType.Int16)
        objParam.SourceColumn = "status_ativo_contrato"
        objParam.SourceVersion = DataRowVersion.Current

        contratoDtAdapter.InsertCommand = sqlInsertCommand

        Return contratoDtAdapter

    End Function

End Module
