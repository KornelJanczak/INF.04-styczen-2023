using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_04_2023_styczen_algorytm_euklidesa
{
    internal static class Program
    {
       public static void Main() //zawiera operacje wejścia/wyjścia
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNumber(firstNumber, secondNumber));

            Console.ReadLine();
        }

        private static int FindNumber(int a, int b) {
            int NWD;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }

            }

                NWD = a;
                return NWD;
        }
    }
}
