Imports MySql.Data.MySqlClient
Module AlertaBox
    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, d_i As String) As MySql.Data.MySqlClient.MySqlDataAdapter
        Dim alertasDtAdapter As New MySqlDataAdapter
        Dim sqlSelectcommand As New MySqlCommand
        sqlSelectcommand.Connection = conn
        Dim time As Date = Date.Parse(d_i)
        Dim data_ As Date
        Dim data_sete As Date
        data_sete = time.Date.AddMonths(7)
        data_ = Date.Now

        Dim mesAtual As String = data_.Month.ToString()
        Dim anoAtual As String = data_.Year.ToString()
        Dim diaAtual As String = data_.Day.ToString()
        Dim mesSete As String = data_sete.Month.ToString()
        Dim anoSete As String = data_sete.Year.ToString()
        Dim diaSete As String = data_sete.Day.ToString()
        Dim dataAtual As String = anoAtual + "-" + mesAtual + "-" + diaAtual
        Dim dataSete As String = anoSete + "-" + mesSete + "-" + diaSete

        sqlSelectcommand.CommandText = "Select * from tabela_alerta where data_termino_alerta >= '" + dataAtual + "' AND " + "data_inicio_alerta <= '" + dataAtual + "' AND data_termino_alerta <= '" + dataSete + "' order by data_termino_alerta desc"

        alertasDtAdapter.SelectCommand = sqlSelectcommand

        Return alertasDtAdapter

    End Function
End Module