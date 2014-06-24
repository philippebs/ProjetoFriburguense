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
        Me.mtxtDataTermino = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.txtClausulasContrato = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorCarteiraContrato = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemuneracaoContrato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecoContrato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorContrato = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAgenteContrato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoContrato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAlertaCadastroContrato = New System.Windows.Forms.Button()
        Me.btnEditarCadastroContrato = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroContrato = New System.Windows.Forms.Button()
        Me.btnCadastarContrato = New System.Windows.Forms.Button()
        Me.btnRenovarContrato = New System.Windows.Forms.Button()
        Me.lblNomeJoagador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtxtDataTermino
        '
        Me.mtxtDataTermino.Location = New System.Drawing.Point(297, 217)
        Me.mtxtDataTermino.Mask = "00/00/0000"
        Me.mtxtDataTermino.Name = "mtxtDataTermino"
        Me.mtxtDataTermino.Size = New System.Drawing.Size(64, 20)
        Me.mtxtDataTermino.TabIndex = 38
        Me.mtxtDataTermino.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtDataTermino.ValidatingType = GetType(Date)
        '
        'mtxtDataInicio
        '
        Me.mtxtDataInicio.Location = New System.Drawing.Point(119, 217)
        Me.mtxtDataInicio.Mask = "00/00/0000"
        Me.mtxtDataInicio.Name = "mtxtDataInicio"
        Me.mtxtDataInicio.Size = New System.Drawing.Size(64, 20)
        Me.mtxtDataInicio.TabIndex = 37
        Me.mtxtDataInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtxtDataInicio.ValidatingType = GetType(Date)
        '
        'txtClausulasContrato
        '
        Me.txtClausulasContrato.Location = New System.Drawing.Point(65, 251)
        Me.txtClausulasContrato.Multiline = True
        Me.txtClausulasContrato.Name = "txtClausulasContrato"
        Me.txtClausulasContrato.Size = New System.Drawing.Size(296, 109)
        Me.txtClausulasContrato.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Cláusulas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(246, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Término"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Inicio"
        '
        'txtValorCarteiraContrato
        '
        Me.txtValorCarteiraContrato.Location = New System.Drawing.Point(102, 184)
        Me.txtValorCarteiraContrato.Name = "txtValorCarteiraContrato"
        Me.txtValorCarteiraContrato.Size = New System.Drawing.Size(259, 20)
        Me.txtValorCarteiraContrato.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Valor de carteira"
        '
        'txtRemuneracaoContrato
        '
        Me.txtRemuneracaoContrato.Location = New System.Drawing.Point(103, 160)
        Me.txtRemuneracaoContrato.Name = "txtRemuneracaoContrato"
        Me.txtRemuneracaoContrato.Size = New System.Drawing.Size(259, 20)
        Me.txtRemuneracaoContrato.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Remuneração"
        '
        'txtPrecoContrato
        '
        Me.txtPrecoContrato.Location = New System.Drawing.Point(103, 134)
        Me.txtPrecoContrato.Name = "txtPrecoContrato"
        Me.txtPrecoContrato.Size = New System.Drawing.Size(259, 20)
        Me.txtPrecoContrato.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Preço exigido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Detalhes do cotrato"
        '
        'txtValorContrato
        '
        Me.txtValorContrato.Location = New System.Drawing.Point(65, 105)
        Me.txtValorContrato.Name = "txtValorContrato"
        Me.txtValorContrato.Size = New System.Drawing.Size(297, 20)
        Me.txtValorContrato.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Valor"
        '
        'txtAgenteContrato
        '
        Me.txtAgenteContrato.Location = New System.Drawing.Point(65, 79)
        Me.txtAgenteContrato.Name = "txtAgenteContrato"
        Me.txtAgenteContrato.Size = New System.Drawing.Size(297, 20)
        Me.txtAgenteContrato.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tipo"
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.Location = New System.Drawing.Point(65, 53)
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(296, 20)
        Me.txtTipoContrato.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Agente"
        '
        'btnAlertaCadastroContrato
        '
        Me.btnAlertaCadastroContrato.Location = New System.Drawing.Point(232, 382)
        Me.btnAlertaCadastroContrato.Name = "btnAlertaCadastroContrato"
        Me.btnAlertaCadastroContrato.Size = New System.Drawing.Size(68, 23)
        Me.btnAlertaCadastroContrato.TabIndex = 53
        Me.btnAlertaCadastroContrato.Text = "Alerta"
        Me.btnAlertaCadastroContrato.UseVisualStyleBackColor = True
        '
        'btnEditarCadastroContrato
        '
        Me.btnEditarCadastroContrato.Location = New System.Drawing.Point(158, 382)
        Me.btnEditarCadastroContrato.Name = "btnEditarCadastroContrato"
        Me.btnEditarCadastroContrato.Size = New System.Drawing.Size(68, 23)
        Me.btnEditarCadastroContrato.TabIndex = 52
        Me.btnEditarCadastroContrato.Text = "Editar"
        Me.btnEditarCadastroContrato.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroContrato
        '
        Me.btnCancelarCadastroContrato.Location = New System.Drawing.Point(84, 382)
        Me.btnCancelarCadastroContrato.Name = "btnCancelarCadastroContrato"
        Me.btnCancelarCadastroContrato.Size = New System.Drawing.Size(68, 23)
        Me.btnCancelarCadastroContrato.TabIndex = 51
        Me.btnCancelarCadastroContrato.Text = "Cancelar"
        Me.btnCancelarCadastroContrato.UseVisualStyleBackColor = True
        '
        'btnCadastarContrato
        '
        Me.btnCadastarContrato.Location = New System.Drawing.Point(10, 382)
        Me.btnCadastarContrato.Name = "btnCadastarContrato"
        Me.btnCadastarContrato.Size = New System.Drawing.Size(68, 23)
        Me.btnCadastarContrato.TabIndex = 50
        Me.btnCadastarContrato.Text = "Cadastrar"
        Me.btnCadastarContrato.UseVisualStyleBackColor = True
        '
        'btnRenovarContrato
        '
        Me.btnRenovarContrato.Location = New System.Drawing.Point(306, 382)
        Me.btnRenovarContrato.Name = "btnRenovarContrato"
        Me.btnRenovarContrato.Size = New System.Drawing.Size(68, 23)
        Me.btnRenovarContrato.TabIndex = 54
        Me.btnRenovarContrato.Text = "Renovar"
        Me.btnRenovarContrato.UseVisualStyleBackColor = True
        '
        'lblNomeJoagador
        '
        Me.lblNomeJoagador.AutoSize = True
        Me.lblNomeJoagador.Location = New System.Drawing.Point(7, 9)
        Me.lblNomeJoagador.Name = "lblNomeJoagador"
        Me.lblNomeJoagador.Size = New System.Drawing.Size(38, 13)
        Me.lblNomeJoagador.TabIndex = 55
        Me.lblNomeJoagador.Text = "Nome:"
        '
        'FrmCadastroContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 417)
        Me.Controls.Add(Me.lblNomeJoagador)
        Me.Controls.Add(Me.btnRenovarContrato)
        Me.Controls.Add(Me.btnAlertaCadastroContrato)
        Me.Controls.Add(Me.btnEditarCadastroContrato)
        Me.Controls.Add(Me.btnCancelarCadastroContrato)
        Me.Controls.Add(Me.btnCadastarContrato)
        Me.Controls.Add(Me.mtxtDataTermino)
        Me.Controls.Add(Me.mtxtDataInicio)
        Me.Controls.Add(Me.txtClausulasContrato)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtValorCarteiraContrato)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemuneracaoContrato)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrecoContrato)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorContrato)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAgenteContrato)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoContrato)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmCadastroContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtxtDataTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtDataInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtClausulasContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtValorCarteiraContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRemuneracaoContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAgenteContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTipoContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAlertaCadastroContrato As System.Windows.Forms.Button
    Friend WithEvents btnEditarCadastroContrato As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroContrato As System.Windows.Forms.Button
    Friend WithEvents btnCadastarContrato As System.Windows.Forms.Button
    Friend WithEvents btnRenovarContrato As System.Windows.Forms.Button
    Friend WithEvents lblNomeJoagador As System.Windows.Forms.Label
End Class
