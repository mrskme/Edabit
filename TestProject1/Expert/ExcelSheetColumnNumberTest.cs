using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Edabit.Expert.ExcelSheetColumn;


namespace TestProject1.Expert
{
    [TestClass]
    public class ExcelSheetColumnNumberTest
    {
        [TestMethod]
        public void TestOutput()
        {
            var input = "AA";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 27;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOutput2()
        {
            var input = "R";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 18;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOutput3()
        {
            var input = "AB";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 28;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOutput4()
        {
            var input = "ZY";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 701;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOutput5()
        {
            var input = "KFC";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 7595;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOutput6()
        {
            var input = "WEB";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 15680;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOutput7()
        {
            var input = "FRIENDS";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 2071569675;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestOutput8()
        {
            var input = "TRUMP";
            var actual = ExcelSheetColumnNumber.TitleToNumber(input);
            var expected = 9470438;

            Assert.AreEqual(expected, actual);
        }

    }
}
