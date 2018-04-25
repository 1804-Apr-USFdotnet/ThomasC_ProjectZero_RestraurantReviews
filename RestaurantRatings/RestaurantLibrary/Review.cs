using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
