'Public Class FrmDeletarNota
'    Function getAdapter(conn As MySql.Data.MySqlClient.MySqlConnection, id As String) As MySql.Data.MySqlClient.MySqlDataAdapter
'        Dim notasDtAdapter As New MySqlDataAdapter
'        Dim objParam As MySqlParameter
'        Dim codigo_contato As String = id
'        Dim sqlSelectcommand As New MySqlCommand

'        sqlSelectcommand.Connection = conn
'        sqlSelectcommand.CommandText = "Select * from tabela_notas where id_contato = " + codigo_contato

'        'objParam = sqlSelectcommand.Parameters.Add("@id_contato", MySqlDbType.Int32)
'        'objParam.SourceColumn = "id_contato"
'        'objParam.SourceVersion = DataRowVersion.Current
'        notasDtAdapter.SelectCommand = sqlSelectcommand
'End Class
