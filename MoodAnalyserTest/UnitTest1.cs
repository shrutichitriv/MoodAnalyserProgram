using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public MAP1 map1;
        [TestMethod]
        public void TestMethod1()
        {
            map1 = new MAP1();
            string expected = "SAD";
            string msg = "I Am SAD";
            string value = map1.analysemood(msg);
            Assert.AreEqual(expected, value);
        }
        [TestMethod]
        public void TestMethod()
        {
            {
                map1 = new MAP1();
                string expected = "HAPPY";
                string msg = "I Am HAPPY";
                string value = map1.analysemood(msg);
                Assert.AreEqual(expected, value);
            }
        }
    }
}