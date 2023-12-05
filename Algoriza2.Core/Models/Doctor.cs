using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.Core.Models
{
    public class Doctor:Person
    {
        public string Specialization { set; get; }

        public ICollection<Appointment> appointments { set; get; }
        public ICollection<Booking> bookings { set; get; }
        
    }
}
