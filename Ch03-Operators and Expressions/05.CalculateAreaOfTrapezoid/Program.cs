using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateAreaOfTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write an expression that calculates the area of a trapezoid by given sides a, b and height h.//

        
		Console.WriteLine("Side A= ");
		double sideA = double.Parse(Console.ReadLine());
		Console.WriteLine("Side B= ");
		double sideB = double.Parse(Console.ReadLine());
		Console.WriteLine("Height H= ");
		double heightH = double.Parse(Console.ReadLine());
        
		Console.WriteLine("The area of trapezoid is :{0}",((sideA+sideB)*heightH)/2);


        }
    }
}
