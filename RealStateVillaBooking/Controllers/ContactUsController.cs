using RealStateVillaBooking.Data;

using RealStateVillaBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;

namespace RealStateVillaBooking.Controllers
{
    public class ContactUsController : Controller
    {
        public Contactcontext s1;
        public ContactUsController(Contactcontext s1)
        {
            this.s1 = s1;
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactUs dash)
        {
            if (ModelState.IsValid)
            {
                s1.ContactTable.Add(dash);
                s1.SaveChanges();
                return RedirectToAction("Contact");
            }
            return View(dash);

        }
    }
}
