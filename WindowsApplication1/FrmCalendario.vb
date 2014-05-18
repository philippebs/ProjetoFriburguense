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

    Private Sub FrmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'exibe o mês atual
        'comboBoxMonth.Text = DateTime.Now.Month.ToString()

        'cmbMes.Text = DateTime.Now.Month.ToString()
        mesAtual = DateTime.Now.Month.ToString()
        'MessageBox.Show(lblMesAtual.Text)
        'obtem a cultura do windows
        CurrentCulture = Globalization.CultureInfo.CurrentCulture.Name
        'exibe o nome completo do mes atual
        lblMesAtual.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(mesAtual)) 'comboBoxMonth.Text))
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
        For i As Int32 = 1 To Dayz
            ndayz += 1
            'lblDayz = New Label()
            btnDayz = New Button
            AddHandler btnDayz.Click, AddressOf btnDayz_Click
            'lblDayz.Name = "B" & i
            btnDayz.Name = "b" & i
            'lblDayz.Text = i.ToString()
            btnDayz.Text = i.ToString
            'lblDayz.BorderStyle = BorderStyle.Fixed3D

            'If i = DateTime.Now.Day Then
            '    lblDayz.BackColor = Color.Green
            'ElseIf ndayz = 1 Then
            '    lblDayz.BackColor = Color.Red
            'ElseIf ndayz = 7 Then
            '    lblDayz.BackColor = Color.Blue
            'Else
            '    lblDayz.BackColor = Color.Aquamarine
            'End If
            'lblDayz.Font = label31.Font
            If i = DateTime.Now.Day Then
                btnDayz.BackColor = Color.Green
            ElseIf ndayz = 1 Then
                btnDayz.BackColor = Color.Red
            ElseIf ndayz = 7 Then
                btnDayz.BackColor = Color.Blue
            Else
                btnDayz.BackColor = Color.Aquamarine
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
        'retorna os valores padrão
        x = 0
        ndayz = 0
        y = 0
        'lblAnoCalendario.Text = mtxtAno.Text
    End Sub

    Private Sub btnDayz_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Add event handler code here.
        If sender.ToString = "System.Windows.Forms.Button, Text: 1" Then
            MessageBox.Show("è o 1!!")
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: 15" Then
            MessageBox.Show("è o 15")

        End If
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

                ElseIf ndayz = 1 Then
                    btnDayz.BackColor = Color.Red
                ElseIf ndayz = 7 Then
                    btnDayz.BackColor = Color.Blue
                Else
                    btnDayz.BackColor = Color.Aquamarine
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
            mtxtAno.Focus()
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
End Class