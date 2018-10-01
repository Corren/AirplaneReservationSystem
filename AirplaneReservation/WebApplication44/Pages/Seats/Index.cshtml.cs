using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication44.Models;

namespace WebApplication44.Pages.Seats
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;
        public int result;

        public IndexModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Seat> Seat { get; set; }
        public SelectList FlightId { get; set; }
        public int SeatFlightId { get; set; }

        public async Task OnGetAsync(int seatFlightId)
        {
            Seat = await _context.Seat
                .Include(s => s.Flight).ToListAsync();

            try
            {
                result = Convert.ToInt32(FlightId);
                IQueryable<int> seatFlightIdQuery = from s in _context.Seat
                                                    orderby Convert.ToInt32(s.FlightId)
                                                    select Convert.ToInt32(s.FlightId);

                var seats = from m in _context.Seat
                            select m;


                seats = seats.Where(x => x.FlightId == seatFlightId);

                FlightId = new SelectList(await seatFlightIdQuery.Distinct().ToListAsync());

                Seat = await seats.ToListAsync();
            }
            catch (OverflowException)
            {
                //Console.WriteLine("{0} is outside the range of the Int32 type.", value);
            }


            
        }
    }
}
