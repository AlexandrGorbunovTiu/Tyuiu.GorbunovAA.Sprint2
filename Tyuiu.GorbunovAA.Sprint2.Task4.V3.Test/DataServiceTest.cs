using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.GorbunovAA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int y = 1;
            int x = -1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 1);
        }
    }
}
