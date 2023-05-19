using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class AdminLinklerController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: AdminLinkler
      
        public ActionResult Index()
        {
            var degerler = db.TBL_LINKLER.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniLink()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniLink(TBL_LINKLER p)
        {
            db.TBL_LINKLER.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Sil(int id)
        {
            var deger = db.TBL_LINKLER.Find(id);
            db.TBL_LINKLER.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}