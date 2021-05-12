using ASP.NET_CORE_HTML5_WebSite.Domain;
using ASP.NET_CORE_HTML5_WebSite.Domain.Entities;
using ASP.NET_CORE_HTML5_WebSite.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;

        public TextFieldsController(DataManager dataManager) // access to Db
        {
            this.dataManager = dataManager;
        }

        
        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }


        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }

            return View(model);
        }
    }
}
