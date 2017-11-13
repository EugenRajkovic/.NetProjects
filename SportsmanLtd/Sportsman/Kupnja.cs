using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public class Kupnja : IDiscount, IComparable<Kupnja>
    {
        private List<Proizvod> Kosarica = new List<Proizvod>();
        private IDiscount discount;
        private float konacnaCijena;

        public void AddProizvod(Proizvod p)
        {
            Kosarica.Add(p);
        }
       
        public void RemoveProizvod(Proizvod p)
        {
            Kosarica.Remove(p);
        }

        public void ZakljuciKupnju(IDiscount _discount, Tvrtka t)
        {
            discount = _discount;
            konacnaCijena = ApplyDiscount(Kosarica);
            t.AddKupnja(this);
        }

        public float ApplyDiscount(List<Proizvod> kosarica)
        {
            return discount.ApplyDiscount(kosarica);
        }

        public float GetFinalPrice()
        {
            return konacnaCijena;
        }

        public override string ToString()
        {
            return string.Format("{0}", konacnaCijena.ToKn());
        }

        public int CompareTo(Kupnja other)
        {
            return -this.konacnaCijena.CompareTo(other.konacnaCijena);
        }
    }
}
