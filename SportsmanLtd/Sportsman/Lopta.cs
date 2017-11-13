using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public class Lopta : Proizvod
    {
        public Lopta(int id, string naziv, float osnovnaCijena, VelicinaEnum velicina) : base(id, naziv, osnovnaCijena)
        {
            this.Velicina = velicina;
        }

        public VelicinaEnum Velicina { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nVelicina lopte:{0}", Velicina);
        }
    }
}
