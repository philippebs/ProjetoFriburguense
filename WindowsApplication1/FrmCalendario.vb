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


    Private Sub FrmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = Conexao.getConexao
        adaptador = Alertas.getAdapter(conn)
        'montarCalendario()
    End Sub

    Private Sub montarCalendario()
        'exibe o mês atual
        'comboBoxMonth.Text = DateTime.Now.Month.ToString()

        'cmbMes.Text = DateTime.Now.Month.ToString()
        mesAtual = DateTime.Now.Month.ToString()
        'MessageBox.Show(lblMesAtual.Text)
        'obtem a cultura do windows
        CurrentCulture = Globalization.CultureInfo.CurrentCulture.Name
        'exibe o nome completo do mes atual
        lblMesAtual.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(mesAtual)) 'comboBoxMonth.Text))
        formatarNomeMes()
        'lblMesAtual.Text = "0" & lblMesAtual.Text
        'obtem o numero de dias do mes e ano selecionado
        My.Application.ChangeCulture("en-za")
        Dim Dayz As Int32 = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)
        'exibe o ano atual no textbox
        'textBoxYear.Text = DateTime.Now.Year.ToString()
        'mtxtAno.Text = DateTime.Now.Year.ToString()
        lblAnoCalendario.Text = DateTime.Now.Year.ToString()
        'MessageBox.Show(lblAnoCalendario.Text)
        'chama a função verificaDia
        verificaDia()
        'conn.Open()
        ''Teste 
        'Dim data As Date = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-01"
        ''        MessageBox.Show(data)
        'adaptador.SelectCommand.Parameters("@data_inicio_alerta").Value = data
        'data = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-" + Dayz.ToString
        'adaptador.SelectCommand.Parameters("@data_inicio_alerta1").Value = data
        'objReader = adaptador.SelectCommand().ExecuteReader
        'Dim diaMarcado As String = "0000000000"

        'Do While objReader.Read
        '    diaMarcado = objReader.GetValue(2).ToString
        '    MessageBox.Show(diaMarcado.Length & " - " & diaMarcado.Substring(0, 2))
        '    diaMarcado = diaMarcado.Substring(0, 2)
        '    MessageBox.Show(diaMarcado) '.Substring(8, 2)) 'objReader.GetValue(1).ToString)
        'Loop

        For i As Int32 = 1 To Dayz
            ndayz += 1
            'lblDayz = New Label()
            btnDayz = New Button
            AddHandler btnDayz.Click, AddressOf btnDayz_Click
            'lblDayz.Name = "B" & i
            btnDayz.Name = "b" & i
            'lblDayz.Text = i.ToString()
            btnDayz.Text = i.ToString

            If i = DateTime.Now.Day Then
                btnDayz.BackColor = Color.Green
                lblDiaAtualCor.Text = i & " de " & lblMesAtual.Text & " de " & lblAnoCalendario.Text
            ElseIf ndayz = 1 Then
                btnDayz.BackColor = Color.Red
            Else
                btnDayz.BackColor = Color.Aquamarine
            End If
            'If i = diaMarcado.ToString Then
            '    MessageBox.Show(diaMarcado)
            '    btnDayz.BackColor = Color.Coral
            'End If
            If marcarDia(i, Dayz.ToString) Then
                btnDayz.BackColor = Color.Silver
            End If
            btnDayz.SetBounds(x, y, 37, 27)
            'lblDayz.SetBounds(x, y, 37, 27)
            x += 42
            If ndayz = 7 Then
                x = 0
                ndayz = 0
                y += 29
            End If
            'panel1.Controls.Add(lblDayz)
            pnlCalendarioDias.Controls.Add(btnDayz)
            'lblDayz.Enabled = True
        Next
        'Dim tamanho = diaMarcado.Length - 2

        'Fim teste

        'retorna os valores padrão
        x = 0
        ndayz = 0
        y = 0
        'lblAnoCalendario.Text = mtxtAno.Text
        'conn.Clone()

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

    Private Function marcarDia(indice As Integer, diaMes As String) As Boolean
        'conn.Open()
        conn = Conexao.getConexao
        adaptador = Alertas.getAdapter(conn)
        conn.Open()
        Dim contador = 0
        'Teste 
        Dim data As Date = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-1"
        '        MessageBox.Show(data)
        adaptador.SelectCommand.Parameters("@data_termino_alerta").Value = data
        data = lblAnoCalendario.Text + "-" + mesAtual.ToString + "-" + diaMes.ToString
<<<<<<< HEAD
        adaptador.SelectCommand.Parameters("@data_termino_alerta1").Value = data
=======
        adaptador.SelectCommand.Parameters("@data_inicio_alerta1").Value = data

>>>>>>> 7588756032e05a95ea49ae00e8f2881d54a256ac
        objReader = adaptador.SelectCommand().ExecuteReader
        Dim diaMarcado As String = "0000000000"

        Do While objReader.Read
            data = objReader.GetValue(2)
            'MessageBox.Show(data.Day)
            'diaMarcado = objReader.GetValue(2).ToString
            'MessageBox.Show(diaMarcado.ToString)
            ' MessageBox.Show(diaMarcado.Length & " - " & diaMarcado.Substring(0, 2))

            '            MessageBox.Show(diaMarcado)
            'If diaMarcado.Substring(1, 1) = "/" Then
            '    diaMarcado = diaMarcado.Substring(2, 1)
            'Else
            '    diaMarcado = diaMarcado.Substring(3, 2)
            'End If
            If data.Day = indice Then
                contador += 1
            End If
            'MessageBox.Show(diaMarcado) '.Substring(8, 2)) 'objReader.GetValue(1).ToString)
        Loop

        conn.Close()
        If contador > 0 Then
            'MessageBox.Show(diaMarcado.ToString)
            Return True
        Else
            Return False
        End If

        'Return True
    End Function


    Private Sub btnDayz_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add event handler code here.
        'Dim linha As New ListViewItem
        Dim diaSelecionado As Integer = 0
        'conn = Conexao.getConexao
        'adaptador = ProcurarData.getAdapter(conn)
        'conn.Open()
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

        'adaptador.SelectCommand.Parameters("@data_inicio_alerta").Value = dataSelecionada
        'objReader = adaptador.SelectCommand().ExecuteReader

        'Do While objReader.Read
        '    'MessageBox.Show("Id: " & objReader.GetValue(0).ToString)
        '    'MessageBox.Show("Titulo: " & objReader.GetValue(1).ToString)
        '    'MessageBox.Show("Data inicio: " & objReader.GetValue(2).ToString)
        '    'MessageBox.Show("Data fim: " & objReader.GetValue(3).ToString)
        '    'MessageBox.Show("Mensagem: " & objReader.GetValue(4).ToString)
        '    linha.Text = objReader.GetValue(1).ToString
        '    linha.SubItems.Add(objReader.GetValue(2).ToString)
        '    linha.SubItems.Add(objReader.GetValue(3).ToString)
        '    linha.SubItems.Add(objReader.GetValue(4).ToString)

        'Loop
        'conn.Close()
    End Sub

    Public Sub atualizar()
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
            'End If

        Loop

        conn.Close()
    End Sub

    Private Function verificaDia() As Int32
        'Dim mes = lblMesAtual.Text
        'If mes <> "10" And mes <> "11" And mes <> "12" Then
        '    mes = "0" & mes
        'End If
        'Dim ano = lblAnoCalendario.Text
        Dim time As DateTime = Convert.ToDateTime(mesAtual + "/01/" + lblAnoCalendario.Text) 'mtxtAno.Text)
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
            currentyear = Convert.ToInt32(lblAnoCalendario.Text) 'mtxtAno.Text)
            currentmonth = Convert.ToInt32(mesAtual)
            If irParProximoMes = True Then
                If (currentmonth = 12) Then
                    'vai para o proximo mes
                    currentyear += 1
                    currentmonth = 1
                    lblAnoCalendario.Text = currentyear.ToString
                    'mtxtAno.Text = currentyear.ToString()
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
            For i As Int32 = 1 To Dayz
                ndayz += 1
                'lblDayz = New Label()
                'lblDayz.Text = i.ToString()
                'lblDayz.BorderStyle = BorderStyle.Fixed3D
                Dim mon As Int32 = Convert.ToInt32(mesAtual)
                Dim years As Int32 = Convert.ToInt32(lblAnoCalendario.Text)
                'If ((i = DateTime.Now.Day) And (mon = DateTime.Now.Month) And (years = DateTime.Now.Year)) Then
                '    'destaca o dia atual
                '    lblDayz.BackColor = Color.Green
                'ElseIf (ndayz = 1) Then
                '    lblDayz.BackColor = Color.Red
                'ElseIf ndayz = 7 Then
                '    lblDayz.BackColor = Color.Blue
                'Else
                '    'define a cor dos outros dias do mes
                '    lblDayz.BackColor = Color.Aquamarine
                'End If
                'lblDayz.Font = label31.Font
                'lblDayz.SetBounds(x, y, 37, 27)v
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

                If marcarDia(i, Dayz.ToString) Then
                    btnDayz.BackColor = Color.Silver
                End If
                btnDayz.SetBounds(x, y, 37, 27)



                x += 42
                If (ndayz = 7) Then
                    x = 0
                    ndayz = 0
                    y += 29
                End If
                'panel1.Controls.Add(lblDayz)
                pnlCalendarioDias.Controls.Add(btnDayz)
            Next
            x = 0
            ndayz = 0
            y = 0
            'lblAnoCalendario.Text = mtxtAno.Text
        Catch et As FormatException
            MessageBox.Show("Data inválida")
            'mtxtAno.Focus()
        Catch ex As NullReferenceException
            MessageBox.Show("Data inválida")
            'mtxtAno.Focus()
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