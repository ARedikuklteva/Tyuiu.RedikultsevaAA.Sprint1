using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double res = (y * y - Math.Cos(x * x) + 10) / (x * x - Math.Sin(y * y) + 12);
            return res;
        }
    }
}
