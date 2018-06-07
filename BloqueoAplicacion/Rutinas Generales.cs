using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BibliotecaMaf.Controles.BloqueoAplicacion
{
    internal static class Rutinas_Generales
    {
        public static byte[] Clave1 = { 91, 2, 15, 195, 236, 166, 34, 145, 201, 254, 87, 163, 18, 103, 119, 5, 66, 114, 206, 214, 130, 75, 189, 229 };
        public static byte[] Iniciador1 = { 2, 123, 245, 221, 163, 44, 194, 43 };
        public static byte[] Clave2 = { 20, 125, 94, 116, 125, 243, 228, 142, 66, 27, 198, 88, 196, 101, 215, 185, 26, 136, 249, 111, 166, 188, 182, 243 };
        public static byte[] Iniciador2 = { 197, 190, 44, 209, 218, 69, 166, 139 };
        public static byte[] Clave3 = { 43, 12, 85, 243, 54, 19, 234, 32, 65, 31, 75, 158, 248, 32, 178, 98, 57, 175, 47, 192, 32, 231, 201, 174 };
        public static byte[] Iniciador3 = { 31, 45, 92, 188, 201, 74, 165, 45 };

        public static string Encrypt_Decrypt(string plainText, byte[] Clave, byte[] Iniciador, bool Encriptar)
        {
            // Declare a UTF8Encoding object so we may use the GetByte 
            // method to transform the plainText into a Byte array. 
            UTF8Encoding utf8encoder = new UTF8Encoding();

            byte[] inputInBytes = null;
            if (Encriptar == false)
            {
                for (int i = 0; i <= plainText.Length - 1; i += 2)
                {
                    if (inputInBytes == null)
                    {
                        inputInBytes = new byte[1];
                    }
                    else
                    {
                        Array.Resize(ref inputInBytes, inputInBytes.Length + 1);
                    }

                    try
                    {
                        string ff = "0x" + plainText.Substring((i), 2);
                        inputInBytes[inputInBytes.Length - 1] = Convert.ToByte(ff, 16);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
                inputInBytes = utf8encoder.GetBytes(plainText);
            }

            // Create a new TripleDES service provider 
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();

            // The ICryptTransform interface uses the TripleDES 
            // crypt provider along with encryption key and init vector 
            // information 
            ICryptoTransform cryptoTransform = default(ICryptoTransform);
            if (Encriptar == true)
            {
                cryptoTransform = tdesProvider.CreateEncryptor(Clave, Iniciador);
            }
            else
            {
                cryptoTransform = tdesProvider.CreateDecryptor(Clave, Iniciador);
            }

            // All cryptographic functions need a stream to output the 
            // encrypted information. Here we declare a memory stream 
            // for this purpose. 
            MemoryStream encryptedStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(encryptedStream, cryptoTransform, CryptoStreamMode.Write);

            try
            {
                // Write the encrypted information to the stream. Flush the information 
                // when done to ensure everything is out of the buffer. 
                cryptStream.Write(inputInBytes, 0, inputInBytes.Length);
                cryptStream.FlushFinalBlock();
                encryptedStream.Position = 0;

                // Read the stream back into a Byte array and return it to the calling 
                // method. 
                byte[] result = new byte[encryptedStream.Length];
                encryptedStream.Read(result, 0, (int)encryptedStream.Length);
                cryptStream.Close();

                string resultado = "";
                if (Encriptar == true)
                {
                    for (int i = 0; i <= result.Length - 1; i++)
                    {
                        resultado = resultado + result[i].ToString("X").PadLeft(2, '0');
                    }
                }
                else
                {
                    resultado = utf8encoder.GetString(result);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Decrypt(byte[] inputInBytes)
        {
            // UTFEncoding is used to transform the decrypted Byte Array 
            // information back into a string. 
            UTF8Encoding utf8encoder = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();

            // As before we must provide the encryption/decryption key along with 
            // the init vector. 
            ICryptoTransform cryptoTransform = tdesProvider.CreateDecryptor(Clave1, Iniciador1);

            // Provide a memory stream to decrypt information into 
            MemoryStream decryptedStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(decryptedStream, cryptoTransform, CryptoStreamMode.Write);
            cryptStream.Write(inputInBytes, 0, inputInBytes.Length);
            cryptStream.FlushFinalBlock();
            decryptedStream.Position = 0;

            // Read the memory stream and convert it back into a string 
            byte[] result = new byte[decryptedStream.Length];
            decryptedStream.Read(result, 0, (int)decryptedStream.Length);
            //cryptStream.Close()
            UTF8Encoding myutf = new UTF8Encoding();
            return myutf.GetString(result);
        }
    }
}