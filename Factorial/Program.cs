using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact, number;
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (int j = number-1; j >= 1; j--)
            {
                fact = fact*j;
            }
            Console.WriteLine("Factorial of the given number is: " +fact);
            Console.ReadKey();
        }
    }
}
