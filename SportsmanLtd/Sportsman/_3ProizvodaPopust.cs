using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    class _3ProizvodaPopust : IDiscount
    {
        public float ApplyDiscount(List<Proizvod> kosarica)
        {
            if (kosarica.Count >= 3)
            {
                return kosarica.Sum(x => x.OsnovnaCijena) - kosarica.Min(x => x.OsnovnaCijena);
            }

            return kosarica.Sum(x => x.OsnovnaCijena);
        }
    }
}
