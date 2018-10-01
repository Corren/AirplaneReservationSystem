using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication44.Data;
using WebApplication44.Models;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Collections.Generic;
using System.Data.SqlClient;



namespace WebApplication44.Pages.TakeSeat
{
    public class EditModel : PageModel
    {
        public string FirstName { get; set; }

        public void OnPost(string firstName)
        {
            FirstName = firstName;

            string try2 = $"INSERT INTO Ticket ([Email],[FirstName],[LastName],[DOB],[SeatId]) VALUES ('e96a0cfa-02dd-42d3-8252-a73960909b53','"
                +firstName+"','Smith','12/24/2018 15:43',195149)";

            string FirstName1 = Request.Form["FirstName"];

            string DOB = Request.Form["DOB"];

            SqlConnection con = new SqlConnection("Data Source=gregorylabs.database.windows.net;Initial Catalog=AirplaneData_Copy;Persist Security Info=True;User ID=gregorylabs;Password=JackSparrow2001");

    
            string test = "INSERT INTO Ticket ([Email],[FirstName],[LastName],[DOB],[SeatId]) VALUES ('e96a0cfa-02dd-42d3-8252-a73960909b53','"
                + ")";

            SqlCommand cmd1 = NewMethod(con, try2);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();



        }

        private static SqlCommand NewMethod(SqlConnection con, string test)
        {
            return new SqlCommand(test, con);
        }

        private readonly WebApplication44.Data.ApplicationDbContext _context;

        public EditModel(WebApplication44.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["FlightId"] = new SelectList(_context.Flight, "FlightId", "FlightId");
            return Page();
        }

        
        private bool SeatExists(int id)
        {
            return _context.Seat.Any(e => e.SeatId == id);
        }
    }



}
