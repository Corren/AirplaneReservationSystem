using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication44.Data;
using WebApplication44.Models;

namespace WebApplication44.Pages.TakeSeat
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Seat Seat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seat = await _context.Seat
                .Include(s => s.Flight).FirstOrDefaultAsync(m => m.SeatId == id);

            if (Seat == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
