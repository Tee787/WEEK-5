using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk3Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("***************************Rectangle*******************************");
            Console.WriteLine("*******************************************************************\n");

            Console.Write("Enter the height of the rectangle: ");
            int Height = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            //Display lines
            for (int i = 1; i <= Height; i++)
            {
                //Display columns
                for (int j = 1; j <= Width; j++)
                {                   
                   Console.Write("$");                                       
                }
                //Go to the next line
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
