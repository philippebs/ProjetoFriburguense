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

        Return alertasDtAdapter

    End Function
End Module
