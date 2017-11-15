/**
 * x00123743
 * Chuong Trung Vuong
 */

using System;

namespace CA1_2016_Cart
{
    class Program
    {
        static void Main()
        {
            // skeleton ready for tesing Main
            try
            {
                ElectricalItem item1 = new ElectricalItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400, IsWEEE = true };
                ElectricalItem item2 = new ElectricalItem { ProductCode = "hp360", Description = "HP Spectre 360", Price = 1500, IsWEEE = true };
                ElectricalItem item3 = new ElectricalItem { ProductCode = "a2300", Description = "MacBook Pro Base", Price = 2300, IsWEEE = true };

                ShoppingCart shoppingCart = new ShoppingCart();

                shoppingCart.AddItem(item1); //  400
                shoppingCart.AddItem(item2); // 1500
                shoppingCart.AddItem(item2); // 1500
                shoppingCart.AddItem(item3); // 2300

                Console.WriteLine("Shopping cart details:");
                Console.WriteLine("======================");
                foreach(CartItem item in shoppingCart)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("======================");
                Console.WriteLine("Total price  : " + shoppingCart.CalculateTotal());
                Console.WriteLine("Shipping cost: " + shoppingCart.CalculateShippingCost(ShippingOption.priority));

                CartItem cartItem = shoppingCart["hp360"];
                Console.WriteLine(cartItem);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
