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
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                RestaurantUtility rest = new RestaurantUtility();
                DButilities db = new DButilities();

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
                        //Display top 3 restaurants based on average rating
                        rest.DisplayTop3();
                        break;
                    case 2:
                        //Display all restaurants
                        foreach (var restaurant in RestaurantUtility.DisplayAllRestaurants())
                            Console.WriteLine(
                                "Restaurant: " + restaurant.name + 
                                " || Address: " + restaurant.address + 
                                " || Email: " + restaurant.email + 
                                " || Phone Number: " + restaurant.phone);
                        break;
                    case 3:
                        //Display info of each restaurant
                        break;
                    case 4:
                        //Display all reviews of a restaurant
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
                logger.Error(e.ToString());
            }
            Console.ReadLine();
        }
    }
}