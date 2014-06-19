Imports MySql.Data.MySqlClient
Module AlertaBox
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, d_i As String) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        sqlSelectcommand.Connection = conn
        Dim time As Date = Date.Parse(d_i)
        Dim data_ As Date
        data_ = time.AddDays(30)
        Dim mesAtual As String = data_.Month.ToString()
        Dim anoAtual As String = data_.Year.ToString()
        Dim diaAtual As String = data_.Day.ToString()
        Dim data1 As String = anoAtual + "-" + mesAtual + "-" + diaAtual

        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_inicio_alerta <= '" + d_i + "' AND '" + data1 + "' > data_termino_alerta ORDER BY data_termino_alerta DESC"

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
