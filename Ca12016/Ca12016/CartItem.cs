using System;
using System.Collections.Generic;


namespace Ca12016
{
    public class CartItem :ICartable
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

        public override bool Equals(object obj)
        {
            var item = obj as CartItem;
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


        public override string ToString()
        {
            return string.Format("Product Code: {0,-10}  Description: {1,-20}  Price: {2,5}  Quantity: {3,4}",
                ProductCode, ProductDescription, ProductPrice, ProductQuantity);
        }

    }
}
