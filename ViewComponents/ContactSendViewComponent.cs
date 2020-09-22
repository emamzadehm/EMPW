using Emamzadeh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emamzadeh.ViewComponents
{
    public class ContactSendViewComponent : ViewComponent
    {
        private readonly DBOperations _dboperations;

        public ContactSendViewComponent(DBOperations dboperations)
        {
            _dboperations = dboperations;
        }
        public IViewComponentResult Invoke(Message? message)
        {
            if (message != null)
            {
                _dboperations.AddMessage(message);
            }
            return View("_ContactSend");
        }
    }
}
