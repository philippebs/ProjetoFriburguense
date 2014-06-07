
Imports MySql.Data.MySqlClient
Public Class FrmListaContato
    Public frmLogin As New FrmLogin
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim dados As New DataTable
    Dim categoria As String

    Private Property objReader As MySqlDataReader

    'Dim conexao As New MySqlConnection
    'Dim comando As New MySqlCommand
    'Dim adaptador As New MySqlDataAdapter
    'Dim dados As New DataTable
    'Dim sql As String
    

    Public Sub atualizar()
        lstvContato.Items.Clear()
        conn.Open()

        objReader = adaptador.SelectCommand().ExecuteReader



        Do While objReader.Read
            'Dim cat As String
            ' cat = objReader.GetString(2)
            Dim linha As New ListViewItem
            'If cat = categoria Then
            linha.Text = objReader.GetString(1)
            linha.SubItems.Add(objReader.GetString(2))
            linha.SubItems.Add(objReader.GetString(4))
            'linha.SubItems.Add(objReader.GetInt32(3).ToString)
            lstvContato.Items.Add(linha)
            'End If

        Loop

        conn.Close()
    End Sub

    Private Sub FrmListaContato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = Conexao.getConexao
        adaptador = Contatos.getAdapter(conn)
    End Sub

    Private Sub FrmListaContato_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        atualizar()
    End Sub

    Private Sub btnCadastrarContato_Click(sender As Object, e As EventArgs) Handles btnCadastrarContato.Click
        Dim frmCadastroContato As New FrmCadastroContato()
        frmCadastroContato.MdiParent = Me.MdiParent
        frmCadastroContato.frmListarContatos = Me
        frmCadastroContato.Show()
    End Sub

    Private Sub btnListaMostrarContato_Click(sender As Object, e As EventArgs) Handles btnListaMostrarContato.Click
        If lstvContato.SelectedIndices.Count > 0 Then
            Dim frmCadastro As New FrmCadastroContato()
            frmCadastro.MdiParent = Me.MdiParent
            frmCadastro.frmListarContatos = Me
            frmCadastro.linha = lstvContato.SelectedItems(0)
            ' MessageBox.Show(lstvJogador.SelectedItems(0).SubItems(0).Text)
            frmCadastro.btnCadastarContato.Text = "Salvar"
            frmCadastro.Show()
        Else
            MessageBox.Show("linha não selecionada")
        End If
    End Sub
End Class