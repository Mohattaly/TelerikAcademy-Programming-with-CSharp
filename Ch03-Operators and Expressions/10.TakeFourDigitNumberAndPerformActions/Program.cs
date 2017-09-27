using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TakeFourDigitNumberAndPerformActions
{
    class Program
    {
        static void Main(string[] args)
        {



           /* // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
-     Calculates the sum of the digits (in our example 2+0+1+1 = 4).
-     Prints on the console the number in reversed order: dcba (in our example 1102).
-     Puts the last digit in the first position: dabc (in our example 1201).
-     Exchanges the second and the third digits: acbd (in our example 2101).

                */
             
            

            Console.Write("Please Enter 4 digit number: ");
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = number / 100;
            b = b % 10;
            int c = number / 10;
            c = c % 10;
            int d = number % 10;
            
           

            Console.WriteLine("Sum of digits of the number {0} is: {1} ", number, (a + b + c + d));
            Console.WriteLine("The number Reversed is:{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit first is:{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchange the Second and third digit positions:{0}{1}{2}{3}", a, c, b, d);



        }
    }
}
