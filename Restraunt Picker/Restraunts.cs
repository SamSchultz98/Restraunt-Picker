using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restraunt_Picker
{
    public class Restraunts
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string priceRange { get; set; }
        public string cusine { get; set; }
        public bool sitIn { get; set; }
        public bool driveThru { get; set; }
        public bool preference { get; set; } = true;
        public int IndxValue { get; set; } = 0;
    }
    
}

   