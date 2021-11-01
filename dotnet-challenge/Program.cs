using System;
using System.Collections.Generic;
namespace Iacob_Calin
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] v = { 200 };
            Console.WriteLine($"Prima valoare a vectorului in momentul de fata este {v[0]}");
            schimba(v);
            Console.WriteLine($"Prima valoare a vectorului este acum {v[0]}");
        }
        static void schimba(int[] x)
        {
            Console.WriteLine("Inlocuiti prima valoare a vectorului!");
            Console.WriteLine("Introduceti numarul cu care doriti sa inlocuiti: ");
            x[0] = Convert.ToInt32(Console.ReadLine());
        }
}
}
