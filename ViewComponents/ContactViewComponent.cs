using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;

        public ContactViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var selectedprofessor = _dboperations.GetProfessor();
            return View("_Contact", selectedprofessor);
        }
    }
}
