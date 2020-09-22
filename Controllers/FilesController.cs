using System.Net.Mime;
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

        [HttpGet]
        public IActionResult Index(int Id)
        {
            //var files = _dboperations.FilesList(Id);
            //return View(files);
            ViewBag.Id = Id;
            return View();
        }
        [HttpPost]
        public FileResult Download(int Id)
        {
            var selectedfile = _dboperations.GetFileBy(Id).ToString();
            var selectedfileByte = System.IO.File.ReadAllBytes("~/assets/Files/" + selectedfile);

            return File(selectedfileByte, MediaTypeNames.Image.Jpeg);
        }
    }
}
