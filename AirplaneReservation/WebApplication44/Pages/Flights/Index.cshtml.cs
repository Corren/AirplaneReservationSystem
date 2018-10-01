using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication44.Models;

namespace WebApplication44.Pages.Flights
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Flight> Flight { get; set; }
        public SelectList AirportDeparture { get; set; }
        public string FlightAirportDeparture { get; set; }
        public SelectList AirportArrival { get; set; }
        public string FlightAirportArrival { get; set; }

        public async Task OnGetAsync(string flightAirportArrival, string flightAirportDeparture)
        {
            Flight = await _context.Flight.ToListAsync();

            IQueryable<string> airportDepartureQuery = from f in _context.Flight
                                                       orderby f.AirportDeparture
                                                       select f.AirportDeparture;

            IQueryable<string> airportArrivalQuery = from f in _context.Flight
                                                     orderby f.AirportArrival
                                                     select f.AirportArrival;

            var flights = from m in _context.Flight
                          select m;

            if (!String.IsNullOrEmpty(flightAirportDeparture))
            {
                flights = flights.Where(x => x.AirportDeparture == flightAirportDeparture);
            }
            AirportDeparture = new SelectList(await airportDepartureQuery.Distinct().ToListAsync());

            if (!String.IsNullOrEmpty(flightAirportArrival))
            {
                flights = flights.Where(x => x.AirportArrival == flightAirportArrival);
            }
            AirportArrival = new SelectList(await airportArrivalQuery.Distinct().ToListAsync());

            Flight = await flights.ToListAsync();
        }
    }
}