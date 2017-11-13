using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public abstract class Proizvod
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public float OsnovnaCijena { get; set; }

        public Proizvod(int id, string naziv, float osnovnaCijena)
        {
            this.ID = id;
            this.Naziv = naziv;
            this.OsnovnaCijena = osnovnaCijena;
        }

        public override string ToString()
        {
            return string.Format("ID:{0}\nNaziv:{1}\nOsnovna cijena:{2}", ID, Naziv, OsnovnaCijena);
        }
    }
}
