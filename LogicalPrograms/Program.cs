using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion  Program");
            Console.WriteLine("Enter the number temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is :" + celsius);
            Console.ReadLine();
        }
    }
}
