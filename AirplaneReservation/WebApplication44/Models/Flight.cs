using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication44.Models
{
    public partial class Flight
    {
        public Flight()
        {
            Seat = new HashSet<Seat>();
        }

        public int FlightId { get; set; }
        [Display(Name = "Capacity First-Class")]
        public int CapacityFirstClass { get; set; }
        [Display(Name = "Capacity Economy")]
        public int CapacityEconomy { get; set; }
        [Display(Name = "Price First-Class")]
        public decimal PriceFirstClass { get; set; }
        [Display(Name = "Price Economy")]
        public decimal PriceEconomy { get; set; }
        [Display(Name = "Time Departure")]
        public DateTime TimeDeparture { get; set; }
        [Display(Name = "Time Arrival")]
        public DateTime TimeArrival { get; set; }
        [Display(Name = "Airport Departure")]
        public string AirportDeparture { get; set; }
        [Display(Name = "Airport Arrival")]
        public string AirportArrival { get; set; }
        [NotMapped]
        public AirportCode AirportArrivalNavigation { get; set; }
        [NotMapped]
        public AirportCode AirportDepartureNavigation { get; set; }
        public ICollection<Seat> Seat { get; set; }
    }
}
