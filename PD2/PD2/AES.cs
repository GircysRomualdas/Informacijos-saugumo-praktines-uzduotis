using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PD2
{
    class AES
    {
        public string encrypt(string text, string password, int keySize)
        {
            byte[] key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();
            aes.KeySize = keySize;
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

        public string encrypt(string text, string password, int keySize, string IV)
        {
            byte[] key = Encoding.UTF8.GetBytes(password);
            byte[] iv = Encoding.UTF8.GetBytes(IV);

            AesManaged aes = new AesManaged();
            aes.KeySize = keySize;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] inpute = Encoding.UTF8.GetBytes(text);
            cryptoStream.Write(inpute, 0, inpute.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encrypted = memoryStream.ToArray();

            return Convert.ToBase64String(encrypted);
        }

        public string decrypt(string text, string password, int keySize)
        {
            byte[] key = Encoding.UTF8.GetBytes(password);

            AesManaged aes = new AesManaged();
            aes.KeySize = keySize;
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

        public string decrypt(string text, string password, int keySize, string IV)
        {
            byte[] key = Encoding.UTF8.GetBytes(password);
            byte[] iv = Encoding.UTF8.GetBytes(IV);

            AesManaged aes = new AesManaged();
            aes.KeySize = keySize;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;

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
