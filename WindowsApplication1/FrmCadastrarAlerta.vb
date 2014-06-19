Public Class FrmCadastrarAlerta

    Public frmCadastroJogador As FrmCadastroJog
    Public frmCadastroContatos As FrmCadastroContato
    Public frmCadastroNota As FrmCadastroContato


    Private Sub txtTexto_Click(sender As Object, e As EventArgs) Handles txtTexto.Click
        txtTexto.Text = ""
    End Sub

    Private Sub btnAlertaCancelar_Click(sender As Object, e As EventArgs) Handles btnAlertaCancelar.Click
        Me.Close()
    End Sub


End Class