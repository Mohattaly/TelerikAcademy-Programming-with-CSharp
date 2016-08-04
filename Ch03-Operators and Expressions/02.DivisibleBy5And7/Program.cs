using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DivisibleBy5And7
{
    class Program
    {
        static void Main(string[] args)
        {


            // 02. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.


            Console.WriteLine("Enter a number to check wether is it divisible by 5 and 7");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("This number is divisible by 5 & 7");
            }

            else
            {
                Console.WriteLine("This number is not divisible by both 5 and 7");
            }

        }
    }
}
