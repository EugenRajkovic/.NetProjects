using KontaktService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KontaktService.DAL
{
    public class ImenikInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ImenikContext>
    {
        protected override void Seed(ImenikContext context)
        {
            var brojevi = new List<Telefon>
            {
                new Telefon{ Broj = "091777333",Opis="Ne zvati prije 5",Tip="Mobitel", KontaktID=1},
                new Telefon{ Broj = "091583849",Opis="Uvijek dostupan",Tip="Mobitel", KontaktID=2},
                new Telefon{ Broj = "014839344",Opis="",Tip="Posao", KontaktID=1},
                new Telefon{ Broj = "015948393",Opis="",Tip="Posao", KontaktID=2}
            };

            brojevi.ForEach(b => context.Telefoni.Add(b));
            context.SaveChanges();

            var kontakti = new List<Kontakt>
            {
                new Kontakt{ Ime = "Pero", Prezime = "Peric", Opis="Prijatelj", Grad = "Zagreb", ID = 1, Slika = null},
                new Kontakt{ Ime = "Marko", Prezime = "Maric", Opis="Kolega", Grad = "Split", ID = 2, Slika = null},
            };

            kontakti.ForEach(k => context.Kontakti.Add(k));
            context.SaveChanges();
        }
    }
}