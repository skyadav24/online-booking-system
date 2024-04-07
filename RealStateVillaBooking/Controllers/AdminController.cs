using Microsoft.AspNetCore.Mvc;

namespace RealStateVillaBooking.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult AdminProfile()
        {
            return View();
        }
        public IActionResult ContactUsData()
        {
            return View();
        }
    }
}
