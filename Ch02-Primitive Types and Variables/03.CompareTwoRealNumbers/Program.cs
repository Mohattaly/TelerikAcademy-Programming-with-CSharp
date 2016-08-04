using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareTwoRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            // 03. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.


            float number1 = 12.123456789f;
            float number2 = 12.123456779f;

            bool equal = Math.Abs(number1 - number2) < 0.000001;
            Console.WriteLine(equal);


        }
    }
}
