using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss, srev = "";
            string s, rev = "";
            Console.WriteLine("Enter string");
            s = Console.ReadLine();
            for (int i = s.Length-1; i >=0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s)
                Console.WriteLine("String is palindrome\nEntered string is {0} and reverse of the string is {1}",s,rev);
            else
                Console.WriteLine("Entererd string is not a palindrome");
            Console.ReadKey();
        }
    }
}
