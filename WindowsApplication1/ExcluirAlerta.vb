Imports MySql.Data.MySqlClient
Module ExcluirAlerta
   Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        Dim sqlDeleteCommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "SELECT * FROM tabela_alerta WHERE titulo_alerta = ? "

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@titulo_alerta", MySqlDbType.VarChar)
        objParam.SourceColumn = "titulo_alerta"
        objParam.SourceVersion = DataRowVersion.Current

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        sqlDeleteCommand.Connection = conn
        sqlDeleteCommand.CommandText = "DELETE FROm tabela_alerta WHERE id_alerta = ?"

        objParam = sqlDeleteCommand.Parameters.Add("@id_alerta", MySqlDbType.Int16)
        objParam.SourceColumn = "id_alerta"
        objParam.SourceVersion = DataRowVersion.Original

        alertasDtAdapter.DeleteCommand = sqlDeleteCommand


        Return alertasDtAdapter

    End Function
End Module
