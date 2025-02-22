using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        public ActionResult Index()
        {
            return View();
        }

        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();

        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonials.ToList();

            return View(values);
        }
       
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            db.TblTestimonials.Add(p);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.TblTestimonials.Find(id);
            db.TblTestimonials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
      
    }
}