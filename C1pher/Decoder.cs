using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Decoder
    {
        public void Decrypt(Logic L) {
            if (L != null)
                L.Decrypt();
        }

        public void ChoosePassword(Decoder D)
        {
            Console.WriteLine(" NOW AVAILABLE: caesar, vigenere, xor");
            string c = Console.ReadLine();
            switch (c)
            {
                case "caesar":
                    D.Decrypt( new Caesar() );
                    break;
                case "vigenere":
                    D.Decrypt( new Vigenere() );
                    break;
                case "xor":
                    D.Decrypt( new XOR() );
                    break;
                default:
                    Console.WriteLine(" Undefined cipher");
                    break;
            }
        }
    }
}
