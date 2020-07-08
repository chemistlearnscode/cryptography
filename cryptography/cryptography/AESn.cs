using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace cryptography
{
    public static class AESn
    {
        /// <summary>
        /// Hàm này dùng để mã hóa dữ liệu theo giải thuật AES.
        /// </summary>
        /// <param name="plaintext">
        /// Đây là chuỗi cần mã hóa thuộc kiểu string.
        /// </param>
        /// <param name="Key">
        /// Khóa được dùng để mã hóa thuộc kiểu dữ liệu byte[].
        /// </param>
        /// <param name="IV">
        /// Vector khởi tạo để dùng được mã hóa thuộc kiểu dữ liệu byte[].
        /// </param>
        /// <param name="mode">
        /// Chế độ mã hóa:
        /// 1. ECB
        /// 2. CBC
        /// 3. CFB
        /// </param>
        /// <returns>
        /// Giá trị trả về là chuỗi đã được mã hóa thuộc kiểu dữ liệu byte[].
        /// </returns>
        public static byte[] EncryptStringToBytes_Aes(string plaintext, string key, string mode)
        {
            if (plaintext == null || plaintext.Length <= 0)
                throw new ArgumentNullException("plainText");

            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                if (mode == "ECB") aesAlg.Mode = CipherMode.ECB;
                else if (mode == "CBC") aesAlg.Mode = CipherMode.CBC;
                else if (mode == "CFB") aesAlg.Mode = CipherMode.CFB;

                aesAlg.Key = Convert.FromBase64String(key); ;
                aesAlg.IV = ASCIIEncoding.ASCII.GetBytes(key.Substring(0, 16));

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
                return encrypted;
            }
        }

        /// <summary>
        /// Hàm này được dùng để giải mã dữ liệu theo giải thuật AES.
        /// </summary>
        /// <param name="cipherText">
        /// Đây là chuỗi đã được mã hóa.
        /// </param>
        /// <param name="Key">
        /// Key dùng để giải mã thuộc kiểu dữ liệu byte[].
        /// </param>
        /// <param name="IV">
        /// Vector khởi tạo dùng để giải mã thuộc kiểu dữ liệu byte[].
        /// </param>
        /// <param name="mode">
        /// Chế độ giải mã:
        /// 1. ECB
        /// 2. CBC
        /// 3. CFB
        /// </param>
        /// <returns>
        /// Giá trị trả về là chuỗi đã được giải mã thuộc kiểu string.
        /// </returns>
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, string key, string mode)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                if (mode == "ECB") aesAlg.Mode = CipherMode.ECB;
                else if (mode == "CBC") aesAlg.Mode = CipherMode.CBC;
                else if (mode == "CFB") aesAlg.Mode = CipherMode.CFB;

                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = ASCIIEncoding.ASCII.GetBytes(key.Substring(0, 16));

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
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


        /// <summary>
        /// Hàm này dùng để sinh khóa ngẫu nhiên.
        /// </summary>
        /// <param name="cbSelectKeyLength">
        /// Kích thước của khóa thuộc kiểu int.
        /// </param>
        /// <returns>
        /// Giá trị trả về là khóa được sinh ra thuộc kiểu byte[].
        /// </returns>
        public static byte[] generate_key(int cbSelectKeyLength)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            if (cbSelectKeyLength != 0)
            {
                if (cbSelectKeyLength == 128)
                    aes.KeySize = 128;
                else if (cbSelectKeyLength == 192)
                    aes.KeySize = 192;
                else aes.KeySize = 256;
                aes.GenerateKey();
            }
            return aes.Key;
        }

        /// <summary>
        /// Hàm này để sinh vector khởi tạo.
        /// </summary>
        /// <returns>
        /// Giá trị trả về là vector khởi tạo thuộc kiểu byte[].
        /// </returns>
        public static byte[] generate_IV()
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.GenerateIV();
            return aes.IV;
        }
    }
}
