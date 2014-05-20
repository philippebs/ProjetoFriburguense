
Imports MySql.Data.MySqlClient

Module Notas



    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, id As String) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim notasDtAdapter As New MySqlDataAdapter
        Dim objParam As MySqlParameter
        Dim codigo_contato As String = id
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_notas where id_contato = " + codigo_contato

        'objParam = sqlSelectcommand.Parameters.Add("@id_contato", MySqlDbType.Int32)
        'objParam.SourceColumn = "id_contato"
        'objParam.SourceVersion = DataRowVersion.Current
        notasDtAdapter.SelectCommand = sqlSelectcommand



        Dim sqlUpdateCommand As New MySqlCommand

        sqlUpdateCommand.Connection = conn
        sqlUpdateCommand.CommandText = "update tabela_notas set nota = ? where id_nota = ?"

        objParam = sqlUpdateCommand.Parameters.Add("@nota", MySqlDbType.VarChar)
        objParam.SourceColumn = "nota"
        objParam.SourceVersion = DataRowVersion.Current

        objParam = sqlUpdateCommand.Parameters.Add("@id_nota", MySqlDbType.Int32)
        objParam.SourceColumn = "id_nota"
        objParam.SourceVersion = DataRowVersion.Original

        notasDtAdapter.UpdateCommand = sqlUpdateCommand

        Dim sqlInsertCommand As New MySqlCommand

        sqlInsertCommand.Connection = conn
        sqlInsertCommand.CommandText = "INSERT INTO friburguense.tabela_notas (id_nota, id_contato, nota) VALUES (?, " + codigo_contato + ", ?);"

        objParam = sqlInsertCommand.Parameters.Add("@id_nota", MySqlDbType.Int32)
        objParam.SourceColumn = "id_nota"
        objParam.SourceVersion = DataRowVersion.Original

        'objParam = sqlSelectcommand.Parameters.Add("@id_contato", MySqlDbType.Int32)
        'objParam.SourceColumn = "id_contato"
        'objParam.SourceVersion = DataRowVersion.Current


        objParam = sqlInsertCommand.Parameters.Add("@nota", MySqlDbType.VarChar)
        objParam.SourceColumn = "nota"
        objParam.SourceVersion = DataRowVersion.Current

        

        notasDtAdapter.InsertCommand = sqlInsertCommand

        Dim sqlDeletecommand As New MySqlCommand
        sqlDeletecommand.Connection = conn
        sqlDeletecommand.CommandText = "DELETE FROM friburguense.tabela_notas WHERE tabela_notas.nota = '" + codigo_contato + "'"

        'objParam = sqlSelectcommand.Parameters.Add("@id_contato", MySqlDbType.Int32)
        'objParam.SourceColumn = "id_contato"
        'objParam.SourceVersion = DataRowVersion.Current
        notasDtAdapter.DeleteCommand = sqlDeletecommand



        Return notasDtAdapter

    End Function



End Module