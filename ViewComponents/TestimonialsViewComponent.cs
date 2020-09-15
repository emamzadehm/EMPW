
using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.ViewComponents
{
    public class TestimonialsViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;
        public TestimonialsViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var testimonialslist = _dboperations.TestimonialList();
            return View("_Testimonials", testimonialslist);
        }
    }
}
