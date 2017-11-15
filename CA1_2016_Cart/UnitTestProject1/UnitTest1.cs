/**
 * x00123743
 * Chuong Trung Vuong
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA1_2016_Cart;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestValidation1()
        {
            CartItem item1 = new CartItem { ProductCode = "      ", Description = "Samsung LED TV", Price = 400 };
        }

        // Test ProductCode validation: cannot less than 5 characters in length
        // will cause validation to execute when adding to shopping cart
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestValidation2()
        {
            CartItem item1 = new CartItem { ProductCode = "1234", Description = "Samsung LED TV", Price = 400 };
        }

        [TestMethod]
        public void TestReadProperty()
        {
            ElectricalItem c1 = new ElectricalItem { ProductCode = "123456", Description = "samsung tv", Price = 200, IsWEEE = true };

            Assert.AreEqual(c1.ProductCode, "123456");
            Assert.AreEqual(c1.Description, "samsung tv");
            Assert.AreEqual(c1.Price, 200);
            Assert.AreEqual(c1.IsWEEE, true);
        }

        [TestMethod]
        public void TestAdd()
        {
            ElectricalItem item1 = new ElectricalItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400, IsWEEE = true };
            ElectricalItem item2 = new ElectricalItem { ProductCode = "hp360", Description = "HP Spectre 360", Price = 1500, IsWEEE = true };
            ElectricalItem item3 = new ElectricalItem { ProductCode = "a2300", Description = "MacBook Pro Base", Price = 2300, IsWEEE = true };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1);            
            cart.AddItem(item2);
            cart.AddItem(item2);
            cart.AddItem(item3);
            cart.AddItem(item3);
            cart.AddItem(item3);

            int index = 0;
            Assert.AreEqual(cart.Items[index++].Quantity, 1);
            Assert.AreEqual(cart.Items[index++].Quantity, 2);
            Assert.AreEqual(cart.Items[index++].Quantity, 3);
        }

        [TestMethod]
        public void TestCalculateTotal()
        {
            ElectricalItem item1 = new ElectricalItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400, IsWEEE = true };
            ElectricalItem item2 = new ElectricalItem { ProductCode = "hp360", Description = "HP Spectre 360", Price = 1500, IsWEEE = true };
            ElectricalItem item3 = new ElectricalItem { ProductCode = "a2300", Description = "MacBook Pro Base", Price = 2300, IsWEEE = true };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1); // 400
            cart.AddItem(item2); // 1500
            cart.AddItem(item2); // 1500
            cart.AddItem(item3); // 2300
            cart.AddItem(item3); // 2300
            cart.AddItem(item3); // 2300

            Assert.AreEqual(cart.CalculateTotal(), 10300);
        }

        [TestMethod]
        public void TestCalculateShippingCost()
        {
            ElectricalItem item1 = new ElectricalItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400, IsWEEE = true };
            ElectricalItem item2 = new ElectricalItem { ProductCode = "hp360", Description = "HP Spectre 360", Price = 1500, IsWEEE = true };
            ElectricalItem item3 = new ElectricalItem { ProductCode = "a2300", Description = "MacBook Pro Base", Price = 2300, IsWEEE = true };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1); 
            cart.AddItem(item2); 
            cart.AddItem(item2); 
            cart.AddItem(item3); 
            cart.AddItem(item3);
            cart.AddItem(item3);

            Assert.AreEqual(cart.CalculateShippingCost(ShippingOption.priority), (6 * 2));
            Assert.AreEqual(cart.CalculateShippingCost(ShippingOption.standard), (6 * 0.8));
        }

        [TestMethod]
        public void TestMethod7()
        {
            CartItem item1 = new CartItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400 };
            CartItem item2 = new CartItem { ProductCode = "hp360", Description = "HP Spectre 360", Price = 1500 };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1);
            cart.AddItem(item2);

            CollectionAssert.Contains(cart.Items, item1);
            CollectionAssert.Contains(cart.Items, item2);
        }

        [TestMethod]
        public void TestIndexer()
        {
            CartItem item1 = new CartItem { ProductCode = "ss101", Description = "Samsung LED TV", Price = 400};

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(item1);

            Assert.AreEqual(cart[item1.ProductCode], item1);
        }
    }
}
