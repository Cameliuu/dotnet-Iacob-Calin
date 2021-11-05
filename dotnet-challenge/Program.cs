using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace Iacob_Calin
{
    class Program
    {
        public enum optiuni { iesire, reg, log, sch, delog, dele, afis }; //Nu stiu de ce nu merge sa declar enum-ul in Main :(
        static void Main(string[] args)
        {
            bool isLoggedIn=false;
            string key = "";
            string value = "";
        User user = new User();
            Dictionary<string, string> emails = new Dictionary<string, string> { };
            while(true)
            {
                Console.WriteLine("-----------------------------------------------------------------------");
                if (isLoggedIn) Console.WriteLine($"Sunteti logat drept {key}({value})");
                else Console.WriteLine("Nu sunteti logat!");
                Console.WriteLine("Bine ati venit!");
                Console.WriteLine("Alegeti optiunea dorita!");
                Console.WriteLine("0.Iesire");
                Console.WriteLine("1.Inregistreaza un email");
                Console.WriteLine("2.Logare");
                Console.WriteLine("4.Delogare");
                Console.WriteLine("5.Stergere Cont");
                Console.WriteLine("6.Afiseaza useri");
                Console.Write("OPTIUNEA DUMNEAVOASTRA:");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case (int)optiuni.iesire:
                        Console.WriteLine("Programul se va inchide acum!...\n\n");
                        Environment.Exit(0);
                        break;
                    case (int)optiuni.reg:

                        user.Email = getEmail();
                        if (user.isEmailAvailable(emails, user.Email))
                        {
                            user.Name=getName();
                            emails.Add(user.Name, user.Email);
                            Console.WriteLine($"Contul {user.Name} cu email-ul {user.Email} a fost adaugat!");
                        }
                        else Console.WriteLine("Email-ul introdus nu este valabil!\nVa rugam incercati din nou\n\n");
                        break;

                    case (int)optiuni.log:
                        if (!isLoggedIn)
                        {
                            user.Name = getName();
                            if (emails.ContainsKey(user.Name))
                            {
                                user.Email = getEmail();
                                if (user.logInCheck(emails, user.Email))
                                {
                                    key = user.Name;
                                    value = user.Email.Trim();
                                    isLoggedIn = true;
                                    Console.WriteLine("Autentificare reusita");

                                }
                                else Console.WriteLine("Credentiale incorecte!Va rugam incercati din nou!\n\n");
                            }
                            else
                                Console.WriteLine("Autentificare esuata\nVa rugam incercat din nou!\n");
                        }
                        else Console.WriteLine($"Sunteti deja autentificat drept {key}");
                        break;

                    case (int)optiuni.delog:
                        if(isLoggedIn)
                        {
                            Console.WriteLine("Delogare efectuata cu succes!\n\n");
                            key = "";
                            value ="";
                            isLoggedIn = false;
                        }
                        else Console.WriteLine("Nu sunteti logat!\n\n");
                        break;

                    case (int)optiuni.dele:
                        if(isLoggedIn)
                        { 
                            Console.WriteLine($"Sunteti sigur ca vreti sa stergeti contul {key} asociat contului {value}? (Y/N)");
                            if (Console.ReadLine().ToUpper().Equals("Y"))
                            {
                                emails.Remove(key);
                                Console.WriteLine("Stergerea a avut loc cu succes..Veti fi delogat acum!\n\n");
                                value = "";
                                isLoggedIn = false;
                            }
                            else Console.WriteLine("Stergere abandonata!\n\n");
                        }
                        break;
                    case (int)optiuni.afis:
                        Console.WriteLine("-----------------------------\n\n");
                        foreach (var x in emails)
                            Console.Write($"Nume:{x.Key}\nEmail:{x.Value}\n\n");
                        Console.WriteLine("-----------------------------\n\n");
                        break;
                }
                static string getEmail()
                {
                    Console.WriteLine("Introduceti email ul:");
                    return Console.ReadLine();
                }
                static string getName()
                {
                    Console.WriteLine("Introduceti numele: ");
                    return Console.ReadLine();
                }
            }   
        }
    }
}

