using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.DeclareTwoStringVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // 08. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).


            string varOne = "Hello";
            string varTwo = "World";
            object helloWorld = varOne + " " + varTwo;

            string str = (object)helloWorld;


        }
    }
}
