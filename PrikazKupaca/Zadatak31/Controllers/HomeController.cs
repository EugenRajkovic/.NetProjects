using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak31.Models;

namespace Zadatak31.Controllers
{
    public class HomeController : Controller
    {
        Repo repo = new Repo();


        private List<SelectListItem> GetSliGradovi()
        {
            List<Grad> gradovi = repo.GetGradovi();
            List<SelectListItem> sliGradovi = new List<SelectListItem>();
            foreach (var grad in gradovi)
            {
                sliGradovi.Add(new SelectListItem
                {
                    Text = grad.Naziv,
                    Value = grad.IDGrad.ToString()
                });
            }

            return sliGradovi;
        }


        [HttpGet]
        public ActionResult Index(Guid ?gradID)
        {
            if (!gradID.HasValue)
            {
                gradID = repo.GetGradovi()[0].IDGrad;
            }

            ViewBag.gradovi = GetSliGradovi();
            ViewBag.kupci = repo.GetKupciByGradId(gradID.Value);

            return View();
        }


        [HttpPost]
        public ActionResult Index(string gradID)
        {
            return RedirectToAction(actionName: "Index", controllerName: "Home", routeValues: new { gradID = new Guid(gradID)});
        }


        [ChildActionOnly]
        public ActionResult _Kupac(Kupac model)
        {
            return PartialView(model);
        }


        [HttpGet]
        public ActionResult Edit(Guid idKupac)
        {
            ViewBag.gradovi = GetSliGradovi();
            return View(repo.GetKupacById(idKupac));
        }


        [HttpPost]
        public ActionResult Edit(Kupac model)
        {
            if (ModelState.IsValid)
            {
                repo.EditKupac(model);
                TempData["ImeKupca"] = model.PunoIme;
                return View("Potvrda");
            }

            ViewBag.gradovi = GetSliGradovi();
            return View(model);
        }

        [HttpGet]
        public ActionResult Potvrda()
        {
            return View();
        }
    }
}