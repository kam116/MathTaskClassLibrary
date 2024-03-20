using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class CheckOnEntryPointInAreaTests
    {
        // полукруг (начало стрелки)
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

        // полукруг (конец стрелки)
        [TestMethod]
        public void Check_R1_X1dot7_Y0dot7_1returned()
        {
            // исходные данные
            double r = 1;
            double x = 1.7;
            double y = 0.7;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // полукруг (незакрашенная часть)
        [TestMethod]
        public void Check_R1_X2_Y1_0returned()
        {
            // исходные данные
            double r = 1;
            double x = 2;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // полукруг (незакрашенная часть)
        [TestMethod]
        public void Check_R1_X1_Y4_0returned()
        {
            // исходные данные
            double r = 1;
            double x = 1;
            double y = 4;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // полукруг (направление стрелки)
        [TestMethod]
        public void Check_R1_X5_Y3_0returned()
        {
            // исходные данные
            double r = 1;
            double x = 5;
            double y = 3;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // центр графика
        [TestMethod]
        public void Check_R1_X0_Y0_1returned()
        {
            // исходные данные
            double r = 1;
            double x = 0;
            double y = 0;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 2 четверть
        [TestMethod]
        public void Check_R1_Xminus1_Y1_0returned()
        {
            // исходные данные
            double r = 1;
            double x = -1;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 3 четверть (незакрашенная часть)
        [TestMethod]
        public void Check_R1_Xminus2_Yminus1_0returned()
        {
            // исходные данные
            double r = 1;
            double x = -2;
            double y = -1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 3 четверть (закрашенная часть)
        [TestMethod]
        public void Check_R4_Xminus1_Yminus1_2returned()
        {
            // исходные данные
            double r = 4;
            double x = -1;
            double y = -1;
            byte excepted = 2;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        // 4 четверть
        [TestMethod]
        public void Check_R1_X3_Yminus1_0returned()
        {
            // исходные данные
            double r = 1;
            double x = 3;
            double y = -1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 3 четверть (закрашенная часть) - ошибка
        [TestMethod]
        public void Check_R8_Xminus2_Yminus2_0returned()
        {
            // исходные данные
            double r = 8;
            double x = -2;
            double y = -2;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }


        // 
        [TestMethod]
        public void Check_R2_Xminus1_Y1_0returned()
        {
            // исходные данные
            double r = 2;
            double x = -1;
            double y = 1;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 3 четверть не входит из-за у
        [TestMethod]
        public void Check_R3_Xminus1_Yminus4point5_0returned()
        {
            // исходные данные
            double r = 3;
            double x = -1;
            double y = -4.5;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // 4 четверть не входит из-за х и у
        [TestMethod]
        public void Check_R4_X3_Yminus3_0returned()
        {
            // исходные данные
            double r = 4;
            double x = 3;
            double y = -3;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // провал теста 1 четверть входит
        [TestMethod]
        public void Check_R5_X4_Y5point3_1returned()
        {
            // исходные данные
            double r = 5;
            double x = 4;
            double y = 5.3;
            byte excepted = 1;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }

        // провал теста 1 четверть не входит
        [TestMethod]
        public void Check_R5_X4_Y2point3_0returned()
        {
            // исходные данные
            double r = 5;
            double x = 4;
            double y = 2.3;
            byte excepted = 0;

            // получение значения с помощью тестируемого метода
            byte actual = new CheckOnEntryPointInArea(r).CheckOnEntry(x, y);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(excepted, actual);
        }
    }
}
