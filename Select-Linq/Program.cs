using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textoNumero =
                from n in numeros
                select strings[n];
            Console.WriteLine("Numeros:");
            foreach (var nums in numeros)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nNumeros en string:");
            foreach (var palabra in textoNumero)
            {
                Console.Write(palabra + " ");
            }
            Console.ReadLine();
        }
    }
}
