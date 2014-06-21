<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroContato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastroContato))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeContato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmailContato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSiteContato = New System.Windows.Forms.TextBox()
        Me.lstvNotas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCadastarContato = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroContato = New System.Windows.Forms.Button()
        Me.btnEditarCadastroContato = New System.Windows.Forms.Button()
        Me.btnAlertaCadastroContato = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTel2Contato = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelularContato = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel1Contato = New System.Windows.Forms.MaskedTextBox()
        Me.btnCadastrarNota = New System.Windows.Forms.Button()
        Me.btnRemoverNota = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nome"
        '
        'txtNomeContato
        '
        Me.txtNomeContato.Location = New System.Drawing.Point(53, 6)
        Me.txtNomeContato.Name = "txtNomeContato"
        Me.txtNomeContato.Size = New System.Drawing.Size(296, 20)
        Me.txtNomeContato.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "E-mail"
        '
        'txtEmailContato
        '
        Me.txtEmailContato.Location = New System.Drawing.Point(53, 32)
        Me.txtEmailContato.Name = "txtEmailContato"
        Me.txtEmailContato.Size = New System.Drawing.Size(296, 20)
        Me.txtEmailContato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Telefone (1)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefone (2)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Celular"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Site"
        '
        'txtSiteContato
        '
        Me.txtSiteContato.Location = New System.Drawing.Point(82, 138)
        Me.txtSiteContato.Name = "txtSiteContato"
        Me.txtSiteContato.Size = New System.Drawing.Size(267, 20)
        Me.txtSiteContato.TabIndex = 5
        '
        'lstvNotas
        '
        Me.lstvNotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstvNotas.FullRowSelect = True
        Me.lstvNotas.GridLines = True
        Me.lstvNotas.Location = New System.Drawing.Point(82, 164)
        Me.lstvNotas.Name = "lstvNotas"
        Me.lstvNotas.Size = New System.Drawing.Size(267, 130)
        Me.lstvNotas.TabIndex = 6
        Me.lstvNotas.UseCompatibleStateImageBehavior = False
        Me.lstvNotas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Notas"
        Me.ColumnHeader1.Width = 250
        '
        'btnCadastarContato
        '
        Me.btnCadastarContato.Location = New System.Drawing.Point(12, 330)
        Me.btnCadastarContato.Name = "btnCadastarContato"
        Me.btnCadastarContato.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastarContato.TabIndex = 7
        Me.btnCadastarContato.Text = "Cadastrar"
        Me.btnCadastarContato.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroContato
        '
        Me.btnCancelarCadastroContato.Location = New System.Drawing.Point(93, 330)
        Me.btnCancelarCadastroContato.Name = "btnCancelarCadastroContato"
        Me.btnCancelarCadastroContato.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCadastroContato.TabIndex = 8
        Me.btnCancelarCadastroContato.Text = "Cancelar"
        Me.btnCancelarCadastroContato.UseVisualStyleBackColor = True
        '
        'btnEditarCadastroContato
        '
        Me.btnEditarCadastroContato.Location = New System.Drawing.Point(174, 330)
        Me.btnEditarCadastroContato.Name = "btnEditarCadastroContato"
        Me.btnEditarCadastroContato.Size = New System.Drawing.Size(75, 23)
        Me.btnEditarCadastroContato.TabIndex = 9
        Me.btnEditarCadastroContato.Text = "Editar"
        Me.btnEditarCadastroContato.UseVisualStyleBackColor = True
        '
        'btnAlertaCadastroContato
        '
        Me.btnAlertaCadastroContato.Location = New System.Drawing.Point(255, 330)
        Me.btnAlertaCadastroContato.Name = "btnAlertaCadastroContato"
        Me.btnAlertaCadastroContato.Size = New System.Drawing.Size(75, 23)
        Me.btnAlertaCadastroContato.TabIndex = 10
        Me.btnAlertaCadastroContato.Text = "Alerta"
        Me.btnAlertaCadastroContato.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Notas"
        '
        'txtTel2Contato
        '
        Me.txtTel2Contato.Location = New System.Drawing.Point(82, 86)
        Me.txtTel2Contato.Mask = "(##) #### - #####"
        Me.txtTel2Contato.Name = "txtTel2Contato"
        Me.txtTel2Contato.Size = New System.Drawing.Size(94, 20)
        Me.txtTel2Contato.TabIndex = 3
        '
        'txtCelularContato
        '
        Me.txtCelularContato.Location = New System.Drawing.Point(82, 112)
        Me.txtCelularContato.Mask = "(##) #### - #####"
        Me.txtCelularContato.Name = "txtCelularContato"
        Me.txtCelularContato.Size = New System.Drawing.Size(94, 20)
        Me.txtCelularContato.TabIndex = 4
        '
        'txtTel1Contato
        '
        Me.txtTel1Contato.Location = New System.Drawing.Point(82, 60)
        Me.txtTel1Contato.Mask = "(##) #### - #####"
        Me.txtTel1Contato.Name = "txtTel1Contato"
        Me.txtTel1Contato.Size = New System.Drawing.Size(94, 20)
        Me.txtTel1Contato.TabIndex = 2
        '
        'btnCadastrarNota
        '
        Me.btnCadastrarNota.BackgroundImage = CType(resources.GetObject("btnCadastrarNota.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastrarNota.Location = New System.Drawing.Point(82, 300)
        Me.btnCadastrarNota.Name = "btnCadastrarNota"
        Me.btnCadastrarNota.Size = New System.Drawing.Size(24, 24)
        Me.btnCadastrarNota.TabIndex = 39
        Me.btnCadastrarNota.UseVisualStyleBackColor = True
        '
        'btnRemoverNota
        '
        Me.btnRemoverNota.BackgroundImage = CType(resources.GetObject("btnRemoverNota.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoverNota.Location = New System.Drawing.Point(112, 300)
        Me.btnRemoverNota.Name = "btnRemoverNota"
        Me.btnRemoverNota.Size = New System.Drawing.Size(24, 24)
        Me.btnRemoverNota.TabIndex = 40
        Me.btnRemoverNota.Text = "-"
        Me.btnRemoverNota.UseVisualStyleBackColor = True
        '
        'FrmCadastroContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 368)
        Me.Controls.Add(Me.btnRemoverNota)
        Me.Controls.Add(Me.btnCadastrarNota)
        Me.Controls.Add(Me.txtTel1Contato)
        Me.Controls.Add(Me.txtCelularContato)
        Me.Controls.Add(Me.txtTel2Contato)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAlertaCadastroContato)
        Me.Controls.Add(Me.btnEditarCadastroContato)
        Me.Controls.Add(Me.btnCancelarCadastroContato)
        Me.Controls.Add(Me.btnCadastarContato)
        Me.Controls.Add(Me.lstvNotas)
        Me.Controls.Add(Me.txtSiteContato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmailContato)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomeContato)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCadastroContato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadastroContato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeContato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmailContato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSiteContato As System.Windows.Forms.TextBox
    Friend WithEvents lstvNotas As System.Windows.Forms.ListView
    Friend WithEvents btnCadastarContato As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroContato As System.Windows.Forms.Button
    Friend WithEvents btnEditarCadastroContato As System.Windows.Forms.Button
    Friend WithEvents btnAlertaCadastroContato As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTel2Contato As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCelularContato As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTel1Contato As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnCadastrarNota As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoverNota As System.Windows.Forms.Button
End Class
