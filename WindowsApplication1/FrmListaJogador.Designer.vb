<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaJogador
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
        Me.lstvJogador = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCadastrarjogador = New System.Windows.Forms.Button()
        Me.btnListaMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvJogador
        '
        Me.lstvJogador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvJogador.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstvJogador.FullRowSelect = True
        Me.lstvJogador.GridLines = True
        Me.lstvJogador.Location = New System.Drawing.Point(-1, -1)
        Me.lstvJogador.MultiSelect = False
        Me.lstvJogador.Name = "lstvJogador"
        Me.lstvJogador.Size = New System.Drawing.Size(481, 284)
        Me.lstvJogador.TabIndex = 0
        Me.lstvJogador.UseCompatibleStateImageBehavior = False
        Me.lstvJogador.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Posição"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categoria"
        Me.ColumnHeader3.Width = 120
        '
        'btnCadastrarjogador
        '
        Me.btnCadastrarjogador.Location = New System.Drawing.Point(12, 290)
        Me.btnCadastrarjogador.Name = "btnCadastrarjogador"
        Me.btnCadastrarjogador.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrarjogador.TabIndex = 1
        Me.btnCadastrarjogador.Text = "Cadastrar"
        Me.btnCadastrarjogador.UseVisualStyleBackColor = True
        '
        'btnListaMostrar
        '
        Me.btnListaMostrar.Location = New System.Drawing.Point(93, 290)
        Me.btnListaMostrar.Name = "btnListaMostrar"
        Me.btnListaMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnListaMostrar.TabIndex = 2
        Me.btnListaMostrar.Text = "Mostrar"
        Me.btnListaMostrar.UseVisualStyleBackColor = True
        '
        'FrmListaJogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 325)
        Me.Controls.Add(Me.btnListaMostrar)
        Me.Controls.Add(Me.btnCadastrarjogador)
        Me.Controls.Add(Me.lstvJogador)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListaJogador"
        Me.Text = "Lista Jogadores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvJogador As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCadastrarjogador As System.Windows.Forms.Button
    Friend WithEvents btnListaMostrar As System.Windows.Forms.Button
End Class
