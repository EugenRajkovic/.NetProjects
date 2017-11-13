using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public class Tvrtka
    {
        private List<Kupnja> EvidencijaKupnji = new List<Kupnja>();

        public void AddKupnja(Kupnja k)
        {
            EvidencijaKupnji.Add(k);
        }

        public void Sort()
        {
            EvidencijaKupnji.Sort();
        }

        public List<Kupnja> DohvatiKupnje()
        {
            List<Kupnja> copy = new List<Kupnja>();
            copy.AddRange(EvidencijaKupnji);
            return copy;
        }

        public string MinimalnaKupnja()
        {
            return EvidencijaKupnji.Min(x => x.GetFinalPrice().ToKn());
        }

        public string MaksimalnaKupnja()
        {
            return EvidencijaKupnji.Max(x => x.GetFinalPrice().ToKn());
        }
    }
}
