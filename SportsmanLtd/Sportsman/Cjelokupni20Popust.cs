using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    class Cjelokupni20Popust : IDiscount
    {
        public float ApplyDiscount(List<Proizvod> kosarica)
        {
            return (float)(kosarica.Sum(x => x.OsnovnaCijena) * 0.8);
        }
    }
}
