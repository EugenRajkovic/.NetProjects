using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KontaktService.Models
{
    public class Telefon
    {
        public int ID { get; set; }
        public string Broj { get; set; }
        public string Tip { get; set; }
        public string Opis { get; set; }
        public int KontaktID { get; set; }

        public virtual Kontakt Kontakt { get; set; }
    }
}