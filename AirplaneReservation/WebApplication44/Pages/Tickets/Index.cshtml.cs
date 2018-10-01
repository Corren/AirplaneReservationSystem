using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication44.Data;
using WebApplication44.Models;

namespace WebApplication44.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get;set; }

        public async Task OnGetAsync()
        {
            Ticket = await _context.Ticket
                .Include(t => t.Seat).ToListAsync();
        }
    }
}
