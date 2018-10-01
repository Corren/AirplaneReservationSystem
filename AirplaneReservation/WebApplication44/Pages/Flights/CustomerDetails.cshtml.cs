using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication44.Models;

namespace WebApplication44.Pages.Flights
{
    public class CustomerDetailsModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public CustomerDetailsModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Flight Flight { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flight.FirstOrDefaultAsync(m => m.FlightId == id);

            if (Flight == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
