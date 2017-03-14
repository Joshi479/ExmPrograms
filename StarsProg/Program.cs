using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsProg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number of rows to be printed.");
                int value = int.Parse(Console.ReadLine());

                for (int i = 0; i <= value; i++)
                {
                    for (int j = 0; j < value - i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Enter a valid positive integer");
            }
        }
    }
}
