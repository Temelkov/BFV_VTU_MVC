using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
