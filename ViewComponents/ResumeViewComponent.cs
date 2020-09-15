using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;


namespace Emamzadeh.ViewComponents
{
    public class ResumeViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;
        public ResumeViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var resumelist = _dboperations.ResumesList();
            return View("_Resume", resumelist);
        }
    }
}
