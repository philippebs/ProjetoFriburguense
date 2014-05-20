Imports MySql.Data.MySqlClient
Module Alertas
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_inicio_alerta between ? AND ?"

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta1", MySqlDbType.Date)
        objParam.SourceColumn = "data_inicio_alerta1"
        objParam.SourceVersion = DataRowVersion.Current

        Return alertasDtAdapter
    End Function
End Module
