using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint2.TaskReview.V15.Lib;

namespace Tyuiu.PoleschukKR.Sprint2.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);

        }
    }
}
