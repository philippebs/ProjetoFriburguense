<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroContrato
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
        Me.mtxtCadastroTermino = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCadastroInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txtClausulasJogador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorCarteiraJogador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemuneracaoJogador = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecoJogador = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorJogador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAgenteJogador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoJogador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAlertaCadastroJogador = New System.Windows.Forms.Button()
        Me.btnEditarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnCadastarJogador = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtxtCadastroTermino
        '
        Me.mtxtCadastroTermino.Location = New System.Drawing.Point(298, 212)
        Me.mtxtCadastroTermino.Mask = "00/00/0000"
        Me.mtxtCadastroTermino.Name = "mtxtCadastroTermino"
        Me.mtxtCadastroTermino.Size = New System.Drawing.Size(64, 20)
        Me.mtxtCadastroTermino.TabIndex = 38
        Me.mtxtCadastroTermino.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtCadastroTermino.ValidatingType = GetType(Date)
        '
        'mtxtCadastroInicio
        '
        Me.mtxtCadastroInicio.Location = New System.Drawing.Point(120, 212)
        Me.mtxtCadastroInicio.Mask = "00/00/0000"
        Me.mtxtCadastroInicio.Name = "mtxtCadastroInicio"
        Me.mtxtCadastroInicio.Size = New System.Drawing.Size(64, 20)
        Me.mtxtCadastroInicio.TabIndex = 37
        Me.mtxtCadastroInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtCadastroInicio.ValidatingType = GetType(Date)
        '
        'txtClausulasJogador
        '
        Me.txtClausulasJogador.Location = New System.Drawing.Point(66, 246)
        Me.txtClausulasJogador.Multiline = True
        Me.txtClausulasJogador.Name = "txtClausulasJogador"
        Me.txtClausulasJogador.Size = New System.Drawing.Size(296, 109)
        Me.txtClausulasJogador.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Cláusulas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(247, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Término"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Inicio"
        '
        'txtValorCarteiraJogador
        '
        Me.txtValorCarteiraJogador.Location = New System.Drawing.Point(103, 179)
        Me.txtValorCarteiraJogador.Name = "txtValorCarteiraJogador"
        Me.txtValorCarteiraJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtValorCarteiraJogador.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Valor de carteira"
        '
        'txtRemuneracaoJogador
        '
        Me.txtRemuneracaoJogador.Location = New System.Drawing.Point(104, 155)
        Me.txtRemuneracaoJogador.Name = "txtRemuneracaoJogador"
        Me.txtRemuneracaoJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtRemuneracaoJogador.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Remuneração"
        '
        'txtPrecoJogador
        '
        Me.txtPrecoJogador.Location = New System.Drawing.Point(104, 129)
        Me.txtPrecoJogador.Name = "txtPrecoJogador"
        Me.txtPrecoJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtPrecoJogador.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Preço exigido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Detalhes do cotrato"
        '
        'txtValorJogador
        '
        Me.txtValorJogador.Location = New System.Drawing.Point(66, 100)
        Me.txtValorJogador.Name = "txtValorJogador"
        Me.txtValorJogador.Size = New System.Drawing.Size(297, 20)
        Me.txtValorJogador.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Valor"
        '
        'txtAgenteJogador
        '
        Me.txtAgenteJogador.Location = New System.Drawing.Point(66, 74)
        Me.txtAgenteJogador.Name = "txtAgenteJogador"
        Me.txtAgenteJogador.Size = New System.Drawing.Size(297, 20)
        Me.txtAgenteJogador.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tipo"
        '
        'txtTipoJogador
        '
        Me.txtTipoJogador.Location = New System.Drawing.Point(66, 48)
        Me.txtTipoJogador.Name = "txtTipoJogador"
        Me.txtTipoJogador.Size = New System.Drawing.Size(296, 20)
        Me.txtTipoJogador.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Agente"
        '
        'btnAlertaCadastroJogador
        '
        Me.btnAlertaCadastroJogador.Location = New System.Drawing.Point(233, 377)
        Me.btnAlertaCadastroJogador.Name = "btnAlertaCadastroJogador"
        Me.btnAlertaCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnAlertaCadastroJogador.TabIndex = 53
        Me.btnAlertaCadastroJogador.Text = "Alerta"
        Me.btnAlertaCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnEditarCadastroJogador
        '
        Me.btnEditarCadastroJogador.Location = New System.Drawing.Point(159, 377)
        Me.btnEditarCadastroJogador.Name = "btnEditarCadastroJogador"
        Me.btnEditarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnEditarCadastroJogador.TabIndex = 52
        Me.btnEditarCadastroJogador.Text = "Editar"
        Me.btnEditarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroJogador
        '
        Me.btnCancelarCadastroJogador.Location = New System.Drawing.Point(85, 377)
        Me.btnCancelarCadastroJogador.Name = "btnCancelarCadastroJogador"
        Me.btnCancelarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCancelarCadastroJogador.TabIndex = 51
        Me.btnCancelarCadastroJogador.Text = "Cancelar"
        Me.btnCancelarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnCadastarJogador
        '
        Me.btnCadastarJogador.Location = New System.Drawing.Point(11, 377)
        Me.btnCadastarJogador.Name = "btnCadastarJogador"
        Me.btnCadastarJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCadastarJogador.TabIndex = 50
        Me.btnCadastarJogador.Text = "Cadastrar"
        Me.btnCadastarJogador.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Renovar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAlertaCadastroJogador)
        Me.Controls.Add(Me.btnEditarCadastroJogador)
        Me.Controls.Add(Me.btnCancelarCadastroJogador)
        Me.Controls.Add(Me.btnCadastarJogador)
        Me.Controls.Add(Me.mtxtCadastroTermino)
        Me.Controls.Add(Me.mtxtCadastroInicio)
        Me.Controls.Add(Me.txtClausulasJogador)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtValorCarteiraJogador)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemuneracaoJogador)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecoJogador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorJogador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAgenteJogador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoJogador)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmContrato"
        Me.Text = "FrmContrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtxtCadastroTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCadastroInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtClausulasJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtValorCarteiraJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRemuneracaoJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAgenteJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTipoJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAlertaCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnEditarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnCadastarJogador As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
