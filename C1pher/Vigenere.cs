using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Vigenere : Logic
    {
        public void Encrypt() {
            setInfo();
            encode(SourceString, Password);
        }
        public void Decrypt() {
            setInfo();
            decode(SourceString, Password);
        }

        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";



        private string SourceString;
        private string Password;




        private void setInfo() {
            Console.WriteLine(" enter the phrase which you want to convert");
            SourceString = Console.ReadLine().ToUpper();
            Console.WriteLine(" enter the key-pass");
            Password = Console.ReadLine().ToUpper();
        }

        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }
        private void encode(string plainMessage, string password) {
                vigenere(plainMessage, password);
        }
        private void decode(string encryptedMessage, string password) {
                vigenere(encryptedMessage, password, false);
        }
        private void vigenere(string text, string password, bool encrypting = true)
        {

            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = defaultAlphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = defaultAlphabet.IndexOf(text[i]);
                var codeIndex = defaultAlphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //Can't match the letter - add it from raw
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += defaultAlphabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            Console.WriteLine(retValue);
        }
    }
}
