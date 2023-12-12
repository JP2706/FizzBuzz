using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz");
            var fizzBuzz = new FizzBuzz();
            while (true)
            {
                Console.Write("Podaj liczbe:");
                var userNum = GetNum();
                Console.WriteLine(fizzBuzz.UserChoice(userNum));
                Console.WriteLine("Chcesz sprawdzić kolejną liczbę?(Jeśli nie to wpisz nie)");
                if (Console.ReadLine() == "nie")
                    break;
            }
        }

        private static int GetNum()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNum))
                {
                    Console.Write("Błędne dane\nPodaj właściwe dane:");
                    continue;

                }

                return userNum;
            }
        }
    }
}
