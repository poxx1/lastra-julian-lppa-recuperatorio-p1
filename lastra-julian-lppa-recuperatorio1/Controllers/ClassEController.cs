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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.GetById(id);
            return View(model);
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

        [HttpPost]
        public ActionResult Edit(ClassE model)
        {
            if (ModelState.IsValid)
            {
                db.Update(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(ClassE model)
        {
            if (ModelState.IsValid)
            {
                db.Delete(model.Id);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
