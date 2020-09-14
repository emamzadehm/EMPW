
using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.ViewComponents
{
    public class HistoriesViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;
        public HistoriesViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke()
        {
            var historylist = _dboperations.HistoryList();
            return View("_Testimonials", historylist);
        }
    }
}
