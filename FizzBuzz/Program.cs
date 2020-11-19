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
            Console.WriteLine("FizzBuzz");
            Console.Write("Podaj liczbę");
            int usernumber = ItIsValidInt();
            var fizbuzz = new FizzBuzz();
            Console.WriteLine(fizbuzz.GiveSolution(usernumber));
        }

        private static int ItIsValidInt()
        {
            if (!(int.TryParse(Console.ReadLine(), out int result)))
                throw new Exception("To nie jest liczba");
            else
                return result;

        }
    }
}
