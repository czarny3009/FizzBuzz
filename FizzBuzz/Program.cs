using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string input;

            do
            {
                Console.Write("Podaj liczbę (lub wpisz 'exit', aby zakończyć): ");
                input = Console.ReadLine();

                if (input.ToLower() != "exit")
                {
                    if (int.TryParse(input, out int number))
                    {
                        string result = fizzBuzz.CheckNumber(number);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Proszę podać prawidłową liczbę.");
                    }
                }

            } while (input.ToLower() != "exit");

            Console.WriteLine("Koniec programu.");
        }
    }

    class FizzBuzz
    {
        public string CheckNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
