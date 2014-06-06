Imports MySql.Data.MySqlClient

Public Class Friburguense
    'linha de modificacao
    Private frmListaJogadores As FrmListaJogador
    Private frmCadastrarAlertas As FrmCadastrarAlerta
    Private frmListaContatos As FrmListaContato
    Private frmCadastroContatos As FrmCadastroContato
    Private frmCalendario As FrmCalendario
    Private frmLogin As FrmLogin
    Private frmAlertaBox As FrmAlertaBox
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter

    Private Property objReader As MySqlDataReader
    Private Property objReader1 As MySqlDataReader

    Private Sub ProfissionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfissionalToolStripMenuItem.Click
        ListarJogadores("profissional")
    End Sub

    Private Sub JunioresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JunioresToolStripMenuItem.Click
        ListarJogadores("juniores")
    End Sub

    Private Sub JuvenilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuvenilToolStripMenuItem.Click
        ListarJogadores("juvenil")
    End Sub

    Private Sub InteressadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InteressadosToolStripMenuItem.Click
        Login("interessados")
        'ListarJogadores("interessado")
    End Sub
    Private Sub Login(tela As String)
        frmLogin = New FrmLogin
        frmLogin.abrirOutraTela(tela)
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub
    Private Sub ListarJogadores(categoria As String)
        frmListaJogadores = New FrmListaJogador
        frmListaJogadores.CategoriaJogador(categoria)
        frmListaJogadores.MdiParent = Me
        frmListaJogadores.Show()
    End Sub

    Private Sub Friburguense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Color.White

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
        Dim contador As Integer = 0
        conn = Conexao.getConexao
        conn.Open()
        Dim mesAtual As String = DateTime.Now.Month.ToString()
        Dim anoAtual As String = DateTime.Now.Year.ToString()
        Dim diaAtual As String = DateTime.Now.Day.ToString()
        Dim data1 As String = anoAtual + "-" + mesAtual + "-" + diaAtual
        adaptador = AlertaBox.getAdapter(conn, data1)
        'adaptador.SelectCommand.Parameters("@data_inicio_alerta").Value = data
        objReader = adaptador.SelectCommand().ExecuteReader
        Do While objReader.Read
            contador += 1
        Loop
        Dim titulo_alerta(contador) As String
        Dim data_termino(contador) As Date
        Dim count As Integer = 1
        conn.Close()
        conn.Open()

        objReader = adaptador.SelectCommand().ExecuteReader
        Do While objReader.Read
            'Dim cat As String
            ' cat = objReader.GetString(2)
            'Dim linha As New ListViewItem
            'If cat = categoria Then
            'linha.Text = objReader.GetValue(1).ToString
            'linha.SubItems.Add(objReader.GetValue(2).ToString)
            'linha.SubItems.Add(objReader.GetValue(3).ToString)
            'linha.SubItems.Add(objReader.GetValue(4).ToString)
            titulo_alerta(count) = objReader.GetValue(1).ToString
            data_termino(count) = objReader.GetValue(3)
            'MsgBox(titulo_alerta(count))
            count += 1
        Loop
        'If contador = 0 Then
        '    MessageBox.Show("Nenhum evento para o dia selecionado!")
        '    Me.Close()
        'End If
        conn.Close()

        For i = 1 To contador Step 1

            frmAlertaBox = New FrmAlertaBox
            frmAlertaBox.NomeAlerta(titulo_alerta(i), data_termino(i))
            frmAlertaBox.ValorN(i)

            frmAlertaBox.MdiParent = Me
            frmAlertaBox.Show()
        Next
    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
        frmCadastrarAlertas = New FrmCadastrarAlerta
        frmCadastrarAlertas.MdiParent = Me
        frmCadastrarAlertas.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem1.Click
        Login("cad_contato")
        'frmCadastroContatos = New FrmCadastroContato
        'frmCadastroContatos.MdiParent = Me
        'frmCadastroContatos.Show()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Login("lst_contato")
        'frmListaContatos = New FrmListaContato
        'frmListaContatos.MdiParent = Me
        'frmListaContatos.Show()
    End Sub

    Private Sub CalendárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendárioToolStripMenuItem.Click
        frmCalendario = New FrmCalendario
        frmCalendario.MdiParent = Me
        frmCalendario.Show()
    End Sub
End Class