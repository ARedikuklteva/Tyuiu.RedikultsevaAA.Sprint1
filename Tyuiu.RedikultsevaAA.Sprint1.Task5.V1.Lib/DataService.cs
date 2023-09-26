using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double x = Math.Pow(Math.Abs(x1 - x2), 2);
            double y = Math.Pow(Math.Abs(y1 - y2), 2);
            int res = Convert.ToInt32(Math.Sqrt(x + y));
            return res;
        }
    }
}
