using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();   
        public ActionResult ProjectList()
        {
            var values = db.TblProjects.ToList();  
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values = (from x in db.TblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString(),
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]  
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProjects.Add(p);
            db.SaveChanges();
            return RedirectToAction("ProjectList");

        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProjects.Find(id);
            db.TblProjects.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            List<SelectListItem> values1= (from x in db.TblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString(),
                                           }).ToList();
            ViewBag.v = values1;
            
            var value= db.TblProjects.Find(id); 
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value=db.TblProjects.Find(p.ProjectID);
            value.Description = p.Description;  
            value.ImageUrl = p.ImageUrl;    
            value.CategoryID= p.CategoryID;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}