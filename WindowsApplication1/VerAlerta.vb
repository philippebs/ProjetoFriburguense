Imports MySql.Data.MySqlClient

Module VerAlerta
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, d_i As String) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        sqlSelectcommand.Connection = conn
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where id_alerta = " + d_i

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        Return alertasDtAdapter

    End Function
End Module


