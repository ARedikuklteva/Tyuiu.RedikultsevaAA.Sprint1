using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string StrTest = "laaay Adc laaay";
            DataService ds = new DataService();
            Boolean res = ds.CheckLastWordRepetiton(StrTest);
            Boolean wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
