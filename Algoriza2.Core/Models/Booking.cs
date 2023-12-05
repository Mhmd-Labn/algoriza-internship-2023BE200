using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoriza2.Core.Enums;

namespace Algoriza2.Core.Models
{
    public class Booking
    {
        public int Id { get; set; }
        
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient patient { get; set; }
        public BookingStatus Status { get; set; }
        
        public decimal FinalPrice { get; set; }

        public Appointment Appointment { get; set; }

        [ForeignKey ("DiscountCodeCoupon")]
        public string? Coupon { set; get; }
        public DiscountCodeCoupon DiscountCodeCoupon { get; set; }
        


    }
}
