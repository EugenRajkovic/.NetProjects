using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak32.Models
{
    public class Kupac
    {
        public Guid IDKupac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string OIB { get; set; }

        [Display(Name ="Grad")]
        public Guid GradId { get; set; }
        public string PunoIme { get { return Ime + " " + Prezime; } }

        public Kupac()
        {
            IDKupac = Guid.NewGuid();
        }
    }
}