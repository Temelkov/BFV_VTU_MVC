using Microsoft.EntityFrameworkCore;
using TESTAPP.Models;

namespace TESTAPP.Data
{
    public class MvcDoctorContext : DbContext
    {
        public MvcDoctorContext(DbContextOptions<MvcDoctorContext> options)
            : base(options) { }

        public DbSet<Doctor> Doctor{ get; set; }
    }
}
