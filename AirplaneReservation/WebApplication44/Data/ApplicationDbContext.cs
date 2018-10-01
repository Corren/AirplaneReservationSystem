using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication44.Models;

namespace WebApplication44.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication44.Models.Flight> Flight { get; set; }
        public DbSet<WebApplication44.Models.Seat> Seat { get; set; }
        public DbSet<WebApplication44.Models.Ticket> Ticket { get; set; }
    }
}
