using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata_opgave
{
    sealed class LærerClass : BaseClass
    {
        public bool kaffeklubben { get; set; }

        public string lærerfag {  get; set; }

        public List<LærerClass> lærerlist {  get; set; }
        List<LærerClass> lærers = new List<LærerClass>();

    }

}
