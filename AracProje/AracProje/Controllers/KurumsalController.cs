using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class KurumsalController : Controller
    {

        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: Kurumsal
       
        public ActionResult Index()
        {
            var deger = db.TBL_BANKABILGI.ToList();
            return View(deger);
        }
    }
}