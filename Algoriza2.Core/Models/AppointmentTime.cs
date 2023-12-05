using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algoriza2.Core.Enums;

namespace Algoriza2.Core.Models
{
    public class AppointmentTime
    {
        public int Id { get; set; }
        public Days FreeDay { get; set; }
        public string FreeTime { get; set; }
    }
}
