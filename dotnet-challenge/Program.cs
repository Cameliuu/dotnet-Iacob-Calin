using System;
using System.Collections.Generic;
namespace Iacob_Calin
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.print();
        }
        void print()
        {
         
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Printing stuff using methods");

        }
    }
}
