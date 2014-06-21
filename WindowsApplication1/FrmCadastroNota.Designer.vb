<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastroNota
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
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btnCadastarNota = New System.Windows.Forms.Button()
        Me.btnCancelarCadastroNota = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(9, 12)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(139, 208)
        Me.txtNota.TabIndex = 0
        '
        'btnCadastarNota
        '
        Me.btnCadastarNota.Location = New System.Drawing.Point(9, 226)
        Me.btnCadastarNota.Name = "btnCadastarNota"
        Me.btnCadastarNota.Size = New System.Drawing.Size(68, 23)
        Me.btnCadastarNota.TabIndex = 14
        Me.btnCadastarNota.Text = "Cadastrar"
        Me.btnCadastarNota.UseVisualStyleBackColor = True
        '
        'btnCancelarCadastroNota
        '
        Me.btnCancelarCadastroNota.Location = New System.Drawing.Point(83, 226)
        Me.btnCancelarCadastroNota.Name = "btnCancelarCadastroNota"
        Me.btnCancelarCadastroNota.Size = New System.Drawing.Size(68, 23)
        Me.btnCancelarCadastroNota.TabIndex = 15
        Me.btnCancelarCadastroNota.Text = "Cancelar"
        Me.btnCancelarCadastroNota.UseVisualStyleBackColor = True
        '
        'FrmCadastroNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(164, 261)
        Me.Controls.Add(Me.btnCancelarCadastroNota)
        Me.Controls.Add(Me.btnCadastarNota)
        Me.Controls.Add(Me.txtNota)
        Me.Name = "FrmCadastroNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
<<<<<<< HEAD
        Me.Text = "FrmCadastroNota"
=======
        Me.Text = "Nota"
>>>>>>> 7588756032e05a95ea49ae00e8f2881d54a256ac
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents btnCadastarNota As System.Windows.Forms.Button
    Friend WithEvents btnCancelarCadastroNota As System.Windows.Forms.Button
End Class
