using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string value = "ТИУ лучший";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(value);
            string wait = "ИУ лучшийТ";
            Assert.AreEqual(wait, res);

        }
    }
}
