Imports MySql.Data.MySqlClient

Module Jogadores

    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim jogadoresDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_jogadores where categoria_jogador = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectcommand.Parameters.Add("@categoria_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "categoria_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        jogadoresDtAdapter.SelectCommand = sqlSelectcommand

        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_jogadores set nome_jogador = ?, categoria_jogador = ?, nascimento_jogador = ?, posicao_jogador = ? where id_jogador = ?"

        objParam = sqlUpdateCommand.Parameters.Add("@nome_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@categoria_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "categoria_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@nascimento_jogador", MySqlDbType.Date)
        objParam.SourceColumn = "nascimento_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@posicao_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "posicao_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_jogador", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador"
        objParam.SourceVersion = DataRowVersion.Original

        jogadoresDtAdapter.UpdateCommand = sqlUpdateCommand

        Dim sqlInsertCommand As New MySqlCommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_jogadores ( nome_jogador, categoria_jogador, nascimento_jogador, posicao_jogador) values(?,?,?,?)"

        objParam = sqlInsertCommand.Parameters.Add("@nome_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@categoria_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "categoria_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@nascimento_jogador", MySqlDbType.Date)
        objParam.SourceColumn = "nascimento_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@posicao_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "posicao_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        jogadoresDtAdapter.InsertCommand = sqlInsertCommand

        Return jogadoresDtAdapter

    End Function

End Module
