//Kevin Lambe X00123430 Unit Test Class
using System;
using CA2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CA2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenThen()
        {            
        }

        [TestMethod]
        public void TestMethod3()
        {
            
        }
    }
}
