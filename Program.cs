using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool divideSigh = false;

            Console.WriteLine("Prime number \n");

            Console.WriteLine("Приложение для определения простого числа");
            Console.WriteLine("Назови число, а я тебе скажу, просто оно или составное.");

            for (; ; )
            {
                Console.WriteLine("Введите число:");
                string userNumberInput = Console.ReadLine();
                int userNumber = Convert.ToInt32(userNumberInput);

                for (int i = 2; i < userNumber; i++)
                {
                    if (userNumber % i == 0)
                    {
                        divideSigh = true;
                        break;
                    }
                    else
                    {
                        divideSigh = false;
                    }
                }

                if (divideSigh)
                {
                    Console.WriteLine("Число составное. Ещё разок?");
                }
                else
                {
                    Console.WriteLine("Число простое. Ещё разок?");
                }
            }
        }
    }
}
