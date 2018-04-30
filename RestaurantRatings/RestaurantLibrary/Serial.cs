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
    public partial class Serial
    {
        public Serial()
        {
        }
        public static string GetData(string name, string address)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = name;
            return JsonConvert.SerializeObject(restaurant);
        }
    }
}
