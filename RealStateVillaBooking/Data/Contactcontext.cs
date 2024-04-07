using Microsoft.EntityFrameworkCore;
using RealStateVillaBooking.Models;

namespace RealStateVillaBooking.Data
{
    public class Contactcontext : DbContext
    {
        public Contactcontext(DbContextOptions<Contactcontext> obj)
        : base(obj)

        {

        }

        public DbSet<ContactUs> ContactTable { get; set; }
    }
}

