using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();

        public ActionResult ContactList()
        {
            var values = db.TblContacts.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.TblContacts.Find(id);
            db.TblContacts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}