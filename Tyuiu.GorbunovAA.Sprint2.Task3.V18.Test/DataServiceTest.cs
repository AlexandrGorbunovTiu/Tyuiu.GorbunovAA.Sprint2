using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint2.Task3.V18.Lib;

namespace Tyuiu.GorbunovAA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            var x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 36);
        }


        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            var x = 0;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 0,75);

        }

        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            var x = -1;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 0,5);

        }


        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            var x = -100;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, -1099,99);

        }





    }
}
