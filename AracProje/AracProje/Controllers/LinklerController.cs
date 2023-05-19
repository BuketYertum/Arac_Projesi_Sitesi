using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class LinklerController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: Linkler
      
        public ActionResult Index()
        {
            var degerler = db.TBL_LINKLER.ToList();
            return View(degerler);
        }
    }
}