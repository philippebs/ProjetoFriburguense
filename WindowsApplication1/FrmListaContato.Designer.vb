<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaContato
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
        Me.lstvContato = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCadastrarContato = New System.Windows.Forms.Button()
        Me.btnListaMostrarContato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvContato
        '
        Me.lstvContato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvContato.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstvContato.FullRowSelect = True
        Me.lstvContato.GridLines = True
        Me.lstvContato.Location = New System.Drawing.Point(12, 12)
        Me.lstvContato.MultiSelect = False
        Me.lstvContato.Name = "lstvContato"
        Me.lstvContato.Size = New System.Drawing.Size(258, 312)
        Me.lstvContato.TabIndex = 1
        Me.lstvContato.UseCompatibleStateImageBehavior = False
        Me.lstvContato.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        Me.ColumnHeader1.Width = 240
        '
        'btnCadastrarContato
        '
        Me.btnCadastrarContato.Location = New System.Drawing.Point(12, 330)
        Me.btnCadastrarContato.Name = "btnCadastrarContato"
        Me.btnCadastrarContato.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrarContato.TabIndex = 2
        Me.btnCadastrarContato.Text = "Cadastrar"
        Me.btnCadastrarContato.UseVisualStyleBackColor = True
        '
        'btnListaMostrarContato
        '
        Me.btnListaMostrarContato.Location = New System.Drawing.Point(93, 330)
        Me.btnListaMostrarContato.Name = "btnListaMostrarContato"
        Me.btnListaMostrarContato.Size = New System.Drawing.Size(75, 23)
        Me.btnListaMostrarContato.TabIndex = 3
        Me.btnListaMostrarContato.Text = "Mostrar"
        Me.btnListaMostrarContato.UseVisualStyleBackColor = True
        '
        'FrmListaContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 365)
        Me.Controls.Add(Me.btnListaMostrarContato)
        Me.Controls.Add(Me.btnCadastrarContato)
        Me.Controls.Add(Me.lstvContato)
        Me.Name = "FrmListaContato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Contatos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvContato As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCadastrarContato As System.Windows.Forms.Button
    Friend WithEvents btnListaMostrarContato As System.Windows.Forms.Button
End Class
