using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Zadatak32.Models
{
    public class Repo
    {
        private string kupciFile = "kupci.txt";
        private string gradoviFile = "gradovi.txt";

        public Repo()
        {
            kupciFile = HttpContext.Current.Server.MapPath("~") + kupciFile;
            gradoviFile = HttpContext.Current.Server.MapPath("~") + gradoviFile;
        }
        public List<Grad> GetGradovi()
        {
            List<Grad> kolekcija = new List<Grad>();
            if (File.Exists(gradoviFile))
            {
                using (StreamReader r = new StreamReader(gradoviFile))
                {
                    while (!r.EndOfStream)
                    {
                        string[] podaci = r.ReadLine().Split('|');
                        Grad g = new Grad { IDGrad = new Guid(podaci[0]), Naziv = podaci[1] };

                        kolekcija.Add(g);
                    }
                }
            }
            return kolekcija.OrderBy(g => g.Naziv).ToList();
        }
        public Grad GetGradById(Guid id)
        {
            return GetGradovi().SingleOrDefault(g => g.IDGrad == id);
        }
        public Kupac GetKupacById(Guid id)
        {
            return GetKupci().First(o => o.IDKupac == id);
        }

        public List<Kupac> GetKupciByGradId(Guid IDGrad)
        {
            return GetKupci().Where(k => k.GradId == IDGrad).ToList();
        }
        public void AddKupac(Kupac o)
        {
            var kolekcija = GetKupci();
            kolekcija.Add(o);

            SpremiKupce(kolekcija);
        }
        private void SpremiKupce(List<Kupac> kolekcija)
        {
            using (StreamWriter sw = new StreamWriter(kupciFile))
            {
                foreach (var kupac in kolekcija)
                {
                    sw.WriteLine($"{kupac.IDKupac.ToString()}|{kupac.Ime}|{kupac.Prezime}|{kupac.Email}|{kupac.OIB}|{kupac.GradId.ToString()}");
                }
            }
        }
        public Grad AddGrad(Grad g)
        {
            var kolekcija = GetGradovi();
            kolekcija.Add(g);

            SpremiGradove(kolekcija);

            return g;
        }
        private void SpremiGradove(List<Grad> kolekcija)
        {
            using (StreamWriter sw = new StreamWriter(gradoviFile))
            {
                foreach (var grad in kolekcija)
                {
                    sw.WriteLine($"{grad.IDGrad.ToString()}|{grad.Naziv}");
                }
            }
        }
        public List<Kupac> GetKupci()
        {
            List<Kupac> kolekcija = new List<Kupac>();
            if (File.Exists(kupciFile))
            {
                using (StreamReader r = new StreamReader(kupciFile))
                {
                    while (!r.EndOfStream)
                    {
                        string[] podaci = r.ReadLine().Split('|');

                        Kupac o = new Kupac();
                        o.IDKupac = new Guid(podaci[0]);
                        o.Ime = podaci[1];
                        o.Prezime = podaci[2];
                        o.Email = podaci[3];
                        o.OIB = podaci[4];
                        o.GradId = new Guid(podaci[5]);
                        kolekcija.Add(o);
                    }
                }
            }
            return kolekcija;
        }
        public void EditKupac(Kupac editiranKupac)
        {
            var kolekcija = GetKupci();
            var osoba = kolekcija.FirstOrDefault(o => o.IDKupac == editiranKupac.IDKupac);

            osoba.Ime = editiranKupac.Ime;
            osoba.Prezime = editiranKupac.Prezime;
            osoba.Email = editiranKupac.Email;
            osoba.OIB = editiranKupac.OIB;
            osoba.GradId = editiranKupac.GradId;

            SpremiKupce(kolekcija);
        }
        public void DeleteKupac(Guid id)
        {
            var kolekcija = GetKupci();
            var kupac = kolekcija.First(o => o.IDKupac == id);
            kolekcija.Remove(kupac);

            SpremiKupce(kolekcija);
        }

    }
}