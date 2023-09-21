using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint1.Task2.V13.Lib;

// Написать программу, которая запрашивает у пользователя исходные данные,
// выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Известно расстояние в милях. Вычислить расстояние в километрах.
//Что пользователь вводит? Расстояние в милях (целое число)
//Что программа печатает на экране? Расстояние в километрах (вещественное число)

namespace Tyuiu.RedikultsevaAA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 100;
            var res = ds.ConvertMilesToKm(a);
            Assert.AreEqual(161, res);
        }
    }
}
