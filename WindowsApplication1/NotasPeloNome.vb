Imports MySql.Data.MySqlClient

Module NotasPeloNome

    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim notasNomeDtAdapter As New MySqlDataAdapter

        Dim sqlSelectNomeCommand As New MySqlCommand
        sqlSelectNomeCommand.Connection = conn
        sqlSelectNomeCommand.CommandText = "Select * from tabela_notas where nota = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectNomeCommand.Parameters.Add("@nota", MySqlDbType.VarChar)
        objParam.SourceColumn = "nota"
        objParam.SourceVersion = DataRowVersion.Current

        notasNomeDtAdapter.SelectCommand = sqlSelectNomeCommand

        Return notasNomeDtAdapter
    End Function



End Module
