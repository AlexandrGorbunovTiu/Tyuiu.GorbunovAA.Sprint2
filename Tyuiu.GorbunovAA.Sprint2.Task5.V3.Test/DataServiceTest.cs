using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.GorbunovAA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.FindDayName(x);
            Assert.AreEqual(res, "Среда");
        }
    }
}
