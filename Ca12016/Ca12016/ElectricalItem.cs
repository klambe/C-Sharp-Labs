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

        public override bool Equals(object obj)
        {
            var item = obj as ElectricalItem;
            return item != null &&
                   ProductCode == item.ProductCode &&
                   ProductDescription == item.ProductDescription &&
                   ProductPrice == item.ProductPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -2012449900;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductDescription);
            hashCode = hashCode * -1521134295 + ProductPrice.GetHashCode();
            return hashCode;
        }


    }
}
