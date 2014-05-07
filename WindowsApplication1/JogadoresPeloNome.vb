Imports MySql.Data.MySqlClient
Module JogadoresPeloNome

    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim jogadoresNomeDtAdapter As New MySqlDataAdapter

        Dim sqlSelectNomeCommand As New MySqlCommand
        sqlSelectNomeCommand.Connection = conn
        sqlSelectNomeCommand.CommandText = "Select * from tabela_jogadores where nome_jogador = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectNomeCommand.Parameters.Add("@nome_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        jogadoresNomeDtAdapter.SelectCommand = sqlSelectNomeCommand

        Return jogadoresNomeDtAdapter
    End Function

End Module
