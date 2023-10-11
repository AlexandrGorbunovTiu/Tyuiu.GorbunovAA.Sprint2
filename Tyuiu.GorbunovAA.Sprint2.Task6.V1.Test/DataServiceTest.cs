using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint2.Task6.V1.Lib;

namespace Tyuiu.GorbunovAA.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.FindMonthDaysCount(x);
            Assert.AreEqual(28, res);
        }
    }
}
