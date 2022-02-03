using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp800
{
    internal class Program
    {
        static void Main(string[] args)
        {

            { 
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("F1) 1");
                Console.WriteLine("F2) 1");

                int n_1 = 1;
                int n_2 = 1;

                for (int i = 3; i <= n; ++i)
                {
                    var n_3 = n_1 + n_2;
                    Console.WriteLine("F{0}) {1}", i, n_3);
                    n_1 = n_2;
                    n_2 = n_3;
                }
                Console.ReadKey();
            }







        }
    }
}
