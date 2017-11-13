using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    class Program
    {
        static void Main(string[] args)
        {
            Tvrtka Sportsman = new Tvrtka();

            Reket r1 = new Reket(1, "Tenis", 249.99f, ReketEnum.Teniski, 1.4);
            Reket r2 = new Reket(2, "Badminton", 99.99f, ReketEnum.Badmintonski, 0.3);
            Reket r3 = new Reket(3, "Tenis2", 299.99f, ReketEnum.Teniski, 2.1);
            Lopta l1 = new Lopta(4, "LoptaEuro", 199.99f, VelicinaEnum.mala);
            Lopta l2 = new Lopta(5, "LoptaNike", 399.99f, VelicinaEnum.velika);
            Lopta l3 = new Lopta(6, "LoptaAdidas", 349.99f, VelicinaEnum.velika);


            Kupnja k1 = new Kupnja();
            k1.AddProizvod(r1);
            k1.AddProizvod(r2);
            k1.AddProizvod(l2);
            k1.ZakljuciKupnju(new NajjeftinijiProizvod50Popust(), Sportsman);

            Console.WriteLine(k1);

            Kupnja k2 = new Kupnja();
            k2.AddProizvod(r1);
            k2.AddProizvod(r2);
            k2.AddProizvod(l2);
            k2.AddProizvod(l3);
            k2.ZakljuciKupnju(new _3ProizvodaPopust(), Sportsman);

            Console.WriteLine(k2);

            Kupnja k3 = new Kupnja();
            k3.AddProizvod(r1);
            k3.AddProizvod(r2);
            k3.AddProizvod(l2);
            k3.ZakljuciKupnju(new Cjelokupni20Popust(), Sportsman);

            Console.WriteLine(k3);
            

            Console.WriteLine("--------------");
            Console.WriteLine("Nakon sorta");
            Console.WriteLine("--------------");


            Sportsman.Sort();
            foreach (Kupnja k in Sportsman.DohvatiKupnje())
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();
            Console.WriteLine("Minimalna kupnja:{0}", Sportsman.MinimalnaKupnja());
            Console.WriteLine("Makismalna kupnja:{0}", Sportsman.MaksimalnaKupnja());

        }
    }
}
