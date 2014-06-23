Imports MySql.Data.MySqlClient

Public Class FrmListaJogador
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim dados As New DataTable
    Dim categoria As String
    Public frmLogin As New FrmLogin
    Private Property objReader As MySqlDataReader
    Public Sub CategoriaJogador(cat_jogador As String)
        categoria = cat_jogador
    End Sub

    Public Sub atualizar()
        lstvJogador.Items.Clear()
        conn.Open()

        adaptador.SelectCommand.Parameters("@categoria_jogador").Value = categoria.ToString
        objReader = adaptador.SelectCommand().ExecuteReader

        Do While objReader.Read
            Dim linha As New ListViewItem
            linha.Text = objReader.GetString(1)
            linha.SubItems.Add(objReader.GetString(4))
            lstvJogador.Items.Add(linha)
        Loop
        conn.Close()
    End Sub

    Private Sub FrmListaJogador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        conn = Conexao.getConexao
        adaptador = Jogadores.getAdapter(conn)
    End Sub

    Private Sub FrmListaJogador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        atualizar()
    End Sub

    Private Sub btnCadastrarjogador_Click(sender As Object, e As EventArgs) Handles btnCadastrarjogador.Click
            Dim frmCadastro As New FrmCadastroJog()
            frmCadastro.MdiParent = Me.MdiParent
            frmCadastro.frmListarJogadores = Me
            frmCadastro.Show()
    End Sub

    Private Sub btnListaMostrar_Click(sender As Object, e As EventArgs) Handles btnListaMostrar.Click
        If lstvJogador.SelectedIndices.Count > 0 Then
            Dim frmCadastro As New FrmCadastroJog()
            frmCadastro.MdiParent = Me.MdiParent
            frmCadastro.frmListarJogadores = Me
            frmCadastro.linha = lstvJogador.SelectedItems(0)
            frmCadastro.btnCadastarJogador.Text = "Salvar"
            frmCadastro.Show()
        Else
            MessageBox.Show("linha não selecionada")
        End If
    End Sub
End Class