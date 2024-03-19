using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class CheckOnEntryPointInAreaTests
    {
        // 1 четверть входит
        [TestMethod]
        public void Check_R1_X1_Y0_1returned()
        {
            // исходные данные
            double r = 1;
            double x = 1;
            double y = 0;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }
    }
}
