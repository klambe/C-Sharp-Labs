using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca12016
{
    public class ElectricalItem : ICartable
    {

        public string ProductCode { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }
        public bool Recyclable { get; set; }

        
    }
}
