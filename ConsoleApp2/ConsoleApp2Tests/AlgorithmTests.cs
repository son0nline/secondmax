using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class AlgorithmTests
    {
        Algorithm giaithuat = new Algorithm();

        [TestMethod()]
        public void thirdMaxTest()
        {
            int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            Assert.AreEqual(5, giaithuat.thirdMax(ls));
        }

        [TestMethod()]
        public void thirdMaxTest1()
        {
            int[] ls = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(3, giaithuat.thirdMax(ls));
        }


        [TestMethod()]
        public void thirdMaxTest2()
        {
            int[] ls = { 1, 3, 5, 4, 2 };
            Assert.AreEqual(3, giaithuat.thirdMax(ls));

        }


        [TestMethod()]
        public void thirdMaxTest3()
        {
            int[] ls = { 5, 4, 3, 2, 1 };
            Assert.AreEqual(3, giaithuat.thirdMax(ls));
        }

        [TestMethod()]
        public void thirdMaxTest4()
        {
            // test trùng số trong list
            int[] ls = { 9, 9, 2, 3, 4, 8, 5, 6, 7, 9 };
            Assert.AreEqual(7, giaithuat.thirdMax(ls));
        }

        [TestMethod()]
        public void thirdMaxTest5()
        {
            int[] ls = { 5, 4, 4 };
            Assert.AreEqual(5, giaithuat.thirdMax(ls));
        }

        [TestMethod()]
        public void thirdMaxTest6()
        {
            int[] ls = { 9, 2 };
            Assert.AreEqual(9, giaithuat.thirdMax(ls));
        }

        [TestMethod()]
        public void thirdMaxTest7()
        {
            int[] ls = { 9, 8, 8, 8, 8, 8 };
            Assert.AreEqual(9, giaithuat.thirdMax(ls));
        }
    }
}