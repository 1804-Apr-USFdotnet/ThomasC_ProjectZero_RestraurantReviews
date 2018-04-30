using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RestaurantClient
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public List<string> names = new List<string> { "One", "Two", "Three", "Four", "Five" };
        public Restaurant()
        {

        }
        public Restaurant(int id)
        {
            this.Id = id;
        }

        public Restaurant(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public double AvgReview()
        {
            double result = Reviews.Sum(item => item.Rating) / Reviews.Count;
            return Math.Round(result, 2);
        }

        public List<Restaurant> Deserialize()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            string json;
            using (StreamReader r = new StreamReader(@"Restaurants.txt"))
            {
                json = r.ReadToEnd();
                restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(json);
            }
            return restaurants;
        }

        public void DisplayAll()
        {
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Average Rating: {AvgReview()}");
        }
        public void SearchRestaraunts()
        {
            
        }
    }

    public class Review
    {
        public string Reviewer { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate => DateTime.Now;

        public Review()
        {
        }

        public Review(string reviewer, string comments, int rating)
        {
            Reviewer = reviewer;
            Comments = comments;
            Rating = rating;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Restaurant NewRestaurant = new Restaurant();
            Review NewReview = new Review();

            //var t = NewRestaurant.Deserialize();

            Console.WriteLine("------------Welcome to Revature Eats!------------");
            Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1. Display top 3 restaurants");
            Console.WriteLine("2. Display all restaurants");
            Console.WriteLine("3. Display a restaurant's details");
            Console.WriteLine("4. Display all reviews of a restaurant");
            Console.WriteLine("5. Search restaurants");
            Console.WriteLine("6. Quit");

            int x = Convert.ToInt32(Console.ReadLine());
            switch(x) 
            {
                case 1:
                    Console.WriteLine("Display top 3 restaurants");
                    break;
                case 2:
                    NewRestaurant.DisplayAll();
                    break;
                case 3:
                    NewRestaurant.DisplayInfo();
                    break;
                case 4:
                    Console.WriteLine("Display all reviews of a restaurant");
                    break;
                case 5:
                    NewRestaurant.SearchRestaraunts();
                    break;
                case 6:
                    Console.WriteLine("Thank you, come again!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}