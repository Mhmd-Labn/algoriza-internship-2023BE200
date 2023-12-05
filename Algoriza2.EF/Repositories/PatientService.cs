using Algoriza2.Core.Interfaces;
using Algoriza2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoriza2.EF.Repositories
{
    public class PatientService
    {
        private readonly IBaseRepository<Patient> _patientRepository;
        private readonly IBaseRepository<Booking> _BookingRepository;
        public PatientService(IBaseRepository<Patient> PatientRepository, IBaseRepository<Booking> BookingRepository)
        {
            _patientRepository = PatientRepository;
            _BookingRepository = BookingRepository;
        }
        public IEnumerable<Booking> GetBookings(int id)
        { 
            var result = _BookingRepository.GetAll(x=>x.PatientId==id);
            return result;
        }



    }
}
