using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantLibrary;
namespace RestaurantTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            //Arrange
            Restaurant restaurant1 = new Restaurant("Five Guys", "2702 E Fowler Ave, Tampa, FL 33612");
            Restaurant restaurant2 = new Restaurant("Wendys", "13712 Bruce B Downs Blvd, Tampa, FL 33613");
            Restaurant restaurant3 = new Restaurant("Mission BBQ", "13612 Bruce B Downs Blvd, Tampa, FL 33613");
            Restaurant restaurant4 = new Restaurant("Arbys", "2230 E Fletcher Ave, Tampa, FL 33612");
            Restaurant restaurant5 = new Restaurant("Subway", "2602 E Fletcher Ave, Tampa, FL 33612");

            Review review = new Review();

            //Act

            //Assert
        }
    }
}
