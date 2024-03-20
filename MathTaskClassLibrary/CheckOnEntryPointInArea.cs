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
        //1 - точка входит в закрашенную область справа
        //2 - точка входит в закрашенную область слева

        public byte CheckOnEntry(double x, double y)
        {
            if (x >= 0 && y >= 0 && Math.Pow(x - R, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2))
            {
                return 1;
            }
            if (x <= 0 && y <= 0 && Math.Pow(x + R, 2) + Math.Pow(y + R, 2) >= Math.Pow(R, 2) && Math.Abs(x) <= R && Math.Abs(y) <= R)
            {
                return 2;
            }
            return 0;
        }
    }
}
