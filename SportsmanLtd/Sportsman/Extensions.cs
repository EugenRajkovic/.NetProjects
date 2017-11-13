using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsman
{
    public static class Extensions
    {
        public static string ToKg(this double a)
        {
            return string.Format("{0}kg", a);
        }

        public static string ToKn(this float a)
        {
            return string.Format("{0}kn", a);
        }
    }
}
