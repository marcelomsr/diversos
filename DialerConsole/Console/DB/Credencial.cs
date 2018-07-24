
using System.Configuration;
using System.IO;
using System.Security.Cryptography;

namespace Console.DB
{
    internal class Credencial
    {
        private static readonly byte[] KEY = 
            { 199, 255, 80, 46, 23, 254, 38, 218, 223, 17, 121, 32, 133, 184, 115, 115, 191, 60, 90, 38, 10, 54, 213, 61, 74, 22, 33, 114, 60, 14, 59, 114 };

        private static readonly byte[] IV = 
            { 238, 101, 9, 22, 6, 109, 98, 174, 187, 10, 96, 248, 223, 95, 176, 194 };

        public static string ObterCredencial()
        {
            string senha = DescriptografarSenha(
                System.Convert.FromBase64String(ConfigurationManager.AppSettings["Password"].ToString()), KEY, IV);

            return string.Format(ConfigurationManager.AppSettings["ConnectionString"].ToString(), senha);
        }

        private static string DescriptografarSenha(byte[] cipher, byte[] Key, byte[] IV)
        {
            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
