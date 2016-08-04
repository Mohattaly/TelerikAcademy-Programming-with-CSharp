using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {

            // 01. Write an expression that checks whether an integer is odd or even.

            Console.WriteLine("Type a number....");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {

                Console.WriteLine("This number is Even");
            }

            else
            {
                Console.WriteLine("This number is odd");
            }

        }
    }
}
