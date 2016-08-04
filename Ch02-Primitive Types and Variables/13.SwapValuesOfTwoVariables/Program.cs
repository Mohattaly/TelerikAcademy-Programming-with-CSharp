using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SwapValuesOfTwoVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // 13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.

            int firstNumber = 5;
            int secondNumber = 10;

            Console.WriteLine("Before Swap.");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            Console.WriteLine("After Swap.");


            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;


            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

        }
    }
}
