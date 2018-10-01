using System;
using System.Collections.Generic;

namespace WebApplication44.Models
{
    public partial class Seat
    {
        public Seat()
        {
            Ticket = new HashSet<Ticket>();
        }

        public int SeatId { get; set; }
        public bool Available { get; set; }
        public bool FirstClass { get; set; }
        public int RowNumber { get; set; }
        public int ColNumber { get; set; }
        public int? FlightId { get; set; }

        public Flight Flight { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
