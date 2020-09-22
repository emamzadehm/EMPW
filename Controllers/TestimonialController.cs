using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.Controllers
{
    public class TestimonialController : Controller
    {

        
        //[BindProperty]public Testimonial testimonial { get; set; }
        private readonly DBOperations _dboperations;

        public TestimonialController(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
                return View();
            }
            ViewBag.nt = testimonial;
            //_dboperations.AddTestimonial(testimonial);
            ViewBag.success = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
            ModelState.Clear();
            return View();
    // return RedirectToPage("")
}
    }
}
