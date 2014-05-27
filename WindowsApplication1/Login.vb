Imports MySql.Data.MySqlClient

Module Login
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim loginDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand

        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_login"

        loginDtAdapter.SelectCommand = sqlSelectcommand


        Return loginDtAdapter

    End Function
End Module
