using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk2RepeatCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("***************************Repeat Characters************************");
            Console.WriteLine("********************************************************************\n");

            Console.WriteLine("Enter a character (!,@,#,$,%.^,&,*): ");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a number count between 1 and 10: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                Console.Write($"{symbol}");                
            }
            Console.ReadLine();
        }
    }
}
