using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantLibrary
{
    interface IRestaurant
    {
        string Name { get; }
        string Address { get; }
        List<Review> Reviews { get; }
        double AvgReview();
    }
}
