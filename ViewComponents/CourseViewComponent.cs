
using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;

        public CourseViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var courselist = _dboperations.CoursesList();
            return View("_Courses", courselist);
        }
    }
}
