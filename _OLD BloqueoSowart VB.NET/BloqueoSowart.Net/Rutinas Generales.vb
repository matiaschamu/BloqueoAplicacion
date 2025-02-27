Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Module Rutinas_Generales
    Public Clave1() As Byte = {91, 2, 15, 195, 236, 166, 34, 145, 201, 254, 87, 163, 18, 103, 119, 5, 66, 114, 206, 214, 130, 75, 189, 229}
    Public Iniciador1() As Byte = {2, 123, 245, 221, 163, 44, 194, 43}
    Public Clave2() As Byte = {20, 125, 94, 116, 125, 243, 228, 142, 66, 27, 198, 88, 196, 101, 215, 185, 26, 136, 249, 111, 166, 188, 182, 243}
    Public Iniciador2() As Byte = {197, 190, 44, 209, 218, 69, 166, 139}

    Public Function Encrypt_Decrypt(ByVal plainText As String, ByVal Clave() As Byte, ByVal Iniciador() As Byte, ByVal Encriptar As Boolean) As String
        ' Declare a UTF8Encoding object so we may use the GetByte 
        ' method to transform the plainText into a Byte array. 
        Dim utf8encoder As UTF8Encoding = New UTF8Encoding()

        Dim inputInBytes() As Byte = Nothing
        If Encriptar = False Then
            For i = 0 To plainText.Length - 1 Step 2
                If inputInBytes Is Nothing Then
                    ReDim inputInBytes(0)
                Else
                    ReDim Preserve inputInBytes(inputInBytes.Length)
                End If
                inputInBytes(inputInBytes.Length - 1) = CByte("&H" & Mid(plainText, (i + 1), 2))
            Next
        Else
            inputInBytes = utf8encoder.GetBytes(plainText)
        End If

        ' Create a new TripleDES service provider 
        Dim tdesProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()

        ' The ICryptTransform interface uses the TripleDES 
        ' crypt provider along with encryption key and init vector 
        ' information 
        Dim cryptoTransform As ICryptoTransform
        If Encriptar = True Then
            cryptoTransform = tdesProvider.CreateEncryptor(Clave, Iniciador)
        Else
            cryptoTransform = tdesProvider.CreateDecryptor(Clave, Iniciador)
        End If

        ' All cryptographic functions need a stream to output the 
        ' encrypted information. Here we declare a memory stream 
        ' for this purpose. 
        Dim encryptedStream As MemoryStream = New MemoryStream()
        Dim cryptStream As CryptoStream = New CryptoStream(encryptedStream, cryptoTransform, CryptoStreamMode.Write)

        ' Write the encrypted information to the stream. Flush the information 
        ' when done to ensure everything is out of the buffer. 
        cryptStream.Write(inputInBytes, 0, inputInBytes.Length)
        Try
            cryptStream.FlushFinalBlock()
            encryptedStream.Position = 0

            ' Read the stream back into a Byte array and return it to the calling 
            ' method. 
            Dim result(encryptedStream.Length - 1) As Byte
            encryptedStream.Read(result, 0, encryptedStream.Length)
            cryptStream.Close()

            Dim resultado As String = ""
            If Encriptar = True Then
                For i = 0 To result.Length - 1
                    resultado = resultado & StrDup(2 - Hex(result(i)).Length, "0") & Hex(result(i))
                Next
            Else
                resultado = utf8encoder.GetString(result)
            End If

            Return resultado
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function


    Public Function Decrypt(ByVal inputInBytes() As Byte) As String
        ' UTFEncoding is used to transform the decrypted Byte Array 
        ' information back into a string. 
        Dim utf8encoder As UTF8Encoding = New UTF8Encoding()
        Dim tdesProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()

        ' As before we must provide the encryption/decryption key along with 
        ' the init vector. 
        Dim cryptoTransform As ICryptoTransform = tdesProvider.CreateDecryptor(Clave1, Iniciador1)

        ' Provide a memory stream to decrypt information into 
        Dim decryptedStream As MemoryStream = New MemoryStream()
        Dim cryptStream As CryptoStream = New CryptoStream(decryptedStream, cryptoTransform, CryptoStreamMode.Write)
        cryptStream.Write(inputInBytes, 0, inputInBytes.Length)
        cryptStream.FlushFinalBlock()
        decryptedStream.Position = 0

        ' Read the memory stream and convert it back into a string 
        Dim result(decryptedStream.Length - 1) As Byte
        decryptedStream.Read(result, 0, decryptedStream.Length)
        'cryptStream.Close()
        Dim myutf As UTF8Encoding = New UTF8Encoding()
        Return myutf.GetString(result)
    End Function

End Module
