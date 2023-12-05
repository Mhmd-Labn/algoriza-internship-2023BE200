using Algoriza2.Core.Interfaces;
using Algoriza2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.EF.Repositories
{
    public class DoctorService
    {
        private readonly IBaseRepository<Doctor> _DoctorRepository;
        public DoctorService(IBaseRepository<Doctor> DoctorRepository)
        {
            _DoctorRepository = DoctorRepository;
        }
        public IEnumerable<Doctor> GetDoctors ()
        {
            return _DoctorRepository.GetAll(x=>x.bookings,x=>x.appointments);
        }
    }
}
