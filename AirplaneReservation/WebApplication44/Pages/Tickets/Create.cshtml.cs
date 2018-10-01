using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication44.Data;
using WebApplication44.Models;

namespace WebApplication44.Pages.Tickets
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public CreateModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SeatId"] = new SelectList(_context.Seat, "SeatId", "SeatId");
            return Page();
        }

        [BindProperty]
        public Ticket Ticket { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ticket.Add(Ticket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}