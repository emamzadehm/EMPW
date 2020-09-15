using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emamzadeh.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;

        public MenuViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var selectedprofessor = _dboperations.GetProfessor();
            return View("_Menu", selectedprofessor);
        }
    }
}
