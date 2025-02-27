<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desbloqueo_Sowart
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonPegar = New System.Windows.Forms.Button()
        Me.ButtonCopiar = New System.Windows.Forms.Button()
        Me.ButtonAbrir = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonVerificar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(377, 146)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo suministrado por la aplicacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo de desbloqueo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 197)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(377, 52)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor Desencriptado"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(389, 16)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(234, 233)
        Me.TextBox3.TabIndex = 4
        '
        'ButtonPegar
        '
        Me.ButtonPegar.Location = New System.Drawing.Point(294, 168)
        Me.ButtonPegar.Name = "ButtonPegar"
        Me.ButtonPegar.Size = New System.Drawing.Size(89, 23)
        Me.ButtonPegar.TabIndex = 6
        Me.ButtonPegar.Text = "Pegar"
        Me.ButtonPegar.UseVisualStyleBackColor = True
        '
        'ButtonCopiar
        '
        Me.ButtonCopiar.Location = New System.Drawing.Point(294, 255)
        Me.ButtonCopiar.Name = "ButtonCopiar"
        Me.ButtonCopiar.Size = New System.Drawing.Size(89, 23)
        Me.ButtonCopiar.TabIndex = 7
        Me.ButtonCopiar.Text = "Copiar"
        Me.ButtonCopiar.UseVisualStyleBackColor = True
        '
        'ButtonAbrir
        '
        Me.ButtonAbrir.Location = New System.Drawing.Point(199, 168)
        Me.ButtonAbrir.Name = "ButtonAbrir"
        Me.ButtonAbrir.Size = New System.Drawing.Size(89, 23)
        Me.ButtonAbrir.TabIndex = 8
        Me.ButtonAbrir.Text = "Abrir..."
        Me.ButtonAbrir.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(199, 255)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(89, 23)
        Me.ButtonGuardar.TabIndex = 9
        Me.ButtonGuardar.Text = "Guardar..."
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonVerificar
        '
        Me.ButtonVerificar.Location = New System.Drawing.Point(534, 255)
        Me.ButtonVerificar.Name = "ButtonVerificar"
        Me.ButtonVerificar.Size = New System.Drawing.Size(89, 23)
        Me.ButtonVerificar.TabIndex = 10
        Me.ButtonVerificar.Text = "Verificar"
        Me.ButtonVerificar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Desbloqueo_Sowart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonVerificar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ButtonAbrir)
        Me.Controls.Add(Me.ButtonCopiar)
        Me.Controls.Add(Me.ButtonPegar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Desbloqueo_Sowart"
        Me.Size = New System.Drawing.Size(626, 283)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPegar As System.Windows.Forms.Button
    Friend WithEvents ButtonCopiar As System.Windows.Forms.Button
    Friend WithEvents ButtonAbrir As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents ButtonVerificar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
