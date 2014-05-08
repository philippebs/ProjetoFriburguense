Imports MySql.Data.MySqlClient

Module ContatosPeloNome

    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim contatosNomeDtAdapter As New MySqlDataAdapter

        Dim sqlSelectNomeCommand As New MySqlCommand
        sqlSelectNomeCommand.Connection = conn
        sqlSelectNomeCommand.CommandText = "Select * from tabela_contatos where nome_contato = ?"

        Dim objParam As MySqlParameter

        objParam = sqlSelectNomeCommand.Parameters.Add("@nome_contato", MySqlDbType.VarChar)
        objParam.SourceColumn = "nome_contato"
        objParam.SourceVersion = DataRowVersion.Current

        contatosNomeDtAdapter.SelectCommand = sqlSelectNomeCommand

        Return contatosNomeDtAdapter
    End Function



End Module
