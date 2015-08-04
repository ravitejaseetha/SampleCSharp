using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers from 1 to 100 :");
            for (int i = 2; i < 100; i++)
            {
                for (int j = 2; j < 100; j++)
                {
                    if (i!=j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("\t " +i);

                }
                isPrime = true;
            }
            
            //Check whether number is prime or not
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result =0;
            for (int i = 1; i <= number -1 ; i++)
            {
                if (number%i == 0)
                {
                    result++;
                }
            }
            if (result == 1)
            {
                Console.WriteLine("Entered number is a prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadKey();
        }
    }
}
