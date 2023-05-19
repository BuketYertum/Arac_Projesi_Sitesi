using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class AdminAITMYönetmeligiController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();
        // GET: AdminAITMYönetmeligi
       
        public ActionResult Index()
        {
            var value = db.TBL_YONETMELIKLER.ToList();
            return View(value);
        }


        public ActionResult Sil(int id)
        {
            var yonetmelık = db.TBL_YONETMELIKLER.Find(id);
            db.TBL_YONETMELIKLER.Remove(yonetmelık);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Getir(int id)
        {
            var deger = db.TBL_YONETMELIKLER.Find(id);
            return View("Getir", deger);
        }


        public ActionResult Guncelle(TBL_YONETMELIKLER p)
        {
            var deger = db.TBL_YONETMELIKLER.Find(p.ID);
            deger.YONETMELIKADI = p.YONETMELIKADI;
            deger.ACIKLAMA = p.ACIKLAMA;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }




}