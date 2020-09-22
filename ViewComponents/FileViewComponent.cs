using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emamzadeh.ViewComponents
{
    public class FileViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;

        public FileViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke(int Id)
        {
            var fileslist = _dboperations.FilesList(Id);
            return View("_File",fileslist);
        }
    }
}
