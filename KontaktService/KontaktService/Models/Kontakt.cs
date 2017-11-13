using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace KontaktService.Models
{
    public class Kontakt
    {        
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Telefon> Telefoni { get; set; }
    }
}