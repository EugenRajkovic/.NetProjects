using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public interface IDiscount
    {
        float ApplyDiscount(List<Proizvod> kosarica);
    }
}
