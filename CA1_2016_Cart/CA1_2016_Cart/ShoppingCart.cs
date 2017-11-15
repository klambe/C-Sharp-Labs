/**
 * x00123743
 * Chuong Trung Vuong
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CA1_2016_Cart
{
    public enum ShippingOption
    {
        priority, standard
    }

    public class ShoppingCart : IEnumerable
    {
        List<CartItem> items; // will be initilised in default constructor

        public ShoppingCart()
        {
            items = new List<CartItem>();
        }

        public List<CartItem> Items
        {
            get => items;
        }

        //public Collection<CartItem> Items
        //{
        //    get
        //    {
        //        return new Collection<CartItem>(items);
        //    }
        //}

        public void AddItem(ICartAble item)
        {
            if (items == null)
            {
                items.Add(new CartItem { ProductCode = item.ProductCode, Description = item.Description, Price = item.Price, Quantity = 1 });
            }
            else
            {
                var match = items.FirstOrDefault(i => i.ProductCode == item.ProductCode);
                if (match == null)
                {
                    items.Add(new CartItem { ProductCode = item.ProductCode, Description = item.Description, Price = item.Price, Quantity = 1 });
                }
                else
                {
                    match.Quantity++;
                }
            }
        }

        // read only indexer
        public CartItem this[string productCode]
        {
            get
            {
                var match = items.FirstOrDefault(i => i.ProductCode == productCode);                
                if (match == null) // no found
                {
                    throw new ArgumentException("Product not found, please check product code: " + productCode);
                }
                return match;
            }
        }

        public double CalculateTotal()
        {
            return items.Sum(i => i.Quantity * i.Price);
        }

        public double CalculateShippingCost(ShippingOption shippingOption)
        {
            double shippingCost = 0;
            int qty = items.Sum(i => i.Quantity);
            if (shippingOption == ShippingOption.priority)
            {
                shippingCost = qty * 2; // 2 euro per item for priority
            }
            else // if (shippingOption == ShippingOption.standard) // do not need to handle this as Enum will do so
            {
                shippingCost = qty * 0.8; // 0.80 euro per item for standard
            }
            return shippingCost;
        }

        // not asked, but added in
        public IEnumerator GetEnumerator()
        {
            foreach(CartItem item in items)
            {
                yield return item;
            }
        }        
    }
}
