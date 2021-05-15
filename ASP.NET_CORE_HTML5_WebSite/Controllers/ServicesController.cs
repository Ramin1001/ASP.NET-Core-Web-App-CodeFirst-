using ASP.NET_CORE_HTML5_WebSite.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Controllers
{
    public class ServicesController : Controller
    {

        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
         
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TesxtField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");

            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
