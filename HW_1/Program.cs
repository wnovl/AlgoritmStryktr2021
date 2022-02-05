using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
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
            feb();
            Console.WriteLine();
            febrek();
        }
        static void feb()
        {

            int n = 0;
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Введите кол-во чисел в последовательности: ");
                int.TryParse(Console.ReadLine(), out n);
                if (n < 2)
                {
                    Console.WriteLine("минимальное кол-во чисел - 2");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    numbers.Add(0);
                    numbers.Add(1);
                    break;
                }
            }

            for (int i = 0; i < (n - 2); i++)
                numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);

            foreach (int tmp in numbers)
                Console.Write(tmp + " ");

            Console.ReadKey(true);
        }



        static void febrek()
        {
            Console.Write("Введите кол-во чисел в последовательности: ");
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
