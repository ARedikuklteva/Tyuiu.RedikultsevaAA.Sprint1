using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint1.Task1.V1.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 2.0;
            double a = 1.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(7, res);
        }
    }
}
