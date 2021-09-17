using System;
using System.Collections.Generic;
using System.ComponentModel;
using Uddata_opgave.Models;

namespace Uddata_opgave.Views
{
    class Uddata_opgave
    {

        public void ShowAllLærer(List<Lærer> lærers)
        {
            Console.WriteLine("\n*** SHOW ALL Lærer ***");
            foreach (var lærer in LærerList)
            {
                Console.WriteLine("");
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(lærer))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(lærer;
                    Console.WriteLine($"{name}: {value}");
                }

            }
        }

        public void Show(Object xyz)
        {
            Console.WriteLine("*** SHOW Lærer ***");
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(xyz))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(xyz);
                Console.WriteLine($"{name}: {value}");
            }
        }

        public LærerClass AddLærer(string g)
        {
            LærerClass lærer = new LærerClass();
            Console.WriteLine("ADD NEW Lærer");

            Console.Write("Name: ");
            lærer.Name = Console.ReadLine();
            kaffeklubmedlem(lærer);

            foreach (var fag in Enum.GetValues(typeof(FagType)))
            {
                Console.WriteLine((int)fag + " " + fag.ToString());
            }
            Console.Write("Gender: ");
            FagType g = new FagType();
            while (!Enum.TryParse(Console.ReadLine(), out g))
            { Console.WriteLine("Wrong input, please try again."); }
            lærer.lærerfag = g;            

            return lærer;
        }

        private static void kaffeklubmedlem(LærerClass lærer)
        {
            bool IsKlubOk=false;
            do
            {               
                try
                {
                    Console.Write("Medlem af kaffeklub (ja eller nej): ");
                    string kaffeklub_temp = Console.ReadLine().ToLower();
                    if (kaffeklub_temp != "ja")
                    {
                        lærer.kaffeklubben = true;
                        IsKlubOk = true;
                    }
                    else if (kaffeklub_temp != "nej")
                    {
                        lærer.kaffeklubben = false;
                        IsKlubOk = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType());
                }
                
            }
            while (IsKlubOk);
        }
    }
}
