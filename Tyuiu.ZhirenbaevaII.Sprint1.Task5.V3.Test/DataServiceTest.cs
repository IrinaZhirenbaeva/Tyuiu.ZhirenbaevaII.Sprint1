using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 130985;
            DataService ds = new DataService();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int h = 9;
            Assert.AreEqual(h, result);
        }
    }
}
