using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak32.Models;

namespace Zadatak32.Controllers
{
    public class HomeController : Controller
    {
        Repo repo = new Repo();


        private List<SelectListItem> getDdlItems()
        {
            List<Grad> gradovi = repo.GetGradovi();
            List<SelectListItem> lista = new List<SelectListItem>();

            lista.Add(new SelectListItem
            {
                Text = "---odaberi---"
            });

            foreach (Grad grad in gradovi)
            {
                lista.Add(new SelectListItem
                {
                    Text = grad.Naziv,
                    Value = grad.IDGrad.ToString()
                });
            }

            return lista;
        }


        // GET: Home
        public ActionResult Index(Guid ?gradID)
        {
            if (!gradID.HasValue)
            {
                ViewBag.kupci = new List<Kupac>();
            }
            else
            {
                ViewBag.kupci = repo.GetKupciByGradId(gradID.Value);
            }

            ViewBag.gradovi = getDdlItems();
            return View();
        }
        
        [HttpPost]
        public ActionResult PrikaziDetaljeKupca(Guid KupacID)
        {
            return View(repo.GetKupacById(KupacID));
        }
    }
}