using System;
using System.Collections.Generic;
namespace Iacob_Calin
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            string[] n = getName().Split(" ");
            person1.LastName = n[0];
            person1.FirstName = n[1];
            person1.Age = getAge();
            n = getName().Split(" ");
            person2.LastName = n[0];
            person2.FirstName = n[1];
            person2.Age = getAge();

            if (isOlder(person1.Age, person2.Age))
                Console.WriteLine($"{person1.FullName} este mai mare decat {person2.FullName}, diferenta dintre acestia fiind de {Math.Abs(person1.Age - person2.Age)} ani");
             else
                Console.WriteLine($"{person2.FullName} este mai mare decat {person1.FullName}, diferenta dintre acestia fiind de {Math.Abs(person1.Age - person2.Age)} ani");
        }
        static string getName()
        {
            Console.WriteLine("Dati un nume (EX: NumeFamilie Prenume) ");
            string n = Console.ReadLine();
            return n;
        }
        static int getAge()
        {
            Console.WriteLine("Introduceti varsta: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static bool isOlder(int a, int b)
        {
            if (Math.Max(a, b) == a)
                return true;
            else
                return false;
        }
    }
}

