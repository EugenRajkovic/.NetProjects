using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public class Reket : Proizvod
    {
        public Reket(int id, string naziv, float osnovnaCijena, ReketEnum reket, double nategnutostZica) : base(id, naziv, osnovnaCijena)
        {
            this.Reketi = reket;
            this.NategnutostZica = nategnutostZica;
        }

        public ReketEnum Reketi { get; set; }
        public double NategnutostZica { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nReket:{0}\nNategnutost zica:{1}", Reketi, NategnutostZica.ToKg());
        }
    }
}
