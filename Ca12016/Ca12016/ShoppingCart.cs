using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca12016
{
    public enum ShippingMethod                                   // underlying type is int
    {
        Standard, Priority                                // 0, 1, 2
    }

    public class ShoppingCart : IEnumerable
    {
        const double STANDARD_COST = .8;
        const double PRIOITY_COST = 2.0;

        List<CartItem> myList = new List<CartItem>();

        public Collection<CartItem> MyList
        {
            get
            {
                return new Collection<CartItem>(myList);
            }
        }

        public void AddItem(ICartable itemToAdd)
        {
            if(myList == null)
            {
                myList.Add(new CartItem { ProductCode = itemToAdd.ProductCode, ProductDescription = itemToAdd.ProductDescription, ProductPrice = itemToAdd.ProductPrice, ProductQuantity = 1 });
            }
            else
            {
                var search = myList.Where(x => x.ProductCode == itemToAdd.ProductCode).FirstOrDefault();

                if(search == null)
                {
                    myList.Add(new CartItem { ProductCode = itemToAdd.ProductCode, ProductDescription = itemToAdd.ProductDescription, ProductPrice = itemToAdd.ProductPrice, ProductQuantity = 1 });

                }
                else
                {
                    search.ProductQuantity++;
                }
                
            }

        }

        public CartItem this[string productCode]
        {
            get
            {
                var search = myList.Where(x => x.ProductCode == productCode).FirstOrDefault();
                if(search == null)
                {
                    throw new ArgumentException("No result for Product code: " + productCode);

                }
                else
                {
                    return search;

                }

            }
            
        }

        public double CalculateTotal()
        {
            return myList.Sum(x => x.ProductQuantity * x.ProductPrice);
        }

        public double CalculateShippingCost(ShippingMethod method)
        {
            var result = myList.Sum(x => x.ProductQuantity);

            if(method == ShippingMethod.Priority)
            {
                return result * PRIOITY_COST;
            }
            else
            {
                return result * STANDARD_COST;
            }

        }

        public IEnumerator GetEnumerator()
        {
            foreach (CartItem i in myList)
            {
                yield return i;
            }
        }
    }//end of class
}
