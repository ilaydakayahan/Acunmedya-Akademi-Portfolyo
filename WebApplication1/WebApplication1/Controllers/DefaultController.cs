using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        DbDominicPortfolioEntities db =  new DbDominicPortfolioEntities();  
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFeatures.ToList();
            return PartialView(values); //burası dinamik alıyor o yüzden bu şekilde yazılıyor
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbouts.ToList();
        return PartialView(values);
            
        }

        public PartialViewResult ServicePartial()
        {
            var values = db.TblServices.ToList();
            return PartialView(values);

        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonials.ToList();
            return PartialView(values);

        }
        public PartialViewResult ProjectPartial()
        {
            var projects = db.TblProjects.ToList();

            return PartialView(projects);

        }
        public ActionResult Cv()
        {
            return View();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        // 🌟 CV İndirme Metodu
        public ActionResult DownloadCV()
        {
            var filePath = @"C:\Users\user\Downloads\ilaydakayahan_cv.pdf"; // 📂 Dosyanın tam yolu
           
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var fileName = "ilaydakayahan_cv.pdf";
            return File(fileBytes, "application/pdf", fileName); // 📥 İndirme işlemi
        }
         public PartialViewResult ContactPartial()
    {
        return PartialView(new TblContact());
    }

        [HttpPost]
        public ActionResult ContactPartial(TblContact model)
        {
            if (ModelState.IsValid)
            {
                model.SendDate = DateTime.Now;
                model.IsRead = false;

                db.TblContacts.Add(model);
                db.SaveChanges();

                ViewBag.Message = "Mesajınız başarıyla gönderildi.";
                return PartialView(new TblContact()); // Boş form ile tekrar yükle
            }

            ViewBag.Message = "Lütfen tüm alanları eksiksiz doldurun.";
            return PartialView(model);
        }
    }
}