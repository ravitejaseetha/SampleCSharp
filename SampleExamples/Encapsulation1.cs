using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamples
{
     class Encapsulation1
    {
        private string accountName;

        public string GetAccount()
        {
            return accountName;
        }

        public void SetAccount(string name)
        {
            accountName = name;
        }


        private static void Main(string[] args)
        {

            Encapsulation1 pr = new Encapsulation1();
            pr.SetAccount("hello account");
            Console.WriteLine(pr.GetAccount());
            Console.ReadKey();

        }

    }
}

