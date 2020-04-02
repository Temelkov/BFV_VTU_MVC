using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTAPP.Data;

namespace TESTAPP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcDoctorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcDoctorContext>>()))
            {
                // Look for any movies.
                if (context.Doctor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Doctor.AddRange(
                    new Doctor
                    {
                        //doctor_id = 5,
                        doctorFirstName = "Desislava",
                        doctorMidName = "Iskrenova",
                        doctorLastName = "Ilieva",
                        internship = 18,
                        speciality = "главен хирург",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
