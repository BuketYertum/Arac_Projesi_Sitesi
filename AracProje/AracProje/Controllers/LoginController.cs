using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AracProje.Models.Entity;

namespace AracProje.Controllers
{
    public class LoginController : Controller
    {
        DboAracProjeEntities db = new DboAracProjeEntities();

        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(TBL_ADMIN p)
        {
            var bilgiler = db.TBL_ADMIN.FirstOrDefault(x => x.KULLANICI == p.KULLANICI && x.SIFRE == p.SIFRE);
            if (bilgiler != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}