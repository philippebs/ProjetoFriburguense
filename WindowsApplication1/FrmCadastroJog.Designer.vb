<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroJog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeJogador = New System.Windows.Forms.TextBox()
        Me.txtTipoJogador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAgenteJogador = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorJogador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPosicaoJogador = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecoJogador = New System.Windows.Forms.TextBox()
        Me.txtRemuneracaoJogador = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValorCarteiraJogador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClausulasJogador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCadastarJogador = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnEditarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnAlertaCadastroJogador = New System.Windows.Forms.Button()
        Me.cmbCategoriaJogador = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtxtCadastroNAscimento = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCadastroInicio = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCadastroTermino = New System.Windows.Forms.MaskedTextBox()
        Me.btnContratoCadastro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nome"
        '
        'txtNomeJogador
        '
        Me.txtNomeJogador.Location = New System.Drawing.Point(55, 8)
        Me.txtNomeJogador.Name = "txtNomeJogador"
        Me.txtNomeJogador.Size = New System.Drawing.Size(305, 20)
        Me.txtNomeJogador.TabIndex = 0
        '
        'txtTipoJogador
        '
        Me.txtTipoJogador.Location = New System.Drawing.Point(64, 109)
        Me.txtTipoJogador.Name = "txtTipoJogador"
        Me.txtTipoJogador.Size = New System.Drawing.Size(296, 20)
        Me.txtTipoJogador.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Agente"
        '
        'txtAgenteJogador
        '
        Me.txtAgenteJogador.Location = New System.Drawing.Point(64, 135)
        Me.txtAgenteJogador.Name = "txtAgenteJogador"
        Me.txtAgenteJogador.Size = New System.Drawing.Size(297, 20)
        Me.txtAgenteJogador.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tipo"
        '
        'txtValorJogador
        '
        Me.txtValorJogador.Location = New System.Drawing.Point(64, 161)
        Me.txtValorJogador.Name = "txtValorJogador"
        Me.txtValorJogador.Size = New System.Drawing.Size(297, 20)
        Me.txtValorJogador.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Valor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Posição"
        '
        'cmbPosicaoJogador
        '
        Me.cmbPosicaoJogador.FormattingEnabled = True
        Me.cmbPosicaoJogador.Items.AddRange(New Object() {"Goleiro", "Zagueiro", "Lateral Esquerdo", "Lateral Direito", "Volante", "Meia Armador", "Meia Atacante", "Atacante"})
        Me.cmbPosicaoJogador.Location = New System.Drawing.Point(55, 34)
        Me.cmbPosicaoJogador.Name = "cmbPosicaoJogador"
        Me.cmbPosicaoJogador.Size = New System.Drawing.Size(108, 21)
        Me.cmbPosicaoJogador.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Detalhes do cotrato"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Preço exigido"
        '
        'txtPrecoJogador
        '
        Me.txtPrecoJogador.Location = New System.Drawing.Point(102, 190)
        Me.txtPrecoJogador.Name = "txtPrecoJogador"
        Me.txtPrecoJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtPrecoJogador.TabIndex = 7
        '
        'txtRemuneracaoJogador
        '
        Me.txtRemuneracaoJogador.Location = New System.Drawing.Point(102, 216)
        Me.txtRemuneracaoJogador.Name = "txtRemuneracaoJogador"
        Me.txtRemuneracaoJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtRemuneracaoJogador.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Remuneração"
        '
        'txtValorCarteiraJogador
        '
        Me.txtValorCarteiraJogador.Location = New System.Drawing.Point(101, 240)
        Me.txtValorCarteiraJogador.Name = "txtValorCarteiraJogador"
        Me.txtValorCarteiraJogador.Size = New System.Drawing.Size(259, 20)
        Me.txtValorCarteiraJogador.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Valor de carteira"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Inicio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Término"
        '
        'txtClausulasJogador
        '
        Me.txtClausulasJogador.Location = New System.Drawing.Point(64, 307)
        Me.txtClausulasJogador.Multiline = True
        Me.txtClausulasJogador.Name = "txtClausulasJogador"
        Me.txtClausulasJogador.Size = New System.Drawing.Size(296, 109)
        Me.txtClausulasJogador.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Cláusulas"
        '
        'btnCadastarJogador
        '
        Me.btnCadastarJogador.Location = New System.Drawing.Point(9, 438)
        Me.btnCadastarJogador.Name = "btnCadastarJogador"
        Me.btnCadastarJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCadastarJogador.TabIndex = 13
        Me.btnCadastarJogador.Text = "Cadastrar"
        Me.btnCadastarJogador.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroJogador
        '
        Me.btnCancelarCadastroJogador.Location = New System.Drawing.Point(83, 438)
        Me.btnCancelarCadastroJogador.Name = "btnCancelarCadastroJogador"
        Me.btnCancelarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCancelarCadastroJogador.TabIndex = 14
        Me.btnCancelarCadastroJogador.Text = "Cancelar"
        Me.btnCancelarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnEditarCadastroJogador
        '
        Me.btnEditarCadastroJogador.Location = New System.Drawing.Point(157, 438)
        Me.btnEditarCadastroJogador.Name = "btnEditarCadastroJogador"
        Me.btnEditarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnEditarCadastroJogador.TabIndex = 15
        Me.btnEditarCadastroJogador.Text = "Editar"
        Me.btnEditarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnAlertaCadastroJogador
        '
        Me.btnAlertaCadastroJogador.Location = New System.Drawing.Point(231, 438)
        Me.btnAlertaCadastroJogador.Name = "btnAlertaCadastroJogador"
        Me.btnAlertaCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnAlertaCadastroJogador.TabIndex = 16
        Me.btnAlertaCadastroJogador.Text = "Alerta"
        Me.btnAlertaCadastroJogador.UseVisualStyleBackColor = True
        '
        'cmbCategoriaJogador
        '
        Me.cmbCategoriaJogador.FormattingEnabled = True
        Me.cmbCategoriaJogador.Items.AddRange(New Object() {"Profissional", "Juvenil", "Juniores"})
        Me.cmbCategoriaJogador.Location = New System.Drawing.Point(262, 34)
        Me.cmbCategoriaJogador.Name = "cmbCategoriaJogador"
        Me.cmbCategoriaJogador.Size = New System.Drawing.Size(98, 21)
        Me.cmbCategoriaJogador.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Categoria"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(259, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Nasc"
        '
        'mtxtCadastroNAscimento
        '
        Me.mtxtCadastroNAscimento.Location = New System.Drawing.Point(296, 77)
        Me.mtxtCadastroNAscimento.Mask = "00/00/0000"
        Me.mtxtCadastroNAscimento.Name = "mtxtCadastroNAscimento"
        Me.mtxtCadastroNAscimento.Size = New System.Drawing.Size(64, 20)
        Me.mtxtCadastroNAscimento.TabIndex = 3
        Me.mtxtCadastroNAscimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtCadastroNAscimento.ValidatingType = GetType(Date)
        '
        'mtxtCadastroInicio
        '
        Me.mtxtCadastroInicio.Location = New System.Drawing.Point(118, 273)
        Me.mtxtCadastroInicio.Mask = "00/00/0000"
        Me.mtxtCadastroInicio.Name = "mtxtCadastroInicio"
        Me.mtxtCadastroInicio.Size = New System.Drawing.Size(64, 20)
        Me.mtxtCadastroInicio.TabIndex = 10
        Me.mtxtCadastroInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtCadastroInicio.ValidatingType = GetType(Date)
        '
        'mtxtCadastroTermino
        '
        Me.mtxtCadastroTermino.Location = New System.Drawing.Point(296, 273)
        Me.mtxtCadastroTermino.Mask = "00/00/0000"
        Me.mtxtCadastroTermino.Name = "mtxtCadastroTermino"
        Me.mtxtCadastroTermino.Size = New System.Drawing.Size(64, 20)
        Me.mtxtCadastroTermino.TabIndex = 11
        Me.mtxtCadastroTermino.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtCadastroTermino.ValidatingType = GetType(Date)
        '
        'btnContratoCadastro
        '
        Me.btnContratoCadastro.Location = New System.Drawing.Point(305, 438)
        Me.btnContratoCadastro.Name = "btnContratoCadastro"
        Me.btnContratoCadastro.Size = New System.Drawing.Size(68, 23)
        Me.btnContratoCadastro.TabIndex = 31
        Me.btnContratoCadastro.Text = "Contrato"
        Me.btnContratoCadastro.UseVisualStyleBackColor = True
        '
        'FrmCadastroJog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 466)
        Me.Controls.Add(Me.btnContratoCadastro)
        Me.Controls.Add(Me.mtxtCadastroTermino)
        Me.Controls.Add(Me.mtxtCadastroInicio)
        Me.Controls.Add(Me.mtxtCadastroNAscimento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbCategoriaJogador)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnAlertaCadastroJogador)
        Me.Controls.Add(Me.btnEditarCadastroJogador)
        Me.Controls.Add(Me.btnCancelarCadastroJogador)
        Me.Controls.Add(Me.btnCadastarJogador)
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
        Me.Controls.Add(Me.cmbPosicaoJogador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValorJogador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAgenteJogador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoJogador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeJogador)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadastroJog"
        Me.Text = "Cadastro de Jogadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeJogador As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAgenteJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValorJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPosicaoJogador As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoJogador As System.Windows.Forms.TextBox
    Friend WithEvents txtRemuneracaoJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtValorCarteiraJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtClausulasJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCadastarJogador As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnEditarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnAlertaCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents cmbCategoriaJogador As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mtxtCadastroNAscimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCadastroInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCadastroTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnContratoCadastro As System.Windows.Forms.Button
End Class
