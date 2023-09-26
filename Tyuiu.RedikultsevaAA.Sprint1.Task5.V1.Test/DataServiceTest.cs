using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1, y1, x2, y2;
            x1 = y1 = 0;
            x2 = 3;
            y2 = 4;

            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
