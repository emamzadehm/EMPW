using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emamzadeh.ViewComponents
{
    public class TestimonialSendViewComponent:ViewComponent
    {
        private readonly DBOperations _dboperations;
        public TestimonialSendViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke(Testimonial? testimonial)
        {
            if (testimonial!=null)
            { 
            _dboperations.AddTestimonial(testimonial);
            }
            return View("_TestimonialSend");
        }
    }
}
