using Domain.Data;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lastra_julian_lppa_recuperatorio1.Controllers
{
    public class ClassEController : Controller
    {
        BaseDataService<ClassE> db;

        public ClassEController()
        {
            db = new BaseDataService<ClassE>();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var lista = db.Get();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ClassE model)
        {
            if (ModelState.IsValid)
            {
                db.Create(model);
                return RedirectToAction("Index");
            }
                
            return View(model);
        }
    }
}