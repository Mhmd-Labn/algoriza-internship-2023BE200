using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.Core
{
    public class Enums
    {
       public enum Gender
        {
            Female,
            Male
        }
        public enum DiscountType
        {
            Percentage,
            Value
        }
        public enum Days
        {
            Saturday,
            Sunday,
            Monday,
            Tuseday,
            Wednesday,
            thursday,
            Friday
        }
        public enum BookingStatus
        {
            Pending,
            Completed,
            Canceled
        }

    }
}
