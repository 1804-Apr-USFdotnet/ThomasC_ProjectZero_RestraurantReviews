using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantBL;

namespace RestaurantTest
{
    [TestClass]
    public class UnitTest1
    {
        RestaurantUtility restaurant = new RestaurantUtility();

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            List<RestaurantUtility> expected = new List<RestaurantUtility>();

            // Act
            //expected.Contains(actual, "Five");

            // Assert
            //CollectionAssert.AreEqual(expected, actual);
        }
    }
}