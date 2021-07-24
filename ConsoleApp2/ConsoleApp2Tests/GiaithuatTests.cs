using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Program.Tests
{
    [TestClass()]
    public class GiaithuatTests
    {

        ConsoleApp2.GiaithuatSecondMax giaithuat = new GiaithuatSecondMax();

        [TestMethod()]
        public void c1Test()
        {
            int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            Assert.AreEqual(8, giaithuat.c1(ls));
        }

        [TestMethod()]
        public void c2Test()
        {
            int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            Assert.AreEqual(8, giaithuat.c2(ls));
        }


        [TestMethod()]
        public void c3Test()
        {
            //int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            //int[] ls = { 1, 3, 5, 4 };
            //int[] ls = { 1, 3, 5, 4, 5 };
            //int[] ls = { 5, 4, 5 };
            int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            Assert.AreEqual(8, giaithuat.c3(ls));
        }

        [TestMethod()]
        public void c3Test1()
        {
            int[] ls = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(4, giaithuat.c3(ls));
        }


        [TestMethod()]
        public void c3Test2()
        {
            int[] ls = { 1, 3, 5, 4, 2 };
            Assert.AreEqual(4, giaithuat.c3(ls));

        }


        [TestMethod()]
        public void c3Test3()
        {
            int[] ls = { 5, 4, 3, 2, 1 };
            Assert.AreEqual(4, giaithuat.c3(ls));
        }

        [TestMethod()]
        public void c3Test4()
        {
            int[] ls = { 5, 4, 5 };
            Assert.AreEqual(4, giaithuat.c3(ls));
        }

        [TestMethod()]
        public void c3Test5()
        {
            // test trùng số trong list
            int[] ls = { 9, 9, 2, 3, 4, 8, 5, 6, 7, 9 };
            Assert.AreEqual(8, giaithuat.c3(ls));
        }
    }
}