Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class BloqueoSowart
    Public Event Reiniciar(ByVal sender As Object, ByVal e As EventArgs)
    Public Declare Sub GetSystemInfo Lib "kernel32" Alias "GetSystemInfo" (<MarshalAs(UnmanagedType.Struct)> ByRef lpSystemInfo As SYSTEM_INFO)

    <StructLayout(LayoutKind.Sequential)>
    Public Structure SYSTEM_INFO
        Public dwOemID As Integer
        Public dwPageSize As Integer
        Public lpMinimumApplicationAddress As Integer
        Public lpMaximumApplicationAddress As Integer
        Public dwActiveProcessorMask As Integer
        Public dwNumberOrfProcessors As Integer
        Public dwProcessorType As Integer
        Public dwAllocationGranularity As Integer
        Public dwReserved As Integer
    End Structure
    Dim m_TextoCifrado As String = ""
    Dim Informacion As String = ""
    Dim m_EstaBloqueado As Boolean = True

    Public ReadOnly Property EstaBloqueado As Boolean
        Get
            Return m_EstaBloqueado
        End Get
    End Property
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("http://www.sowart.com.ar")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.sowart.com.ar")
    End Sub
    Private Sub BloqueoSowart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Info As SYSTEM_INFO
        GetSystemInfo(Info)

        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\CodigoSowart.regkey") Then
            Dim m_ClaveLocal As String = ""
            m_ClaveLocal = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\CodigoSowart.regkey")
            Informacion = "MicroID: " & Info.dwReserved
            If m_ClaveLocal = Encrypt_Decrypt(Informacion, Clave2, Iniciador2, True) Then
                m_EstaBloqueado = False
            End If
        End If

        If m_EstaBloqueado = True Then
            Informacion = "MicroID: " & Info.dwReserved & vbCrLf
            Informacion = Informacion & "Procesador: " & Info.dwNumberOrfProcessors & ", " & Info.dwProcessorType & vbCrLf
            Informacion = Informacion & "Pantalla: " & Screen.PrimaryScreen.Bounds.Width & " x " & Screen.PrimaryScreen.Bounds.Height & vbCrLf
            Informacion = Informacion & "NombrePC: " & My.Computer.Name & vbCrLf
            Informacion = Informacion & "Windows: " & My.Computer.Info.OSFullName & vbCrLf
            Informacion = Informacion & "Plataforma: " & My.Computer.Info.OSPlatform & vbCrLf
            Informacion = Informacion & "Version Windows: " & My.Computer.Info.OSVersion & vbCrLf
            Informacion = Informacion & "VersionPrograma: " & My.Application.Info.Version.ToString & vbCrLf
            Informacion = Informacion & "Path Instalacion: " & My.Application.Info.DirectoryPath

            m_TextoCifrado = Encrypt_Decrypt(Informacion, Clave1, Iniciador1, True)
            TextBox1.Text = Encrypt_Decrypt(Informacion, Clave1, Iniciador1, True)
        End If
    End Sub
    Public Shared Function DeCharToByte(ByVal pf As Char) As Byte
        Return CByte(AscW(pf))
    End Function
    Public Shared Function DeByteToChar(ByVal pf As Byte) As Char
        Return CChar(ChrW(pf))
    End Function
    Private Sub ButtonCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCopiar.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub
    Private Sub ButtonPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPegar.Click
        TextBox2.Text = My.Computer.Clipboard.GetText
    End Sub
    Private Sub ButtonGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardar.Click
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = "regkey"
        SaveFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey"
        SaveFileDialog1.FilterIndex = 0
        SaveFileDialog1.FileName = "Sowart Envio"
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.Title = "Guardar Clave"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, m_TextoCifrado)
        End If
    End Sub
    Private Sub ButtonAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbrir.Click
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.DefaultExt = "regkey"
        OpenFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey"
        OpenFileDialog1.FilterIndex = 0
        OpenFileDialog1.FileName = "CodigoSowart"
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Abrir Clave"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\CodigoSowart.regkey", TextBox2.Text)
        MsgBox("La aplicacion se cerrara para registrarse, por favor iniciela nuevamente", MsgBoxStyle.Information, "Registro")
        RaiseEvent Reiniciar(Me, New EventArgs)
    End Sub
End Class
