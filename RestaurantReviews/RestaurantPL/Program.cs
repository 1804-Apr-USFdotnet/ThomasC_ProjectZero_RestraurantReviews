using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using RestaurantBL;
using RestaurantDL;

namespace RestaurantReviews
{
    public class Functions
    {
        public static List<Restaurant> restaurants = new List<Restaurant>();
        public static void DisplayAllRestaurantNames()
        {
            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine(r.name);
            }
        }

        public static void DisplayRestaurantsAndInfo()
        {
            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine("Name: " + r.name + " Street Address: " + r.address + " Phone Number: " + r.phone + " Email: " + r.email);
            }
        }

        public static void DisplayReviews(Restaurant restaurant)
        {
            foreach (Review r in restaurant.Reviews)
            {
                Console.WriteLine("Rating: " + r.rating + " Comments: " + r.comments);
            }
        }

        public static List<Restaurant> SortAscending(List<Restaurant> restaurants)
        {
            return restaurants.OrderBy(r => r.name).ToList();
        }

        public static List<Restaurant> SortDescending(List<Restaurant> restaurants)
        {
            return restaurants.OrderByDescending(r => r.name).ToList();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Restaurant NewRestaurant = new Restaurant();
                Review NewReview = new Review();

                Console.WriteLine("------------Welcome to Revature Eats!------------");
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("1. Display top 3 restaurants");
                Console.WriteLine("2. Display all restaurants");
                Console.WriteLine("3. Display a restaurant's details");
                Console.WriteLine("4. Display all reviews of a restaurant");
                Console.WriteLine("5. Search restaurants");
                Console.WriteLine("6. Sort Restaurants by name");
                Console.WriteLine("7. Sort Restaurants by rating");
                Console.WriteLine("8. Quit Application");

                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Display top 3 restaurants");
                        break;
                    case 2:
                        //NewRestaurant.DisplayAll();
                        break;
                    case 3:
                        //NewRestaurant.DisplayInfo();
                        break;
                    case 4:
                        Console.WriteLine("Display all reviews of a restaurant");
                        break;
                    case 5:
                        Console.WriteLine("Search Restaurant Name: ");
                        string query = Console.ReadLine();
                        List<Restaurant> restaurantName = JsonConvert.DeserializeObject<List<Restaurant>>(RestaurantUtility.SearchRestaurant(query));
                        foreach (var restaurant in restaurantName)
                            Console.WriteLine(restaurant.name);
                        break;
                    case 6:
                        foreach (var restaurant in RestaurantUtility.SortByName())
                            Console.WriteLine(restaurant.name);
                        break;
                    case 7:
                        foreach (var restaurant in RestaurantUtility.SortByRating())
                            Console.WriteLine(restaurant.name + "Average Rating: " + restaurant.AvgRating);
                        break;
                    case 8:
                        Console.WriteLine("Thank you and come again!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } catch(Exception e)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.ErrorException("Error!", e);
            }
            Console.ReadLine();
        }
    }
}