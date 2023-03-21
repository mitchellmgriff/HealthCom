using AutoMapper;
using HealthcareManagementApp.Models;
using HealthcareManagementApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HealthcareManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HealthDbContext _context;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, HealthDbContext context
            , IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Patients
            //.Include(c => c.FirstName).ToArray();
            .ToArray();
            var vms = _mapper.Map<PatientViewModel[]>(result);
            return View(vms);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}