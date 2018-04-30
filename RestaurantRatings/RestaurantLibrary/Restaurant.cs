using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace RestaurantLibrary
{
    public class Restaurant : IRestaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public static List<Restaurant> restaurants = new List<Restaurant>();
        public Restaurant()
        {
        }
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

        public void SearchRestaurant(string name, string address)
        {
            restaurants.Find((x => x.Name.Equals(name)));
            restaurants.Find((x => x.Address.Equals(address)));
        }
    }
}