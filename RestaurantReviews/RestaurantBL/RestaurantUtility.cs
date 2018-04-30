using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestaurantDL;
namespace RestaurantBL
{
    public static class RestaurantUtility
    {
        public static string SearchRestaurant(string restaurantName)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = DButilities.GetRestaurants().ToList();

            List<Restaurant> restaurants2 = new List<Restaurant>();

            foreach (var restaurant in restaurants)
            {
                if (restaurant.name.Contains(restaurantName))
                {
                    restaurants2.Add(restaurant); 
                }
            }
            return JsonConvert.SerializeObject(restaurants2); //return modified list of restaurants containing restaurantName
        }

        public static List<Restaurant> SortByName()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = DButilities.GetRestaurants().ToList();

            restaurants = restaurants.OrderByDescending(x => x.name).ToList();
            return restaurants;
        }

        public static List<Restaurant> SortByRating()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants = DButilities.GetRestaurants().ToList();

            restaurants = restaurants.OrderByDescending(x => x.AvgRating).ToList();
            return restaurants;
        }
    }
}