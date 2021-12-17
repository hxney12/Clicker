using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clicker;

namespace ClickerTest
{
    [TestClass]
    public class ClickerTest1
    {
        [TestMethod]
        public void ButtomOneUpGrade_1and10and30and02_312()
        {

            // исходные данные 10 + 10 * (30 + click * 0.2)
            int click = 1;
            int post = 10;
            int post2 = 30;
            double post3 = 0.2;
            double expected = 312;

            // получение значения с помощью тестируемого метода
            double actual = post + post * (post2 + click * post3);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);

            
        }
    }
}
