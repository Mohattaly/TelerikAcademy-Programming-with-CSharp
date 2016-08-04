using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DeclareTwoStringVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // 09. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.


            string withQuote = "\"The \"use\" of quotations causes difficulties.\"";
            string withOutQuote = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(withQuote);
            Console.WriteLine(withOutQuote);



        }
    }
}
