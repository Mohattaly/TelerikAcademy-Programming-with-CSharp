using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintIsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            // 11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".


            //Console.WriteLine("©");



        Console.OutputEncoding = Encoding.UTF8;
		char copyChar = '\u00A9';
		string firstLine = "  " + copyChar;
		string secondLine = " " + copyChar + copyChar + copyChar;
		string thirdLine = "" + copyChar + copyChar + copyChar + copyChar + copyChar;
		Console.WriteLine(firstLine);
		Console.WriteLine(secondLine);
		Console.WriteLine(thirdLine);



        }
    }
}
