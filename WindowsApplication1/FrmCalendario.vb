Imports MySql.Data.MySqlClient
Public Class FrmCalendario
    Dim lblDayz As Label
    Dim mesAtual As String
    Dim btnDayz As Button
    Dim y As Int32 = 0
    Dim x As Int32
    Dim ndayz As Int32
    Dim Dayofweek, CurrentCulture As String
    Dim botao5 As Integer
    Dim irParProximoMes As Boolean = True
    Dim conn As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Private Property objReader As MySqlDataReader
    Dim count(31) As Integer

    Private Sub FrmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = Conexao.getConexao
        adaptador = Alertas.getAdapter(conn)
    End Sub

    Private Sub montarCalendario()
        'exibe o mês atual
        mesAtual = DateTime.Now.Month.ToString()
        'obtem a cultura do windows
        CurrentCulture = Globalization.CultureInfo.CurrentCulture.Name
        'exibe o nome completo do mes atual
        lblMesAtual.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(mesAtual)) 'comboBoxMonth.Text))
        formatarNomeMes()
        'obtem o numero de dias do mes e ano selecionado
        My.Application.ChangeCulture("en-za")
        Dim Dayz As Int32 = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)
        'exibe o ano atual no textbox
        lblAnoCalendario.Text = DateTime.Now.Year.ToString()
        'chama a função verificaDia
        verificaDia()
        marcarDia(Dayz.ToString)
        For i As Int32 = 1 To Dayz
            ndayz += 1
            btnDayz = New Button
            AddHandler btnDayz.Click, AddressOf btnDayz_Click
            btnDayz.Name = "b" & i
            btnDayz.Text = i.ToString
            If i = DateTime.Now.Day Then
                btnDayz.BackColor = Color.Green
                lblDiaAtualCor.Text = i & " de " & lblMesAtual.Text & " de " & lblAnoCalendario.Text
            ElseIf ndayz = 1 Then
                btnDayz.BackColor = Color.Red
            Else
                btnDayz.BackColor = Color.Aquamarine
            End If
            For k As Int16 = 0 To 30
                If count(k) = i Then
                    btnDayz.BackColor = Color.Silver
                End If
            Next
            btnDayz.SetBounds(x, y, 37, 27)
            x += 42
            If ndayz = 7 Then
                x = 0
                ndayz = 0
                y += 29
            End If
            pnlCalendarioDias.Controls.Add(btnDayz)
        Next
        'Fim teste
        'retorna os valores padrão
        x = 0
        ndayz = 0
        y = 0
    End Sub

    Private Sub formatarNomeMes()
        If lblMesAtual.Text = "January" Or lblMesAtual.Text = "janeiro" Then
            lblMesAtual.Text = "Janeiro"
        ElseIf lblMesAtual.Text = "February" Or lblMesAtual.Text = "fevereiro" Then
            lblMesAtual.Text = "Fevereiro"
        ElseIf lblMesAtual.Text = "March" Or lblMesAtual.Text = "março" Then
            lblMesAtual.Text = "Março"
        ElseIf lblMesAtual.Text = "April" Or lblMesAtual.Text = "abril" Then
            lblMesAtual.Text = "Abril"
        ElseIf lblMesAtual.Text = "May" Or lblMesAtual.Text = "maio" Then
            lblMesAtual.Text = "Maio"
        ElseIf lblMesAtual.Text = "June" Or lblMesAtual.Text = "junho" Then
            lblMesAtual.Text = "Junho"
        ElseIf lblMesAtual.Text = "July" Or lblMesAtual.Text = "julho" Then
            lblMesAtual.Text = "Julho"
        ElseIf lblMesAtual.Text = "August" Or lblMesAtual.Text = "agosto" Then
            lblMesAtual.Text = "Agosto"
        ElseIf lblMesAtual.Text = "September" Or lblMesAtual.Text = "setembro" Then
            lblMesAtual.Text = "Setembro"
        ElseIf lblMesAtual.Text = "October" Or lblMesAtual.Text = "outubro" Then
            lblMesAtual.Text = "Outubro"
        ElseIf lblMesAtual.Text = "November" Or lblMesAtual.Text = "novembro" Then
            lblMesAtual.Text = "Novembro"
        ElseIf lblMesAtual.Text = "December" Or lblMesAtual.Text = "dezembro" Then
            lblMesAtual.Text = "Dezembro"
        End If
    End Sub

    Private Sub marcarDia(diaMes As String)
        conn = Conexao.getConexao
        adaptador = Alertas.getAdapter(conn)
        conn.Open()
        Dim i As Integer = 0
        Dim pegarData As Boolean = True
        Dim data As Date = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-1"
        adaptador.SelectCommand.Parameters("@data_termino_alerta").Value = data
        data = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-" + diaMes.ToString
        adaptador.SelectCommand.Parameters("@data_termino_alerta1").Value = data

        objReader = adaptador.SelectCommand().ExecuteReader
        Dim diaMarcado As String = "0000000000"
        Dim dataV As Date

        Do While objReader.Read
            data = objReader.GetValue(3)
            If pegarData Then
                dataV = data
                count(i) = data.Day
                i += 1
            End If
            pegarData = False
            If data.Day <> dataV.Day And dataV <> data Then
                count(i) = data.Day
                i += 1
            End If
            dataV = data
        Loop
        conn.Close()
    End Sub

    Private Sub btnDayz_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim diaSelecionado As Integer = 0
        Dim dataSelecionada As Date
        If sender.ToString = "System.Windows.Forms.Button, Text: 1" Then
            diaSelecionado = 1
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 2" Then
            diaSelecionado = 2
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 3" Then
            diaSelecionado = 3
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 4" Then
            diaSelecionado = 4
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 5" Then
            diaSelecionado = 5
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 6" Then
            diaSelecionado = 6
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 7" Then
            diaSelecionado = 7
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 8" Then
            diaSelecionado = 8
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 9" Then
            diaSelecionado = 9
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 10" Then
            diaSelecionado = 10
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 11" Then
            diaSelecionado = 11
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 12" Then
            diaSelecionado = 12
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 13" Then
            diaSelecionado = 13
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 14" Then
            diaSelecionado = 14
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 15" Then
            diaSelecionado = 15
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 16" Then
            diaSelecionado = 16
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 17" Then
            diaSelecionado = 17
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 18" Then
            diaSelecionado = 18
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 19" Then
            diaSelecionado = 19
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 20" Then
            diaSelecionado = 20
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 21" Then
            diaSelecionado = 21
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 22" Then
            diaSelecionado = 22
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 23" Then
            diaSelecionado = 23
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 24" Then
            diaSelecionado = 24
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 25" Then
            diaSelecionado = 25
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 20" Then
            diaSelecionado = 20
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 21" Then
            diaSelecionado = 21
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 22" Then
            diaSelecionado = 22
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 23" Then
            diaSelecionado = 23
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 24" Then
            diaSelecionado = 24
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 25" Then
            diaSelecionado = 25
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 26" Then
            diaSelecionado = 26
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 27" Then
            diaSelecionado = 27
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 28" Then
            diaSelecionado = 28
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 29" Then
            diaSelecionado = 29
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 30" Then
            diaSelecionado = 30
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 31" Then
            diaSelecionado = 31
        End If

        dataSelecionada = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-" + diaSelecionado.ToString

        Dim frmListarEventosDia As New FrmListaEventosDia
        frmListarEventosDia.MdiParent = Me.MdiParent
        frmListarEventosDia.frmCalendario = Me
        frmListarEventosDia.data = dataSelecionada
        frmListarEventosDia.Show()
    End Sub

    Private Function verificaDia() As Int32
        Dim time As DateTime = Convert.ToDateTime(mesAtual + "/01/" + lblAnoCalendario.Text)
        'obtem o dia de inicia da semana para a data informada
        Dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString()
        If Dayofweek = "Sunday" Then
            x = 0
        ElseIf Dayofweek = "Monday" Then
            x = 0 + 42
            ndayz = 1
        ElseIf Dayofweek = "Tuesday" Then
            x = 0 + 84
            ndayz = 2
        ElseIf Dayofweek = "Wednesday" Then
            x = 0 + 84 + 42
            ndayz = 3
        ElseIf Dayofweek = "Thursday" Then
            x = 0 + 84 + 84
            ndayz = 4
        ElseIf Dayofweek = "Friday" Then
            x = 0 + 84 + 84 + 42
            ndayz = 5
        ElseIf Dayofweek = "Saturday" Then
            x = 0 + 84 + 84 + 84
            ndayz = 6
        End If
        Return x
    End Function

    Private Sub renderizaCalendario()
        Try
            Dim currentmonth, currentyear As Int32
            currentyear = Convert.ToInt32(lblAnoCalendario.Text)
            currentmonth = Convert.ToInt32(mesAtual)
            If irParProximoMes = True Then
                If (currentmonth = 12) Then
                    'vai para o proximo mes
                    currentyear += 1
                    currentmonth = 1
                    lblAnoCalendario.Text = currentyear.ToString
                    mesAtual = currentmonth.ToString()
                Else
                    currentmonth += 1
                    mesAtual = currentmonth.ToString()
                End If
            Else
                If currentmonth = 1 Then
                    'vai para o mes anterior
                    currentyear -= 1
                    'vai para o ultimo mes
                    currentmonth = 12
                    lblAnoCalendario.Text = currentyear.ToString
                    'mtxtAno.Text = currentyear.ToString()
                    mesAtual = currentmonth.ToString()
                Else
                    ''vai para o mes anterior
                    currentmonth -= 1
                    mesAtual = currentmonth.ToString()
                End If
            End If
            'limpa o painel
            pnlCalendarioDias.Controls.Clear()
            'Exibe o nome do mes na cultura do windows
            My.Application.ChangeCulture(CurrentCulture)
            'exibe o nome completo do mes selecionado
            lblMesAtual.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(currentmonth)
            formatarNomeMes()
            My.Application.ChangeCulture("en-us")
            Dim Dayz As Int32 = DateTime.DaysInMonth(Convert.ToInt32(lblAnoCalendario.Text), Convert.ToInt32(mesAtual))
            verificaDia()
            marcarDia(Dayz.ToString)
            For i As Int32 = 1 To Dayz
                ndayz += 1

                Dim mon As Int32 = Convert.ToInt32(mesAtual)
                Dim years As Int32 = Convert.ToInt32(lblAnoCalendario.Text)
                btnDayz = New Button
                AddHandler btnDayz.Click, AddressOf btnDayz_Click

                btnDayz.Text = i.ToString
                If ((i = DateTime.Now.Day) And (mon = DateTime.Now.Month) And (years = DateTime.Now.Year)) Then
                    btnDayz.BackColor = Color.Green
                    lblDiaAtualCor.Text = i & " de " & lblMesAtual.Text & " de " & lblAnoCalendario.Text
                ElseIf ndayz = 1 Then
                    btnDayz.BackColor = Color.Red
                Else
                    btnDayz.BackColor = Color.Aquamarine
                End If
                For k As Int16 = 0 To 30
                    If count(k) = i Then
                        btnDayz.BackColor = Color.Silver
                    End If
                Next
                btnDayz.SetBounds(x, y, 37, 27)
                x += 42
                If (ndayz = 7) Then
                    x = 0
                    ndayz = 0
                    y += 29
                End If
                pnlCalendarioDias.Controls.Add(btnDayz)
            Next
            x = 0
            ndayz = 0
            y = 0
        Catch et As FormatException
            MessageBox.Show("Data inválida")
        Catch ex As NullReferenceException
            MessageBox.Show("Data inválida")
        End Try
    End Sub

    Private Sub btnMesSeguinte_Click(sender As Object, e As EventArgs) Handles btnMesSeguinte.Click
        irParProximoMes = True
        renderizaCalendario()
    End Sub

    Private Sub btnMesAnterior_Click(sender As Object, e As EventArgs) Handles btnMesAnterior.Click
        irParProximoMes = False
        renderizaCalendario()
    End Sub

    Private Sub FrmCalendario_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        montarCalendario()
    End Sub
End Class