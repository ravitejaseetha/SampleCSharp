using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    class Program
    {
        static void Main(string[] args)
        {
           fib(9);
            Console.WriteLine("nth fibonacci number {0}", GetFib(4));
            Console.ReadKey();
        }

        public static void fib(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1}",a,b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine("{0}",c);
                a = b;
                b = c;
            }
        }

        public static int GetFib(int num)
        {
            int number = num - 1;
            int[] fib = new int[number + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            return fib[number];
        }
    }
   
}
