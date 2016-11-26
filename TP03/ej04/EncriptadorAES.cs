using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ej04
{
    public class EncriptadorAES : Encriptador
    {
        private Aes miAes;
        private byte[] miKey;
        private byte[] miIV;


        public EncriptadorAES(): base("AES")
        {
            miAes = Aes.Create();
            miKey = miAes.Key;
            miIV = miAes.IV;
            //string cadena = "Algo de texto para encriptar"; // CADENA A ENCRIPTAR


            // CREA UNA NUEVA INSTANCIA DE LA CLASE AES
            // ESTO GENERA UNA NUEVA LLAVE (KEY) Y VECTOR DE INICIALIZACIÓN (IV)
        }

        public override string Encriptar(string pCadena)
        {
            byte[] resultado = EncryptStringToBytes_Aes(pCadena, miKey, miIV);
            return Convert.ToBase64String(resultado);
        }

        static byte[] EncryptStringToBytes_Aes(string pCadena, byte[] Key, byte[] IV)
        {
            byte[] encriptado;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encriptador = (Aes.Create()).CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncriptador = new MemoryStream())
                {
                    using (CryptoStream csEncriptador = new CryptoStream(msEncriptador, encriptador, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncriptador = new StreamWriter(csEncriptador))
                        {
                            //Write all data to the stream.
                            swEncriptador.Write(pCadena);
                        }
                        encriptado = msEncriptador.ToArray();
                    }
                }
            }
                
            return encriptado;

        }


        public override string Desencriptar(string pCadena)
        {
            return DecryptStringFromBytes_Aes(Convert.FromBase64String(pCadena), miKey, miIV);
        }

        static string DecryptStringFromBytes_Aes(byte[] textoCifrado, byte[] Key, byte[] IV)
        {
            // Check arguments. (VER ARGUMENTOS)
            if (textoCifrado == null || textoCifrado.Length <= 0)
                throw new ArgumentNullException("Texto Cifrado");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declara la cadena que se utiliza para contener el texto descifrado.
            string pCadena = null;



            ICryptoTransform descifrador = (Aes.Create()).CreateDecryptor(Key, IV);
            using (MemoryStream msDescifrador = new MemoryStream(textoCifrado))
            {
                using (CryptoStream csDescifrador = new CryptoStream(msDescifrador, descifrador, CryptoStreamMode.Read))
                {
                    using (StreamReader srDescifrador = new StreamReader(csDescifrador))
                    {

                        // Read the decrypted bytes from the decrypting stream
                        // and place them in a string.
                        pCadena = srDescifrador.ReadToEnd();
                    }
                }
            }
            return pCadena;

        }
       
    }
}