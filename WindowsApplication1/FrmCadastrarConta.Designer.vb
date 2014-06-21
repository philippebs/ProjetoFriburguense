<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastrarConta
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
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnAlertaCancelar = New System.Windows.Forms.Button()
        Me.btnAlertaSalvar = New System.Windows.Forms.Button()
        Me.mtxtAlertaDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(15, 74)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(389, 209)
        Me.txtTexto.TabIndex = 13
        Me.txtTexto.Text = "Insira o texto aqui"
        '
        'btnAlertaCancelar
        '
        Me.btnAlertaCancelar.Location = New System.Drawing.Point(96, 289)
        Me.btnAlertaCancelar.Name = "btnAlertaCancelar"
        Me.btnAlertaCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlertaCancelar.TabIndex = 15
        Me.btnAlertaCancelar.Text = "Cancelar"
        Me.btnAlertaCancelar.UseVisualStyleBackColor = True
        '
        'btnAlertaSalvar
        '
        Me.btnAlertaSalvar.Location = New System.Drawing.Point(15, 289)
        Me.btnAlertaSalvar.Name = "btnAlertaSalvar"
        Me.btnAlertaSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlertaSalvar.TabIndex = 14
        Me.btnAlertaSalvar.Text = "Salvar"
        Me.btnAlertaSalvar.UseVisualStyleBackColor = True
        '
        'mtxtAlertaDataInicio
        '
        Me.mtxtAlertaDataInicio.Location = New System.Drawing.Point(118, 39)
        Me.mtxtAlertaDataInicio.Mask = "00/00/0000"
        Me.mtxtAlertaDataInicio.Name = "mtxtAlertaDataInicio"
        Me.mtxtAlertaDataInicio.Size = New System.Drawing.Size(75, 20)
        Me.mtxtAlertaDataInicio.TabIndex = 11
        Me.mtxtAlertaDataInicio.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Data de vencimento"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(53, 6)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(348, 20)
        Me.txtTitulo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Título"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(224, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Repetir todo mês"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmCadastrarConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 320)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnAlertaCancelar)
        Me.Controls.Add(Me.btnAlertaSalvar)
        Me.Controls.Add(Me.mtxtAlertaDataInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCadastrarConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents btnAlertaCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlertaSalvar As System.Windows.Forms.Button
    Friend WithEvents mtxtAlertaDataInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
