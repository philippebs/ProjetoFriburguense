Imports MySql.Data.MySqlClient

Public Class FrmListaEventosDia
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Private Sub FrmListaEventosDia_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub FrmListaEventosDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = Conexao.getConexao
        adaptador = Jogadores.getAdapter(conn)
    End Sub
End Class