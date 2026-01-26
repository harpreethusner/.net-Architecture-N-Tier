using CRUD.BLL;
using CRUD_N_Tier.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUD_N_Tier.Controllers
{

    // deploy branch Home controller  test
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _service1;
        private readonly IEmailService _service2;

        private readonly IOrderService _service3;
        private readonly IOrderService _service4;

        public HomeController(ILogger<HomeController> logger, IEmailService service1, IEmailService service2,
            IOrderService service3, IOrderService service4)
        {
            _logger = logger;
            _service1 = service1;
            _service2 = service2;

            _service3 = service3;
            _service4 = service4;
        }


        public IActionResult Index()
        {
            ViewBag.Id1 = _service1.GetId();
            ViewBag.Id2 = _service2.GetId();


            ViewBag.Id3 = _service3.GetId();
            ViewBag.Id4 = _service4.GetId();
            return View();
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
