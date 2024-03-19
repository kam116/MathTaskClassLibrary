using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class CheckOnEntryPointInArea
    {
        public CheckOnEntryPointInArea(double r)
        {
            R = r;
        }

        public double R { get; set; }

        //Варианты результатов:
        //0 - точка не входит в закрашенную область
        //1 - точка входит в закрашенную область

        public byte CheckOnEntry(double x, double y)
        {
            if (x >= 0 && y >= 0 && Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2) || x <= 0 && Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
            {
                return 1;
            }
            return 0;
        }
    }
}
