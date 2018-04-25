using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantLibrary
{
    interface IReview
    {
        string Reviewer { get; set; }
        string Comments { get; set; }
        int Rating { get; set; }
        DateTime ReviewDate { get; }
    }
}
