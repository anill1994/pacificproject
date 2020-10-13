using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Country { get; set; }
        public string Place { get; set; }
        public int Tour { get; set; }
        public string CountryImage { get; set; }
        public string PlaceImage { get; set; }
        public int Price { get; set; }
        public int TourDayCount { get; set; }

    }
}
