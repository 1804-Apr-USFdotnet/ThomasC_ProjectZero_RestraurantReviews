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
    public class Review : IReview
    {
        public string Reviewer { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate => DateTime.Now;
        public Review()
        {
        }

    }
}