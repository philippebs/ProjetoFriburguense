Imports MySql.Data.MySqlClient

Module Contatos



    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim contatosDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_contatos"

        contatosDtAdapter.SelectCommand = sqlSelectcommand

        Dim objParam As MySqlParameter

        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_contatos set nome_contato = ?, email_contato = ?, telefone1_contato = ?, telefone2_contato  = ?, celular_contato  = ?, site_contato  = ? where id_contato = ?"

        objParam = sqlUpdateCommand.Parameters.Add("@nome_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@email_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "email_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@telefone1_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "telefone1_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@telefone2_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "telefone2_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@celular_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "celular_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@site_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "site_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_contato", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador"
        objParam.SourceVersion = DataRowVersion.Original

        contatosDtAdapter.UpdateCommand = sqlUpdateCommand

        Dim sqlInsertCommand As New MySqlCommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO tabela_contatos ( nome_contato, email_contato, telefone1_contato, telefone2_contato, celular_contato, site_contato ) values(?,?,?,?,?,?)"

        objParam = sqlInsertCommand.Parameters.Add("@nome_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@email_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "email_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@telefone1_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "telefone1_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@telefone2_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "telefone2_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@celular_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "celular_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@site_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "site_contato"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlInsertCommand.Parameters.Add("@id_jogador", MySqlDbType.Int32)
        objParam.SourceColumn = "id_jogador"
        objParam.SourceVersion = DataRowVersion.Original


        contatosDtAdapter.InsertCommand = sqlInsertCommand



        Return contatosDtAdapter

    End Function



End Module
