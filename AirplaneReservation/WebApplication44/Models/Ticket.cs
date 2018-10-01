using System;
using System.Collections.Generic;

namespace WebApplication44.Models
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int? SeatId { get; set; }

        public Seat Seat { get; set; }
    }
}
