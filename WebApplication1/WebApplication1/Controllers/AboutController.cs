using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {

        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();

        public ActionResult AboutList()
        {
            var values = db.TblAbouts.ToList();

            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(TblAbout p)
        {
            var value = db.TblAbouts.Find(p.AboutID);
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("AboutList");

        }
    }
}