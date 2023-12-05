using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoriza2.Core.Enums;

namespace Algoriza2.Core.Models
{
    public class DiscountCodeCoupon
    {
        [Key]
        public string code { set; get; }

        public bool IsActive { set; get; }
        public int NumOfCompletedBookings { set; get; }
        public DiscountType discountType { set; get; }

        public int Value;

        public Booking Booking { set; get; }
    }
}
