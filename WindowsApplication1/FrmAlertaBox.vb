Public Class FrmAlertaBox
    Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim newy As Integer = 0
    Dim nome As String
    Dim data_t As Date
    Dim y As Integer
    Private id As Integer = -1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static i As Integer = 10
        If i <= 210 Then
            Me.Location = New Point(intX - 215, newy)
            newy -= 14
            i += 10
            Me.Refresh()
        Else
            Timer1.Stop()
        End If
    End Sub
    'Dim teste As Form2
    Public Sub ValorN(n As Integer)
        y = n
    End Sub

    Public Sub idAlerta(ByVal idTela As Integer)
        id = idTela
    End Sub

    Public Sub NomeAlerta(nomeAlerta As String, dataTermino As Date)
        nome = nomeAlerta
        data_t = dataTermino
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Height = 100
        'Me.Width = 200
        Dim z = y * 110
        Me.Location = New Point(intX - 200, intY - 30)

        newy = intY - z + 199
        Dim data_atual As Date = Now
        'MsgBox(data_t.AddDays(30))

        If (data_atual.AddDays(15) >= data_t) Then
            Me.BackColor = Color.Yellow
        End If
        If (data_atual.AddDays(7) >= data_t) Then
            Me.BackColor = Color.Red
        End If
        Label3.Text = nome
        Label2.Text = data_t

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmVerAlerta = New FrmVerAlerta
        frmVerAlerta.MdiParent = Me.MdiParent
        frmVerAlerta.frmAlertaBox = Me
        'y = codigo ou ID
        'MessageBox.Show(y)
        frmVerAlerta.pegarCodigo(id)
        frmVerAlerta.Show()
    End Sub
End Class
