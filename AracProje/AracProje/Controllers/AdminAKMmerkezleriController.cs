using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class AdminAKMmerkezleriController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: AdminAKMmerkezleri
 
        public ActionResult Index()
        {
            var degerler = db.TBL_AKMMERKEZLERI.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniMerkez()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniMerkez(TBL_AKMMERKEZLERI p)
        {
            db.TBL_AKMMERKEZLERI.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var merkez = db.TBL_AKMMERKEZLERI.Find(id);
            db.TBL_AKMMERKEZLERI.Remove(merkez);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

        public ActionResult Getir(int id)
        {
            var deger = db.TBL_AKMMERKEZLERI.Find(id);
            return View("Getir", deger);
        }


        public ActionResult Guncelle(TBL_AKMMERKEZLERI p)
        {
            var deger = db.TBL_AKMMERKEZLERI.Find(p.ID);
            deger.IL = p.IL;
            deger.ISLETME = p.ISLETME;
            deger.TELEFON = p.TELEFON;
            deger.ADRES = p.ADRES;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}