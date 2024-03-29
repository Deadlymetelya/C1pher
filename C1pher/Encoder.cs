﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Encoder
    {
        public void Encrypt(Logic L) {
            if (L != null) {
                L.Encrypt();
            }
        }

        public void ChoosePassword(Encoder E) {
            Console.WriteLine(" NOW AVAILABLE: caesar, vigenere, xor");
            string c = Console.ReadLine();
            switch (c) {
                case "caesar":
                    E.Encrypt( new Caesar() );
                    break;
                case "vigenere":
                    E.Encrypt( new Vigenere() );
                    break;
                case "xor":
                    E.Encrypt( new XOR() );
                    break;
                default:
                    Console.WriteLine(" Undefined cipher");
                    break;
            }
        }
    }
}
