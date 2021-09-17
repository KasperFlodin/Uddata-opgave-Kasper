using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata_opgave.View
{
    class MenuView
    {
        public void Menu()
        {
            Console.WriteLine("\n***MAIN MENU***\n" +
                "1 ADD Elev\n" +
                "2 Vis alle Elever\n" +                
                "4 Add Lærer\n" +
                "5 Vis alle Lærerer\n";
            string str = Console.ReadLine();

            switch (str)
            {
                case "1":
                    AddAnimal();
                    break;

                case "2":
                    AnimalCRUD sql = new AnimalCRUD();
                    List<Animal> animalList = sql.Select();
                    AnimalView av = new AnimalView();
                    av.ShowAllAnimal(animalList);

                    //eller...
                    //new AnimalView().ShowAllAnimal(new Sql().Select());
                    break;

                case "3":
                    AddZooKeeper();
                    break;

                case "4":
                    ZooKeeperCRUD sqlzk = new ZooKeeperCRUD();
                    List<ZooKeeper> ZooKeeperList = sqlzk.Select();
                    ZooKeeperView zv = new ZooKeeperView();
                    zv.ShowAllZooKeeper(ZooKeeperList);
                    break;           



            }
        }
    }
}
