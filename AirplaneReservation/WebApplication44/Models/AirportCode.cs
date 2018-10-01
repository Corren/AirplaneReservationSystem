using System;
using System.Collections.Generic;

namespace WebApplication44.Models
{
    public partial class AirportCode
    {
        public AirportCode()
        {
            FlightAirportArrivalNavigation = new HashSet<Flight>();
            FlightAirportDepartureNavigation = new HashSet<Flight>();
        }

        public int AirportCodeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }

        
        public ICollection<Flight> FlightAirportArrivalNavigation { get; set; }
        public ICollection<Flight> FlightAirportDepartureNavigation { get; set; }
    }
}
