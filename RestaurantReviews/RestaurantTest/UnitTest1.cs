using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantBL;
using RestaurantDL;

namespace RestaurantTest
{
    [TestClass]
    public class UnitTest1
    {
        Restaurant restaurant = new Restaurant();

        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Tampa, FL";

            //act
            var actual = restaurant.address;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
