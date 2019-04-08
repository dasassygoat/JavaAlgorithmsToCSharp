using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class GreatestCommonDenominator
    {
        public static int GetGCD(int p, int q)
        {
            if (q == 0) return p;
            var r = p % q;
            return GetGCD(p, r);
        }
    }
}
