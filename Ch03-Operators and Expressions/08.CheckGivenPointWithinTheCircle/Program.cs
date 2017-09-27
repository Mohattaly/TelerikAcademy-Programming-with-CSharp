using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CheckGivenPointWithinTheCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            //   Write an expression that checks for a given point {x, y} if it is within the circle K[{0, 0}, R=5]. Explanation: the point {0, 0} is the center of the circle and 5 is the radius.

            Console.WriteLine("Enter Point X: ");
            decimal pointX =decimal.Parse(Console.ReadLine());
            Console.Write("Enter Point Y: ");
            decimal pointY = decimal.Parse(Console.ReadLine());
            decimal radius = 5;
            bool result = pointX * pointX + pointY * pointY <= radius * radius ;
            Console.WriteLine(result? "The point ({0},{1}) is in the circle." : "The point ({0},{1}) is outside",pointX, pointY);
            

        }
    }
}
