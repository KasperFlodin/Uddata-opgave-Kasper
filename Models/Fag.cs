using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata_opgave
{
    public enum FagType { Matematik, Dansk, Fysik, Engelsk, Idræt }

    public class FagClass
    {
        public int Id { get; set; }
        public FagType FagNavn { get; set; }
    }
    
    //public enum karakter { -3, 0, 2, 4, 7, 10, 12 }
}
