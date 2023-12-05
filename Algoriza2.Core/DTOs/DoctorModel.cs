using Algoriza2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoriza2.Core.Enums;

namespace Algoriza2.Core.DTOs
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOFBirth { get; set; }
        public string Specialization { set; get; }
        public ICollection<Appointment> appointments { set; get; }
        public ICollection<Booking> bookings { set; get; }
    }
}
