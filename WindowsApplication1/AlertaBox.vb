Imports MySql.Data.MySqlClient
Module AlertaBox
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, d_i As String) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        sqlSelectcommand.Connection = conn
        Dim time As Date = Date.Parse(d_i)
        Dim data_ As Date
        data_ = time.AddMonths(7)
        Dim mesAtual As String = data_.Month.ToString()
        Dim anoAtual As String = data_.Year.ToString()
        Dim diaAtual As String = data_.Day.ToString()
        Dim data1 As String = anoAtual + "-" + mesAtual + "-" + diaAtual

<<<<<<< HEAD
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_termino_alerta >= '" + d_i + "' order by data_termino_alerta desc" 'AND '" + data1 + "' > data_termino_alerta"
=======
        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_termino_alerta >= '" + d_i + "'AND data_termino_alerta < '" + data1 + "' "
>>>>>>> 197579630b43f755dc247efe7d5fe0db480ec750


        'Dim objParam As MySqlParameter

        'objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta", MySqlDbType.Date)
        'objParam.SourceColumn = "data_inicio_alerta"
        'objParam.SourceVersion = DataRowVersion.Current

        'objParam = sqlSelectcommand.Parameters.Add("@data_inicio_alerta1", MySqlDbType.Date)
        'objParam.SourceColumn = "data_inicio_alerta1"
        'objParam.SourceVersion = DataRowVersion.Current

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        Return alertasDtAdapter

    End Function
End Module
