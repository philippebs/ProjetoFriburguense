Imports MySql.Data.MySqlClient


Public Class Conexao
    Private Shared stringconnection As String = "SERVER=localhost;user id=root;password=;database=friburguense"
    Protected Sub New()
    End Sub

    Public Shared Function getConexao() As MySqlConnection
        Dim objConexao As MySqlConnection = Nothing
        objConexao = New MySqlConnection()
        objConexao.ConnectionString = stringconnection
        Return objConexao
    End Function
End Class
