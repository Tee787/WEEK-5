using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk1OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("*************************** Odd Numbers ******************************");
            Console.WriteLine("**********************************************************************\n");

            Console.WriteLine("Odd numbers starting from 76 and ending @ 46: ");
            for (int n = 46; n < 76; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
