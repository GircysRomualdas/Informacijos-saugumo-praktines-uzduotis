using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PD4
{
    class AES
    {
        public static string encrypt(string text)
        {
            byte[] key = Encoding.UTF8.GetBytes("rudisrudisrudisr");

            AesManaged aes = new AesManaged();
            aes.KeySize = 128;
            aes.Key = key;
            aes.Mode = CipherMode.ECB;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] inpute = Encoding.UTF8.GetBytes(text);
            cryptoStream.Write(inpute, 0, inpute.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encrypted = memoryStream.ToArray();

            return Convert.ToBase64String(encrypted);
        }

        public static string decrypt(string text)
        {
            byte[] key = Encoding.UTF8.GetBytes("rudisrudisrudisr");

            AesManaged aes = new AesManaged();
            aes.KeySize = 128;
            aes.Key = key;
            aes.Mode = CipherMode.ECB;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] inpute = Convert.FromBase64String(text);
            cryptoStream.Write(inpute, 0, inpute.Length);
            cryptoStream.FlushFinalBlock();

            byte[] decrypted = memoryStream.ToArray();

            return UTF8Encoding.UTF8.GetString(decrypted, 0, decrypted.Length);
        }
    }
}
