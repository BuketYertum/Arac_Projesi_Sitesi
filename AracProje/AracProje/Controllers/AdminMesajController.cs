using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;


namespace AracProje.Controllers
{
    public class AdminMesajController : Controller
    {

        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: AdminMesaj
        public ActionResult Index()
        {
            var mesajlar = db.TBL_MESAJ.ToList();
            return View(mesajlar);
        }


        [HttpGet]
       public ActionResult YeniMesaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMesaj(TBL_MESAJ p)
        {
            var mesaj = (string)Session["ADSOYAD"].ToString();
            mesaj.
            return View();
        }

    }
}