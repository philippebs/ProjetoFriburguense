Imports MySql.Data.MySqlClient

Public Class FrmListaEventosDia
    Public frmCalendario As New FrmCalendario
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Public data As Date

    Public Sub atualizar()
        Dim contador As Integer = 0
        lstvAlertas.Items.Clear()
        conn.Open()

        adaptador.SelectCommand.Parameters("@data_inicio_alerta").Value = data
        objReader = adaptador.SelectCommand().ExecuteReader

        Do While objReader.Read
            'Dim cat As String
            ' cat = objReader.GetString(2)
            Dim linha As New ListViewItem
            'If cat = categoria Then
            linha.Text = objReader.GetValue(1).ToString
            linha.SubItems.Add(objReader.GetValue(2).ToString)
            linha.SubItems.Add(objReader.GetValue(3).ToString)
            linha.SubItems.Add(objReader.GetValue(4).ToString)
            lstvAlertas.Items.Add(linha)
            contador += 1
        Loop
        If contador = 0 Then
            MessageBox.Show("Nenhum evento para o dia selecionado!")
            Me.Close()
        End If
        conn.Close()
    End Sub

    Private Sub FrmListaEventosDia_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        atualizar()
    End Sub

    Private Sub FrmListaEventosDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        conn = Conexao.getConexao
        adaptador = ProcurarData.getAdapter(conn)
    End Sub
End Class