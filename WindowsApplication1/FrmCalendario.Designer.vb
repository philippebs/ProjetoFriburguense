<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalendario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlCalendarioDias = New System.Windows.Forms.Panel()
        Me.btnMesAnterior = New System.Windows.Forms.Button()
        Me.btnMesSeguinte = New System.Windows.Forms.Button()
        Me.lblMesAtual = New System.Windows.Forms.Label()
        Me.lblAnoCalendario = New System.Windows.Forms.Label()
        Me.mtxtAno = New System.Windows.Forms.MaskedTextBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDiaAtualCor = New System.Windows.Forms.Label()
        Me.btnDiaAtualCor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnlCalendarioDias
        '
        Me.pnlCalendarioDias.Location = New System.Drawing.Point(32, 144)
        Me.pnlCalendarioDias.Name = "pnlCalendarioDias"
        Me.pnlCalendarioDias.Size = New System.Drawing.Size(295, 171)
        Me.pnlCalendarioDias.TabIndex = 0
        '
        'btnMesAnterior
        '
        Me.btnMesAnterior.Location = New System.Drawing.Point(32, 76)
        Me.btnMesAnterior.Name = "btnMesAnterior"
        Me.btnMesAnterior.Size = New System.Drawing.Size(26, 23)
        Me.btnMesAnterior.TabIndex = 1
        Me.btnMesAnterior.Text = "<"
        Me.btnMesAnterior.UseVisualStyleBackColor = True
        '
        'btnMesSeguinte
        '
        Me.btnMesSeguinte.Location = New System.Drawing.Point(301, 76)
        Me.btnMesSeguinte.Name = "btnMesSeguinte"
        Me.btnMesSeguinte.Size = New System.Drawing.Size(26, 23)
        Me.btnMesSeguinte.TabIndex = 2
        Me.btnMesSeguinte.Text = ">"
        Me.btnMesSeguinte.UseVisualStyleBackColor = True
        '
        'lblMesAtual
        '
        Me.lblMesAtual.AutoSize = True
        Me.lblMesAtual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesAtual.Location = New System.Drawing.Point(76, 76)
        Me.lblMesAtual.Name = "lblMesAtual"
        Me.lblMesAtual.Size = New System.Drawing.Size(42, 20)
        Me.lblMesAtual.TabIndex = 3
        Me.lblMesAtual.Text = "Mês"
        '
        'lblAnoCalendario
        '
        Me.lblAnoCalendario.AutoSize = True
        Me.lblAnoCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnoCalendario.Location = New System.Drawing.Point(129, 44)
        Me.lblAnoCalendario.Name = "lblAnoCalendario"
        Me.lblAnoCalendario.Size = New System.Drawing.Size(41, 20)
        Me.lblAnoCalendario.TabIndex = 4
        Me.lblAnoCalendario.Text = "Ano"
        '
        'mtxtAno
        '
        Me.mtxtAno.Location = New System.Drawing.Point(133, 7)
        Me.mtxtAno.Mask = "0000"
        Me.mtxtAno.Name = "mtxtAno"
        Me.mtxtAno.Size = New System.Drawing.Size(50, 20)
        Me.mtxtAno.TabIndex = 5
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(45, 6)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(44, 21)
        Me.cmbMes.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(32, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Dom"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(80, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Seg"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(120, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(165, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Qua"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(206, 115)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Qui"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(247, 115)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Sex"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(288, 115)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Sab"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Mês"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ano"
        '
        'lblDiaAtualCor
        '
        Me.lblDiaAtualCor.AutoSize = True
        Me.lblDiaAtualCor.Location = New System.Drawing.Point(45, 339)
        Me.lblDiaAtualCor.Name = "lblDiaAtualCor"
        Me.lblDiaAtualCor.Size = New System.Drawing.Size(50, 13)
        Me.lblDiaAtualCor.TabIndex = 16
        Me.lblDiaAtualCor.Text = "Dia Atual"
        '
        'btnDiaAtualCor
        '
        Me.btnDiaAtualCor.BackColor = System.Drawing.Color.Green
        Me.btnDiaAtualCor.Enabled = False
        Me.btnDiaAtualCor.Location = New System.Drawing.Point(11, 334)
        Me.btnDiaAtualCor.Name = "btnDiaAtualCor"
        Me.btnDiaAtualCor.Size = New System.Drawing.Size(28, 23)
        Me.btnDiaAtualCor.TabIndex = 17
        Me.btnDiaAtualCor.UseVisualStyleBackColor = False
        '
        'FrmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 364)
        Me.Controls.Add(Me.btnDiaAtualCor)
        Me.Controls.Add(Me.lblDiaAtualCor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.mtxtAno)
        Me.Controls.Add(Me.lblAnoCalendario)
        Me.Controls.Add(Me.lblMesAtual)
        Me.Controls.Add(Me.btnMesSeguinte)
        Me.Controls.Add(Me.btnMesAnterior)
        Me.Controls.Add(Me.pnlCalendarioDias)
        Me.Name = "FrmCalendario"
        Me.Text = "Calendário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCalendarioDias As System.Windows.Forms.Panel
    Friend WithEvents btnMesAnterior As System.Windows.Forms.Button
    Friend WithEvents btnMesSeguinte As System.Windows.Forms.Button
    Friend WithEvents lblMesAtual As System.Windows.Forms.Label
    Friend WithEvents lblAnoCalendario As System.Windows.Forms.Label
    Friend WithEvents mtxtAno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDiaAtualCor As System.Windows.Forms.Label
    Friend WithEvents btnDiaAtualCor As System.Windows.Forms.Button
End Class
