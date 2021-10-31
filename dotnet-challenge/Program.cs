using System;
using System.Collections.Generic;
namespace Iacob_Calin
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string nume="%0";
            double nota1=0, nota2=0, nota3=0;
            program.input(ref nume, ref nota1, ref nota2, ref nota3);
            program.medie(nume, nota1, nota2, nota3);
        }
        void medie(string n, double a, double b, double c)
        {
           double  medie = (a + b + c) / 3;
            Console.WriteLine($"{n}, nota dumneavoastra la examenul de bacalaureat este {medie}");
        }
        void input(ref string n, ref double a, ref double b, ref double c )
        {
            Console.WriteLine("Introduceti numele dumneavoastra: ");
            n = Console.ReadLine();
            Console.WriteLine("Introduceti nota primita la prima proba: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti nota primita la cea de a doua proba: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti nota primita la cea de a treia proba: ");
            c = Convert.ToDouble(Console.ReadLine());

        }
    }
}
