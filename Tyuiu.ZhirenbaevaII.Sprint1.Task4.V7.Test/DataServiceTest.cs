using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint1.Task4.V7.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wer = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wer, res);
        }
    }
}
