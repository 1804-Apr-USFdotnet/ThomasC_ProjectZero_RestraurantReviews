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
    interface IReview
    {
        string Reviewer { get; set; }
        string Comments { get; set; }
        int Rating { get; set; }
        DateTime ReviewDate { get; }
    }
}
