using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            char H = 'H';
            char E = '\u0045';
            char L = (char)76;
            char O = '\u004F';

            Console.WriteLine(H + " " + E + " " + L + " " + L + " " + O);

            H = 'O';
            E = 'K';

            Console.WriteLine(H + " " + E);

            /*
                Wait for console 
            */
            Console.ReadKey();
        }
    }
}
