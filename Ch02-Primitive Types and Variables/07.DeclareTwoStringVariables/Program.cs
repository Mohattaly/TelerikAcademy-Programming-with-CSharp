using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DeclareTwoStringVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // 07. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.


            string varOne = "Hello";
            string varTwo = "World";
            object varThree = varOne + " " + varTwo;

            Console.WriteLine(varThree);

        }
    }
}
