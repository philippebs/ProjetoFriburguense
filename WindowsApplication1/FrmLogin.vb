﻿Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class FrmLogin
    Private frmListaJogadores As FrmListaJogador
    Private frmCadastroContatos As FrmCadastroContato
    Private frmListaContatos As FrmListaContato
    Public abrir As String
    Private senha As String
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private adaptador As MySql.Data.MySqlClient.MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = Conexao.getConexao
        conn.Open()
        adaptador = Login.getAdapter(conn)
        'senha = adaptador.SelectCommand.Parameters("@senha").Value
        objReader = adaptador.SelectCommand().ExecuteReader
        'MsgBox(objReader)
        Do While objReader.Read
            senha = objReader.GetString(0)
        Loop

        If GeraMD5(txtSenha.Text) = senha Then

            If abrir = "interessados" Then
                ListarJogadores(abrir)
            End If
            If abrir = "cad_contato" Then
                frmCadastroContatos = New FrmCadastroContato
                'frmCadastroContatos.MdiParent = Me
                frmCadastroContatos.Show()
            End If
            If abrir = "lst_contato" Then
                frmListaContatos = New FrmListaContato
                'frmCadastroContatos.MdiParent = Me
                frmListaContatos.Show()
            End If
        Else
            MsgBox("Senha incorreta, por favor tente novamente")
        End If
        conn.Close()
        Me.Close()
    End Sub
    Private Function GeraMD5(texto As String) As String
        'Criamos a instância do Provider MD5
        Dim provider As New MD5CryptoServiceProvider
        Dim bytHash() As Byte
        Dim hash As String = String.Empty

        'Geramos o Hash
        bytHash = provider.ComputeHash(System.Text.Encoding.UTF8.GetBytes(texto))
        provider.Clear()
        'Convertemos de Bit para String e removemos o caracter -
        hash = BitConverter.ToString(bytHash).Replace("-", String.Empty)
        Return hash

    End Function
    Public Function abrirOutraTela(tela As String)
        abrir = tela
        Return True
    End Function
    Private Sub ListarJogadores(categoria As String)
        frmListaJogadores = New FrmListaJogador
        frmListaJogadores.CategoriaJogador(categoria)
        'frmListaJogadores.MdiParent = Me
        frmListaJogadores.Show()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class