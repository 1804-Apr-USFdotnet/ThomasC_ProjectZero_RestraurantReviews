using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RestaurantLibrary
{
    public class Restaurant : IRestaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public Restaurant(string _name, string _address)
        {
            Reviews = new List<Review>();
            Name = _name;
            Address = _address;
        }
        public double AvgReview() 
        {
            double result = Reviews.Sum(item => item.Rating) / Reviews.Count;
            return Math.Round(result, 2);
        }
    }
}
