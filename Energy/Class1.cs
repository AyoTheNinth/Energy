using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    public class Formula
    {
        public double e_count(double m, double v)
        {
            double e = (m * Math.Pow(v, 2)) / 2;

            return e;
        }

        internal static string e_count(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }

}
