using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {


            // 03. Write an expression that looks for a given integer if its third digit (right to left) is 7.

            Console.WriteLine("Enter a number to check of its third digit equal 7");
            int number = Convert.ToInt32(Console.ReadLine());
            int newNumber = number / 100;
            int thirdNumber = newNumber / 10;

            if (thirdNumber == 7)
            {
                Console.WriteLine("The third number is 7");
            }

            else
            {
                Console.WriteLine("The third number is not 7");
            }


        }
    }
}
