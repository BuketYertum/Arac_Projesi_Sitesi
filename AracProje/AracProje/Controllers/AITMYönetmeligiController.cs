using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;


namespace AracProje.Controllers
{
    public class AITMYönetmeligiController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: AITMYönetmeligi
       
        public ActionResult Index()
        {
            var degerler = db.TBL_YONETMELIKLER.ToList();
            return View(degerler);
        }
    }
}