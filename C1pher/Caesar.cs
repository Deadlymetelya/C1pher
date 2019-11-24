using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Caesar : Logic
    {
        public void Encrypt() {
            getInfo();
            encode(CaesarStep, SourceString);
        }


        const string Alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        private int CaesarStep;
        private string SourceString;

        private void getInfo() {
            Console.WriteLine("enter the phrase which you want to convert");
            SourceString = Console.ReadLine();
            Console.WriteLine("enter the step of cipher");
            CaesarStep = Console.Read();
        }
        private void encode(int key, string text) {
            var FullAlfabet = Alfabet + Alfabet.ToLower();
            var LetterQty = FullAlfabet.Length;
            var RetVal = "";
            for (int i = 0; i < text.Length; i++) {
                var c = text[i];
                var index = FullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //Can't match the letter - add it from raw
                    RetVal += c.ToString();
                }
                else
                {
                    var CodeIndex = (LetterQty + index + key) % LetterQty;
                    RetVal += FullAlfabet[CodeIndex];
                }
            }
            Console.WriteLine(RetVal);
        }
    }
}
