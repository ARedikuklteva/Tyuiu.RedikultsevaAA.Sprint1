using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint1.Task3.V3.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double length = 9;
            double width = 7.5;
            double height = 5;
            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(337.5, res);
        }
    }
}
