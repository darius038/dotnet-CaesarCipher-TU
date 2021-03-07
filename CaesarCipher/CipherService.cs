using System;
using System.Text;

namespace CaesarCipher
{
    public static class CipherService
    {
        public static string Encrypt(string encryptText, int cipher)
        {
            if (encryptText.Length == 0) return String.Empty;

            var codeBuilder = new StringBuilder();

            foreach (var item in encryptText.ToUpper())
            {
                codeBuilder.Append(IsLetter(item) ? (char)('A' + ((item - 'A' + cipher) % 26)) : item);
            }

            return codeBuilder.ToString();
        }

        public static string Decrypt(string decryptText, int cipher)
        {
            if (decryptText.Length == 0 || decryptText == null) return String.Empty;

            var codeBuilder = new StringBuilder();

            foreach (var item in decryptText.ToUpper())
            {
                codeBuilder.Append(IsLetter(item) ? (char)('Z' - (('Z' - item + cipher) % 26)) : item);
            }

            return codeBuilder.ToString();
        }

        private static bool IsLetter(char letter)
        {
            return letter >= 'A' && letter <= 'Z';
        }
    }
}