using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Zadatak31.Models.CustomValidators;

namespace Zadatak31.Models
{
    public class Kupac
    {

        public Guid IDKupac { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [OIBValidator]
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