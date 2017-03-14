using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonacciProg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                int a = 0, x;
                int b = 1;
                Console.Write(" ");
                for (int i = 0; i <= n; i++)
                {
                    x = a + b;
                    a = b;
                    b = x;
                    Console.Write("{0} ", x);
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("enter a valid integer");
            }
        }
    }
}
