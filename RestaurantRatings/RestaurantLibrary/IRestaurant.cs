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
    interface IRestaurant
    {
        string Name { get; }
        string Address { get; }
        List<Review> Reviews { get; }
        double AvgReview();
        void SearchRestaurant(string name, string address);
    }
}
