using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ca12016;

namespace Ca12016Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };
            ShoppingCart s1 = new ShoppingCart();
            s1.AddItem(c1);
           // CollectionAssert.Contains(s1.myList, c1);
           CollectionAssert.Contains(s1.MyList, c1);
            Assert.AreEqual(s1.MyList[0].ProductCode, c1.ProductCode);
            Assert.AreEqual(c1.ProductCode, s1["CodeKevin"].ProductCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "Co", ProductDescription = "Laptop", ProductPrice = 3 };
            ShoppingCart s1 = new ShoppingCart();
            s1.AddItem(c1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod3()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3};
            ShoppingCart s1 = new ShoppingCart();
            CartItem findCartItem = s1["Kevin"];
        }


        [TestMethod]
        public void TestMethod4()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };
            ShoppingCart s1 = new ShoppingCart();
            s1.AddItem(c1);
            s1.AddItem(c1);
            s1.AddItem(c1);
            Assert.AreEqual(s1.CalculateTotal(), c1.ProductPrice * 3);
        }

        [TestMethod]
        public void TestMethod5()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c2 = new ElectricalItem { ProductCode = "CodeJohn", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c3 = new ElectricalItem { ProductCode = "CodeMary", ProductDescription = "Laptop", ProductPrice = 3 };
            ShoppingCart s1 = new ShoppingCart();
            s1.AddItem(c1);
            s1.AddItem(c2);
            s1.AddItem(c3);
            Assert.AreEqual(s1.CalculateShippingCost(ShippingMethod.Priority), 2.0 * 3);
        }

        [TestMethod]
        public void TestMethod6()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "CodeKevin", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c2 = new ElectricalItem { ProductCode = "CodeJohn", ProductDescription = "Laptop", ProductPrice = 3 };
            ElectricalItem c3 = new ElectricalItem { ProductCode = "CodeMary", ProductDescription = "Laptop", ProductPrice = 3 };
            ShoppingCart s1 = new ShoppingCart();
            s1.AddItem(c1);
            s1.AddItem(c2);
            s1.AddItem(c3);
            Assert.AreEqual(s1.CalculateShippingCost(ShippingMethod.Standard), 0.8 * 3);
        }

        [TestMethod]
        public void TestMethod7()
        {
            CartItem item1 = new CartItem { ProductCode = "ss101", ProductDescription = "Samsung LED TV", ProductPrice = 400 };
            CartItem item2 = new CartItem { ProductCode = "hp360", ProductDescription = "HP Spectre 360", ProductPrice = 1500 };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1);
            cart.AddItem(item2);

            CollectionAssert.Contains(cart.MyList, item1);
            CollectionAssert.Contains(cart.MyList, item2);
        }


    }
}