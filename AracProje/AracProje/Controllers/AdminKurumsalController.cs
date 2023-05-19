using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class AdminKurumsalController : Controller
    {

        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: AdminKurumsal
     
        public ActionResult Index()
        {
            var degerler = db.TBL_BANKABILGI.ToList();
            return View(degerler);
        }


        [HttpGet]
        public ActionResult YeniBanka()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBanka(TBL_BANKABILGI p)
        {
            db.TBL_BANKABILGI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Sil(int id)
        {
            var deger = db.TBL_BANKABILGI.Find(id);
            db.TBL_BANKABILGI.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}