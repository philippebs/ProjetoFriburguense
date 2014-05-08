Public Class Friburguense

    Private frmListaJogadores As FrmListaJogador
<<<<<<< HEAD
    Private frmListaContatos As FrmListaContato

=======
    Private frmCadastrarAlertas As FrmCadastrarAlerta
>>>>>>> c776088c014cdd54e926387b1451f60db2eb812e

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
        ListarJogadores("interessado")
    End Sub

    Private Sub ListarJogadores(categoria As String)
        frmListaJogadores = New FrmListaJogador
        frmListaJogadores.CategoriaJogador(categoria)
        frmListaJogadores.MdiParent = Me
        frmListaJogadores.Show()
<<<<<<< HEAD
    End Sub

    Private Sub ListarContatos()
        frmListaContatos = New FrmListaContato

        frmListaContatos.MdiParent = Me
        frmListaContatos.Show()
=======
>>>>>>> c776088c014cdd54e926387b1451f60db2eb812e
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
    End Sub

<<<<<<< HEAD
    Private Sub ContatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem.Click
        ListarContatos()
=======
    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click
        frmCadastrarAlertas = New FrmCadastrarAlerta
        frmCadastrarAlertas.MdiParent = Me
        frmCadastrarAlertas.Show()
>>>>>>> c776088c014cdd54e926387b1451f60db2eb812e
    End Sub
End Class