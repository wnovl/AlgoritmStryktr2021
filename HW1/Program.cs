
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод числа:");
            int number = int.Parse(Console.ReadLine());
            int d = 0;


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    d = d + 1;


                }
            }


            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
        }
    }
}
