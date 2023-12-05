using Algoriza2.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.EF
{
    public class Context:IdentityDbContext

    {
        public Context(DbContextOptions<Context>options):base(options)
        {
        }

        DbSet<Patient> Patients { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        DbSet<DiscountCodeCoupon> DiscountCodes { get; set; }
       DbSet<AppointmentTime> appointmentTimes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //builder.Entity<AppointmentTime>().HasKey(n => new
            //{
            //    n.FreeDay,
            //    n.FreeTime

            //});
        }
    }
}
