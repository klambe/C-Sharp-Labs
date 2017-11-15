using System;


namespace Ca12016
{
    class Program
    {
        static void Main()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c2 = new ElectricalItem { ProductCode = "CodeJohn", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c3 = new ElectricalItem { ProductCode = "CodeMary", ProductDescription = "Laptop", ProductPrice = 3 };

            CartItem c4 = new CartItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };

            CartItem c5 = new CartItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };

            ShoppingCart s1 = new ShoppingCart();

            s1.AddItem(c1);
            Console.WriteLine(s1.CalculateTotal());
            s1.AddItem(c2);
            Console.WriteLine(s1.CalculateTotal());
            s1.AddItem(c1);
            Console.WriteLine(s1.CalculateTotal());

            Console.WriteLine(s1.CalculateShippingCost(ShippingMethod.Priority));
            Console.WriteLine(s1["CodeKevin"].ProductCode);

            if (c4.Equals(c5))
            {
                Console.WriteLine("True they are equal");
            }

        }
    }
}
