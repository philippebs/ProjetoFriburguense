Imports MySql.Data.MySqlClient
Module ProcurarData
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim procurarDataDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_inicio_alerta = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        procurarDataDtAdapter.SelectCommand = sqlSelectcommand

        Return procurarDataDtAdapter

    End Function
End Module
