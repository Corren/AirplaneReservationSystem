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
    public class IndexModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Seat> Seat { get;set; }

        public async Task OnGetAsync()
        {
            Seat = await _context.Seat
                .Include(s => s.Flight).ToListAsync();
        }
    }
}
