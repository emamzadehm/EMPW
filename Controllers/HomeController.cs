using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;


namespace Emamzadeh.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBOperations _dboperations;

        public HomeController(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
                return View();
            }
            ViewBag.nt = message;
            //_dboperations.AddMessage(message);
            ViewBag.success = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
            ModelState.Clear();
            return View();
        }

    }
}
