using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary19
{
    public static class Trigonometry
    {
        public static double Sin(double BC, double AB)
        {
            return BC / AB;
        }

        public static double Cos(double AC, double AB)
        {
            return AC / AB;
        }

        public static double Tg(double BC, double AC)
        {
            return BC / AC;
        }

        public static double Ctg(double BC, double AC)
        {
            return 1 / (BC / AC);
        }

        public static double ArcSin(double BC, double AC)
        {
            return 1 / (BC / AC);
        }
    }
}
