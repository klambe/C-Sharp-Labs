

using System.Collections.Generic;
/**
* x00123743
* Chuong Trung Vuong
*/
namespace CA1_2016_Cart
{
    public class ElectricalItem : ICartAble
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsWEEE { get; set; } // additional read/write property, item recyclable or not                       
    }
}
