using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SharePointListComparer.Utilities
{
    /// <summary>
    /// .Net Standard compatible cryptography class, utilising Aes encryption among other techniques.
    /// </summary>
    public static class PortableCryptography
    {
        private static readonly byte[] defaultSalt = Encoding.ASCII.GetBytes("SharePointComparer");

        /// <summary>
        /// Simple SHA512 hash. Appends a default salt for you. (Oneway)
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        public static string HashSHA512(this string value)
        {
            StringBuilder strBuilder = new StringBuilder(value);
            strBuilder.Append(defaultSalt);

            using (var sha = SHA512.Create())
            {
                return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(strBuilder.ToString())));
            }
        }

        /// <summary>
        /// Reversible encryption. AES 256 requires a 32 byte key to encrypt.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="keyBytes"></param>
        /// <returns></returns>
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            byte[] salt = new byte[] { 80, 70, 60, 50, 40, 30, 20, 10 };
            int iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, salt, iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        /// <summary>
        /// Takes a value and a key, utilises Aes encryption and IV randomiser to ensure no returned encrypted string is identical.
        /// </summary>
        /// <param name="clearValue"></param>
        /// <param name="encryptionKey"></param>
        /// <returns>string</returns>
        public static string Encrypt(this string clearValue, string encryptionKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = CreateKey(encryptionKey);

                byte[] encrypted = AesEncryptStringToBytes(clearValue, aes.Key, aes.IV);
                return Convert.ToBase64String(encrypted) + ";" + Convert.ToBase64String(aes.IV);
            }
        }

        /// <summary>
        /// Private method used to perform the encryption of the passed through paramaters.
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns>byte[]</returns>
        private static byte[] AesEncryptStringToBytes(string plainText, byte[] key, byte[] iv)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException($"{nameof(plainText)}");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException($"{nameof(key)}");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException($"{nameof(iv)}");

            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }
                    encrypted = memoryStream.ToArray();
                }
            }
            return encrypted;
        }

        /// <summary>
        /// Takes an existing, encrypted value and the key, returns the original clear text string.
        /// </summary>
        /// <param name="encryptedValue"></param>
        /// <param name="encryptionKey"></param>
        /// <returns>string</returns>
        public static string Decrypt(this string encryptedValue, string encryptionKey)
        {
            if (string.IsNullOrEmpty(encryptedValue))
            {
                return string.Empty;
            }

            string iv = encryptedValue.Substring(encryptedValue.IndexOf(';') + 1, encryptedValue.Length - encryptedValue.IndexOf(';') - 1);
            encryptedValue = encryptedValue.Substring(0, encryptedValue.IndexOf(';'));

            return AesDecryptStringFromBytes(Convert.FromBase64String(encryptedValue), CreateKey(encryptionKey), Convert.FromBase64String(iv));
        }

        /// <summary>
        /// Private method for performing the decryption of the existing value and key
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns>string</returns>
        private static string AesDecryptStringFromBytes(byte[] cipherText, byte[] key, byte[] iv)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException($"{nameof(cipherText)}");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException($"{nameof(key)}");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException($"{nameof(iv)}");

            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream(cipherText))
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                using (StreamReader streamReader = new StreamReader(cryptoStream))
                    plaintext = streamReader.ReadToEnd();
            }
            return plaintext;
        }

    }
}
