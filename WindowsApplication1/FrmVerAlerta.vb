Imports MySql.Data.MySqlClient

Public Class FrmVerAlerta
    Public frmAlertaBox As New FrmAlertaBox
    Dim codigo_alerta As String = ""
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private Property objReader2 As MySqlDataReader
    'Private id_contato As Integer = 0
    Private adaptador2 As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Sub FrmVerAlerta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = Conexao.getConexao
        'conn.Open()
        'adaptador = VerAlerta.getAdapter(conn, codigo_alerta)


        'adaptador.SelectCommand.Parameters("@id_alerta").Value = codigo_alerta
        'objReader = adaptador.SelectCommand().ExecuteReader
        'Do While objReader.Read
        '    id_contato = objReader.GetValue(0)
        'Loop
        'conn.Close()
        conn.Open()

        adaptador2 = VerAlerta.getAdapter(conn, codigo_alerta)
        'adaptador2.SelectCommand.Parameters("@titulo_alerta").Value = txtTitulo.Text
        objReader2 = adaptador2.SelectCommand().ExecuteReader


        Do While objReader2.Read
            'Dim cat As String
            ' cat = objReader.GetString(2)
            'Dim linha As New ListViewItem
            'If cat = categoria Then
            txtTitulo.Text = objReader2.GetString(1)
            mtxtAlertaDataInicio.Text = objReader2.GetString(2)
            mtxtAlertaDataTermino.Text = objReader2.GetString(3)
            txtTexto.Text = objReader2.GetString(4)
            ' linha.SubItems.Add(objReader.GetString(4))
            'linha.SubItems.Add(objReader.GetInt32(3).ToString)
            'lstvNotas.Items.Add(linha)
            'End If
            txtTitulo.Enabled = False
            mtxtAlertaDataInicio.Enabled = False
            mtxtAlertaDataTermino.Enabled = False
            txtTexto.Enabled = False

        Loop

        conn.Close()
    End Sub
    Public Sub pegarCodigo(codigo As String)
        codigo_alerta = codigo
    End Sub
End Class