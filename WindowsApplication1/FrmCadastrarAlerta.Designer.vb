<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastrarAlerta
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
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.mtxtAlertaDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.lblDataFim = New System.Windows.Forms.Label()
        Me.mtxtAlertaDataTermino = New System.Windows.Forms.MaskedTextBox()
        Me.btnAlertaSalvar = New System.Windows.Forms.Button()
        Me.btnAlertaCancelar = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.cbConta = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Título"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(53, 46)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(348, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(9, 82)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(74, 13)
        Me.lblDataInicio.TabIndex = 8
        Me.lblDataInicio.Text = "Data de início"
        '
        'mtxtAlertaDataInicio
        '
        Me.mtxtAlertaDataInicio.Location = New System.Drawing.Point(89, 79)
        Me.mtxtAlertaDataInicio.Mask = "00/00/0000"
        Me.mtxtAlertaDataInicio.Name = "mtxtAlertaDataInicio"
        Me.mtxtAlertaDataInicio.Size = New System.Drawing.Size(75, 20)
        Me.mtxtAlertaDataInicio.TabIndex = 2
        Me.mtxtAlertaDataInicio.ValidatingType = GetType(Date)
        '
        'lblDataFim
        '
        Me.lblDataFim.AutoSize = True
        Me.lblDataFim.Location = New System.Drawing.Point(222, 82)
        Me.lblDataFim.Name = "lblDataFim"
        Me.lblDataFim.Size = New System.Drawing.Size(82, 13)
        Me.lblDataFim.TabIndex = 9
        Me.lblDataFim.Text = "Data de término"
        '
        'mtxtAlertaDataTermino
        '
        Me.mtxtAlertaDataTermino.Location = New System.Drawing.Point(329, 79)
        Me.mtxtAlertaDataTermino.Mask = "00/00/0000"
        Me.mtxtAlertaDataTermino.Name = "mtxtAlertaDataTermino"
        Me.mtxtAlertaDataTermino.Size = New System.Drawing.Size(72, 20)
        Me.mtxtAlertaDataTermino.TabIndex = 3
        Me.mtxtAlertaDataTermino.ValidatingType = GetType(Date)
        '
        'btnAlertaSalvar
        '
        Me.btnAlertaSalvar.Location = New System.Drawing.Point(12, 338)
        Me.btnAlertaSalvar.Name = "btnAlertaSalvar"
        Me.btnAlertaSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlertaSalvar.TabIndex = 5
        Me.btnAlertaSalvar.Text = "Salvar"
        Me.btnAlertaSalvar.UseVisualStyleBackColor = True
        '
        'btnAlertaCancelar
        '
        Me.btnAlertaCancelar.Location = New System.Drawing.Point(93, 338)
        Me.btnAlertaCancelar.Name = "btnAlertaCancelar"
        Me.btnAlertaCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlertaCancelar.TabIndex = 6
        Me.btnAlertaCancelar.Text = "Cancelar"
        Me.btnAlertaCancelar.UseVisualStyleBackColor = True
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(15, 114)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(389, 209)
        Me.txtTexto.TabIndex = 4
        Me.txtTexto.Text = "Insira o texto aqui"
        '
        'cbConta
        '
        Me.cbConta.AutoSize = True
        Me.cbConta.Location = New System.Drawing.Point(15, 12)
        Me.cbConta.Name = "cbConta"
        Me.cbConta.Size = New System.Drawing.Size(91, 17)
        Me.cbConta.TabIndex = 10
        Me.cbConta.Text = "Conta Mensal"
        Me.cbConta.UseVisualStyleBackColor = True
        '
        'FrmCadastrarAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 373)
        Me.Controls.Add(Me.cbConta)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnAlertaCancelar)
        Me.Controls.Add(Me.btnAlertaSalvar)
        Me.Controls.Add(Me.mtxtAlertaDataTermino)
        Me.Controls.Add(Me.lblDataFim)
        Me.Controls.Add(Me.mtxtAlertaDataInicio)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadastrarAlerta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Alerta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents mtxtAlertaDataInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDataFim As System.Windows.Forms.Label
    Friend WithEvents mtxtAlertaDataTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAlertaSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlertaCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents cbConta As System.Windows.Forms.CheckBox
End Class
