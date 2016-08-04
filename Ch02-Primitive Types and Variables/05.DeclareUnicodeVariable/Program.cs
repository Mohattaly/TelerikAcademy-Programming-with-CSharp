using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DeclareUnicodeVariable
{
    class Program
    {
        static void Main(string[] args)
        {

            // 05. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).

            char charVar = '\u0190';
            Console.WriteLine(charVar);


        }
    }
}
