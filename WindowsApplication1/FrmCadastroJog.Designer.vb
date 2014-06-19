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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPosicaoJogador = New System.Windows.Forms.ComboBox()
        Me.btnCadastarJogador = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnEditarCadastroJogador = New System.Windows.Forms.Button()
        Me.btnAlertaCadastroJogador = New System.Windows.Forms.Button()
        Me.cmbCategoriaJogador = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtxtCadastroNAscimento = New System.Windows.Forms.MaskedTextBox()
        Me.btnContratoCadastro = New System.Windows.Forms.Button()
        Me.btnAvaliacao = New System.Windows.Forms.Button()
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
        'btnCadastarJogador
        '
        Me.btnCadastarJogador.Location = New System.Drawing.Point(9, 133)
        Me.btnCadastarJogador.Name = "btnCadastarJogador"
        Me.btnCadastarJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCadastarJogador.TabIndex = 13
        Me.btnCadastarJogador.Text = "Cadastrar"
        Me.btnCadastarJogador.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroJogador
        '
        Me.btnCancelarCadastroJogador.Location = New System.Drawing.Point(83, 133)
        Me.btnCancelarCadastroJogador.Name = "btnCancelarCadastroJogador"
        Me.btnCancelarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnCancelarCadastroJogador.TabIndex = 14
        Me.btnCancelarCadastroJogador.Text = "Cancelar"
        Me.btnCancelarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnEditarCadastroJogador
        '
        Me.btnEditarCadastroJogador.Location = New System.Drawing.Point(157, 133)
        Me.btnEditarCadastroJogador.Name = "btnEditarCadastroJogador"
        Me.btnEditarCadastroJogador.Size = New System.Drawing.Size(68, 23)
        Me.btnEditarCadastroJogador.TabIndex = 15
        Me.btnEditarCadastroJogador.Text = "Editar"
        Me.btnEditarCadastroJogador.UseVisualStyleBackColor = True
        '
        'btnAlertaCadastroJogador
        '
        Me.btnAlertaCadastroJogador.Location = New System.Drawing.Point(231, 133)
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
        'btnContratoCadastro
        '
        Me.btnContratoCadastro.Location = New System.Drawing.Point(305, 133)
        Me.btnContratoCadastro.Name = "btnContratoCadastro"
        Me.btnContratoCadastro.Size = New System.Drawing.Size(68, 23)
        Me.btnContratoCadastro.TabIndex = 31
        Me.btnContratoCadastro.Text = "Contrato"
        Me.btnContratoCadastro.UseVisualStyleBackColor = True
        '
        'btnAvaliacao
        '
        Me.btnAvaliacao.Location = New System.Drawing.Point(262, 104)
        Me.btnAvaliacao.Name = "btnAvaliacao"
        Me.btnAvaliacao.Size = New System.Drawing.Size(98, 23)
        Me.btnAvaliacao.TabIndex = 32
        Me.btnAvaliacao.Text = "Avaliação"
        Me.btnAvaliacao.UseVisualStyleBackColor = True
        '
        'FrmCadastroJog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 164)
<<<<<<< HEAD
        Me.Controls.Add(Me.btnAvaliacao)
=======
>>>>>>> 4488fbf8481de3583faecc21c433e97c3e032037
        Me.Controls.Add(Me.btnContratoCadastro)
        Me.Controls.Add(Me.mtxtCadastroNAscimento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbCategoriaJogador)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnAlertaCadastroJogador)
        Me.Controls.Add(Me.btnEditarCadastroJogador)
        Me.Controls.Add(Me.btnCancelarCadastroJogador)
        Me.Controls.Add(Me.btnCadastarJogador)
        Me.Controls.Add(Me.cmbPosicaoJogador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomeJogador)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadastroJog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jogadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeJogador As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPosicaoJogador As System.Windows.Forms.ComboBox
    Friend WithEvents btnCadastarJogador As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnEditarCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents btnAlertaCadastroJogador As System.Windows.Forms.Button
    Friend WithEvents cmbCategoriaJogador As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mtxtCadastroNAscimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnContratoCadastro As System.Windows.Forms.Button
    Friend WithEvents btnAvaliacao As System.Windows.Forms.Button
End Class
