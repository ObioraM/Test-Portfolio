using Microsoft.AspNetCore.Mvc;
using ObioraPortfolio.Data;
using ObioraPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObioraPortfolio.Controllers
{
    public class ContactMeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ContactMeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(ContactPage model)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.ContactPageTbl.Add(model);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
