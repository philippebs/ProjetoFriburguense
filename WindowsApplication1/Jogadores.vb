Imports MySql.Data.MySqlClient

Module Jogadores

    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim jogadoresDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_jogadores"

        jogadoresDtAdapter.SelectCommand = sqlSelectcommand

        Dim objParam As MySqlParameter

        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_jogadores set nome_jogador = ?, categoria_jogador = ?, nascimento_jogador = ?, posicao_jogador = ?, agente_jogador = ?,tipo_jogador = ?, valor_jogador = ?, preco_jogador = ?, remuneracao_jogador = ?, valor_carteira_jogador = ?, iniciado = ?, termino = ?, clausulas_jogador = ? where id_jogador = ?"

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

        objParam = sqlUpdateCommand.Parameters.Add("@agente_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "agente_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@tipo_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "tipo_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@valor_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@preco_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "preco_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@remuneracao_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "remuneracao_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@valor_carteira_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_carteira_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@iniciado", MySqlDbType.Date)
        objParam.SourceColumn = "iniciado"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@termino", MySqlDbType.Date)
        objParam.SourceColumn = "termino"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@clausulas_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "clausulas_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_jogador", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador"
        objParam.SourceVersion = DataRowVersion.Original

        jogadoresDtAdapter.UpdateCommand = sqlUpdateCommand

        Dim sqlInsertCommand As New MySqlCommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_jogadores ( nome_jogador, categoria_jogador, nascimento_jogador, posicao_jogador, agente_jogador, valor_jogador, preco_jogador, remuneracao_jogador, valor_carteira_jogador, iniciado, termino, clausulas_jogador) values(?,?,?,?,?,?,?,?,?,?,?,?,?)"

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

        objParam = sqlInsertCommand.Parameters.Add("@agente_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "agente_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@tipo_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "tipo_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@valor_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@preco_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "preco_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@remuneracao_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "remuneracao_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@valor_carteira_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "valor_carteira_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@iniciado", MySqlDbType.Date)
        objParam.SourceColumn = "iniciado"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@termino", MySqlDbType.Date)
        objParam.SourceColumn = "termino"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@clausulas_jogador", MySqlDbType.VarChar)
        objParam.SourceColumn = "clausulas_jogador"
        objParam.SourceVersion = DataRowVersion.Current

        jogadoresDtAdapter.InsertCommand = sqlInsertCommand



        Return jogadoresDtAdapter

    End Function

End Module
