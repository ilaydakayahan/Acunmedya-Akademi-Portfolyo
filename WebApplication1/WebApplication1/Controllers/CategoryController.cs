using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult CategoryList()
        {
            var values = db.TblCategories.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory p)
        {  
            db.TblCategories.Add(p);
           db.SaveChanges();
            return RedirectToAction("CategoryList") ;  
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategories.Find(id);
            db.TblCategories.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        { 
            var value=db.TblCategories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var value = db.TblCategories.Find(p.CategoryID);
            value.CategoryName = p.CategoryName;    
            db.SaveChanges();
            return RedirectToAction("CategoryList");

         }
            
    }
}