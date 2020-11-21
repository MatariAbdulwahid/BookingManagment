using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mnagment.Booking;

namespace Mnagment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CPerson> Persons { get; set; }
        public virtual DbSet<CRoom> Rooms { get; set; }
        public virtual DbSet<CEvent> Events { get; set; }
        public virtual DbSet<CBlock> Blocks { get; set; }
        public virtual DbSet<CBooking> Bookings { get; set; }
        public virtual DbSet<CSchedule> Schedules { get; set; }
        public virtual DbSet<CStudent> Students { get; set; }
        public virtual DbSet<CStudyCubject> StudyCubjects { get; set; }
        public virtual DbSet<CStudy> Studies { get; set; }
        public virtual DbSet<CDate> Dates { get; set; } 
    }
   }
