/**
 * x00123743
 * Chuong Trung Vuong
 */

using System;
using System.Collections.Generic;

namespace CA1_2016_Cart
{
    public class CartItem : ICartAble
    {
        string productCode;

        // default constructor provided by default

        public string ProductCode
        {
            get
            {
                return productCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product code cannot be null or white space");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Product code must be 5 or more characters in length");
                }
                productCode = value;
            }
        }

        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } // additional property with read/write   

        public override bool Equals(object obj)
        {
            var item = obj as CartItem;
            return item != null &&
                   ProductCode == item.ProductCode &&
                   Description == item.Description &&
                   Price == item.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = -2012449900;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format("Product Code: {0,-10}  Description: {1,-20}  Price: {2,5}  Quantity: {3,4}",
                ProductCode, Description, Price, Quantity);
        }
    }
}
