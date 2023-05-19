using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class AKMmerkezleriController : Controller
    {

        DboAracProjeEntities db = new DboAracProjeEntities();
        // GET: AKMmerkezleri
        
        public ActionResult Index()
        {
            var degerler = db.TBL_AKMMERKEZLERI.ToList();
            return View(degerler);
        }
    }
}