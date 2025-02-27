Imports System.Security.Cryptography
Public Class Desbloqueo_Sowart
 
    Private Sub ButtonPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPegar.Click
        TextBox1.Text = My.Computer.Clipboard.GetText
    End Sub
    Private Sub ButtonCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCopiar.Click
        If TextBox2.Text <> "" Then
            My.Computer.Clipboard.SetText(TextBox2.Text)
        End If
    End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = "regkey"
        SaveFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey"
        SaveFileDialog1.FilterIndex = 0
        SaveFileDialog1.FileName = "CodigoSowart"
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.Title = "Guardar Clave"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox2.Text)
        End If
    End Sub
    Private Sub ButtonAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbrir.Click
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.DefaultExt = "regkey"
        OpenFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey"
        OpenFileDialog1.FilterIndex = 0
        OpenFileDialog1.FileName = "Sowart Envio"
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Abrir Clave"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub ButtonVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerificar.Click
        Try
            TextBox3.Text = Encrypt_Decrypt(TextBox1.Text, Clave1, Iniciador1, False)
            Dim Resultado As String = ""
            Resultado = Mid(TextBox3.Text, 1, TextBox3.Text.IndexOf(vbCrLf))
            TextBox2.Text = Encrypt_Decrypt(Resultado, Clave2, Iniciador2, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


   

End Class
