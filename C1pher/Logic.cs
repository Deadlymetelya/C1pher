using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    interface Logic {
        void Encrypt();
        void Decrypt();
    }

    class Event {

        internal string action;
        const string startMessage = " Welcome to C1pher v.02.\n Please, choose what you want to do - \"decode\" or \"encode\".\n Also, you can write \"exit\" to leave";
        public void ChooseAction() {
            Console.WriteLine(startMessage);
            action = Console.ReadLine();
            switch (action)
            {
                case "decode":
                    Console.WriteLine(" Decoder created");
                    var decoder = new Decoder();
                    decoder.ChoosePassword(decoder);
                    break;
                case "encode":
                    Console.WriteLine(" Encoder created");
                    var encoder = new Encoder();
                    encoder.ChoosePassword(encoder);
                    break;
                case "exit":
                    Console.WriteLine(" Shutting program...\n Press any key to leave");
                    break;
                default:
                    break;
            }
        }
    }
}
