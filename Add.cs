using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata_opgave
{
    class Add
    {
        LærerClass GetInput(string g)
        {
            LærerClass lærer = new LærerClass();
            Console.WriteLine("ADD NEW Lærer");
            Console.Write("Name: ");
            lærer.Name = Console.ReadLine();

            foreach (var fag in Enum.GetValues(typeof(FagType)))
            {
                Console.WriteLine((int)fag + " " + fag.ToString());
            }
            Console.WriteLine("Fag: ");
            FagType g = new FagType();
            while(!Enum.TryParse(Console.ReadLine(), out g))
            {
                Console.WriteLine("Wrong Input");
            }
            lærer.lærerfag = g;

            return lærer;


        }
    }
}
