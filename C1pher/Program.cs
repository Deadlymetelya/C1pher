using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {   
            var start = new Event();

            do
            {
                start.ChooseAction();
            }
            while (start.action != "exit");
            Console.ReadKey();
        }
    }
}
