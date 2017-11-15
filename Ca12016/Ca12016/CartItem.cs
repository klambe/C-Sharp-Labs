using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca12016
{
    public class CartItem :ICartable, IEquatable<CartItem>
    {
        string productCode;
        public string ProductCode {
            get
            {
                return productCode;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Product code contains white spaces and/or less than 5 characters in length");
                }
                else
                {
                    productCode = value;

                }
                
            }
        }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public bool Equals(CartItem other)
        {
            if (ProductCode != other.ProductCode)
                return false;
            return true;
        }

        public override string ToString()
        {
            return string.Format("Product Code: {0,-10}  Description: {1,-20}  Price: {2,5}  Quantity: {3,4}",
                ProductCode, ProductDescription, ProductPrice, ProductQuantity);
        }

    }
}
