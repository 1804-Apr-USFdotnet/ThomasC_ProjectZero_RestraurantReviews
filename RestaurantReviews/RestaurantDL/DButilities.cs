using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDL
{
    public static class DButilities
    {
        public static List<Restaurant> GetRestaurants()
        {
            RestaurantsDbEntities dbutilities = new RestaurantsDbEntities();
            List<Restaurant> restaurantList = dbutilities.Restaurants.ToList();
            foreach (var restaurant in restaurantList)
            {
                double total = 0;
                int number = 0;
                foreach (var review in restaurant.Reviews)
                {
                    total += (double)review.rating;
                    number++;
                }
                restaurant.AvgRating = total / number;
            }
            return restaurantList;
        }

        public static List<Review> GetAllReviews(int RestaurantId)
        {
            RestaurantsDbEntities dbutilities = new RestaurantsDbEntities();
            Restaurant restaurant = dbutilities.Restaurants.SingleOrDefault(x => x.id == RestaurantId);
            return restaurant.Reviews.ToList();
        }

        public static int GetRestaurantId(string RestaurantName)
        {
            RestaurantsDbEntities dbutilities = new RestaurantsDbEntities();
            Restaurant restaurant = dbutilities.Restaurants.SingleOrDefault(x => x.name == RestaurantName);
            return restaurant.id;
        }
    }
}
