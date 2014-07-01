Imports MySql.Data.MySqlClient
Module Alertas
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        Dim sqlInsertCommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_termino_alerta between ? and ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@data_termino_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_termino_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlSelectcommand.Parameters.Add("@data_termino_alerta1", MySqlDbType.Date)
        objParam.SourceColumn = "data_termino_alerta1"
        objParam.SourceVersion = DataRowVersion.Current

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_alerta ( titulo_alerta , data_inicio_alerta , data_termino_alerta , mensagem_alerta, conta_alerta) values(?,?,?,?,?)"

        objParam = sqlInsertCommand.Parameters.Add("@titulo_alerta", MySqlDbType.VarChar)
        objParam.SourceColumn = "titulo_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@data_termino_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_termino_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@mensagem_alerta", MySqlDbType.VarChar)
        objParam.SourceColumn = "mensagem_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@conta_alerta", MySqlDbType.Int16)
        objParam.SourceColumn = "conta_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        alertasDtAdapter.InsertCommand = sqlInsertCommand

        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_alerta set titulo_alerta = ?, data_inicio_alerta = ?, data_termino_alerta = ?, mensagem_alerta = ?, conta_alerta = ? where id_alerta = ?"

        objParam = sqlUpdateCommand.Parameters.Add("@titulo_alerta", MySqlDbType.VarChar)
        objParam.SourceColumn = "titulo_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@data_termino_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_termino_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@mensagem_alerta", MySqlDbType.VarChar)
        objParam.SourceColumn = "mensagem_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@conta_alerta", MySqlDbType.Int16)
        objParam.SourceColumn = "conta_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_alerta", MySqlDbType.Int32)
        objParam.SourceColumn = "id_alerta"
        objParam.SourceVersion = DataRowVersion.Original


        alertasDtAdapter.UpdateCommand = sqlUpdateCommand

        Return alertasDtAdapter

    End Function
End Module
