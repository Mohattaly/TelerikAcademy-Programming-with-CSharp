using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateWeightOfManOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {

            // The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


               Console.WriteLine("Please Enter your weight: ");
               double weight = double.Parse(Console.ReadLine());
               Console.WriteLine("Your weight on Earth is: {0}kg  , Your weight on the is: {1}kg", weight,(weight * 0.17));


        }
    }
}
