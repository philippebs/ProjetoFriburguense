<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerAlerta
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
        Me.mtxtAlertaDataTermino = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtAlertaDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(12, 78)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(321, 120)
        Me.txtTexto.TabIndex = 13
        '
        'mtxtAlertaDataTermino
        '
        Me.mtxtAlertaDataTermino.Location = New System.Drawing.Point(265, 42)
        Me.mtxtAlertaDataTermino.Mask = "00/00/0000"
        Me.mtxtAlertaDataTermino.Name = "mtxtAlertaDataTermino"
        Me.mtxtAlertaDataTermino.Size = New System.Drawing.Size(68, 20)
        Me.mtxtAlertaDataTermino.TabIndex = 12
        Me.mtxtAlertaDataTermino.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Data de término"
        '
        'mtxtAlertaDataInicio
        '
        Me.mtxtAlertaDataInicio.Location = New System.Drawing.Point(92, 42)
        Me.mtxtAlertaDataInicio.Mask = "00/00/0000"
        Me.mtxtAlertaDataInicio.Name = "mtxtAlertaDataInicio"
        Me.mtxtAlertaDataInicio.Size = New System.Drawing.Size(65, 20)
        Me.mtxtAlertaDataInicio.TabIndex = 11
        Me.mtxtAlertaDataInicio.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Data de início"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(53, 12)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(280, 20)
        Me.txtTitulo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-52, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Título"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Título"
        '
        'FrmVerAlerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 251)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.mtxtAlertaDataTermino)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mtxtAlertaDataInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVerAlerta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alerta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents mtxtAlertaDataTermino As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxtAlertaDataInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
