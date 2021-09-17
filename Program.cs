using System;
using System.Collections.Generic;
using Uddata_opgave.View;

namespace Uddata_opgave
{
    class Program
    {
        
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");
            new MenuView().Menu();




            ElevClass elev = new ElevClass();
            Console.WriteLine(elev);

            LærerClass lærer = new LærerClass();
            
            FagClass fag = new FagClass();

            
        }
    }
}
