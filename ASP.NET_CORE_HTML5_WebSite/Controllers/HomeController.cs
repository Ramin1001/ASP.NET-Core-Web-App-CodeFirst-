using ASP.NET_CORE_HTML5_WebSite.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_CORE_HTML5_WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }



        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }


        // GuidMaker // Guid formatind shifre yaradir
        //public Guid GiudMaker()
        //{
        //    Guid quid = Guid.NewGuid();

        //    return quid;
        //}
    }
}
