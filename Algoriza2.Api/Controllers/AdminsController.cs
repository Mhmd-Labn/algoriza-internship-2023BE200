using Algoriza2.Core.DTOs;
using Algoriza2.Core.Interfaces;
using Algoriza2.Core.Models;
using Algoriza2.EF.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Algoriza2.Api.Controllers
{
   
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IBaseRepository<Doctor> _DoctorRepository;
        private readonly IBaseRepository<Patient> _PatientRepository;
        private readonly IBaseRepository<Booking> _BookingRepository;
        private readonly DoctorService _DoctorService;
        public AdminsController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,
            IBaseRepository<Patient> patientRepository, IBaseRepository<Doctor> DoctorRepository, IBaseRepository<Booking> BookingRepository, DoctorService DoctorService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _PatientRepository = patientRepository;
            _DoctorRepository = DoctorRepository;
            _BookingRepository = BookingRepository;
            _DoctorService = DoctorService;
        }
        [HttpGet]
        [Route("api/[controller]/Dashboard/[action]")]
        public int NumOfDoctors()
        {
            return _DoctorRepository.Count();

        }
        [HttpGet]
        [Route("api/[controller]/Dashboard/[action]")]
        public int NumOfPatients()
        {
            return _PatientRepository.Count();

        }
        [HttpGet]
        [Route("api/[controller]/Dashboard/[action]")]
        public int NumOfBookings()
        {
            return _BookingRepository.Count();

        }
        [HttpGet]
        [Route("api/[controller]/Search/Doctors/[action]")]
        public IActionResult GetAll()
        {
            var result = _DoctorService.GetDoctors();
            return Ok(result);
        }



    }
}
