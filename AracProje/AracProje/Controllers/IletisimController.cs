using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class IletisimController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();


        // GET: Iletisim
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBL_MESAJ p)
        {
            var mesaj = db.TBL_MESAJ.Find(p.ID);
            mesaj.ADSOYAD = p.ADSOYAD;
            mesaj.MAIL = p.MAIL;
            mesaj.KONU = p.KONU;
            mesaj.MESAJ = p.MESAJ;
            db.TBL_MESAJ.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}