using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.Controllers
{
    public class FilesController : Controller
    {
        private readonly DBOperations _dboperations;

        public FilesController(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }

        public IActionResult Index(int id)
        {
            var files = _dboperations.FilesList(id);
            return View(files);
        }
    }
}
