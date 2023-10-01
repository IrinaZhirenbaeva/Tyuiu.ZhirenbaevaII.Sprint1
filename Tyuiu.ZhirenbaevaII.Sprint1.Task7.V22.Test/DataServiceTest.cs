using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.211;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
