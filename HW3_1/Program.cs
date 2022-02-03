using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp778
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Введите кол-во чисел в последовательности: ");
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
    }
}           