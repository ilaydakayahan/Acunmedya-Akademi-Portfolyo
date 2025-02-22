using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StatisticController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();  //veritabanının içinde  tabloya ordan sütune ulaşmak için


        public ActionResult Index()
        {
            ViewBag.categorysayisi= db.TblCategories.Count(); //dropdown için yapıyoruz
            ViewBag.projesayisi = db.TblProjects.Count();  

            return View();
        }
    }
}