using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class XOR : Logic
    {
        public void Encrypt() {
            setInfo();
            encode(SourceString, Password);
        }
        public void Decrypt() {
            setInfo();
            decode(SourceString, Password);
        }

        private string SourceString;
        private string Password;

        private void setInfo() {
            Console.WriteLine(" enter the phrase which you want to convert");
            SourceString = Console.ReadLine();
            Console.WriteLine(" enter the key-pass");
            Password = Console.ReadLine();
        }

        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }
        private void encode(string plainMessage, string password) {
            xor(plainMessage, password);
        }
        private void decode(string encryptedMessage, string password)
        {
            xor(encryptedMessage, password);
        }
        private void xor(string text, string key) {
            var currentKey = GetRepeatKey(key, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            Console.WriteLine(res);
        }
    }
}
