using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    public MAP1 map1;
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //        map1 = new MAP1();
    //        string expected = "SAD";
    //        string msg = "I Am SAD";
    //        string value = map1.analysemood(msg);
    //        Assert.AreEqual(expected, value);
    //    }
    //    [TestMethod]
    //    public void TestMethod()
    //    {
    //        {
    //            map1 = new MAP1();
    //            string expected = "HAPPY";
    //            string msg = "I Am HAPPY";
    //            string value = map1.analysemood(msg);
    //            Assert.AreEqual(expected, value);
    //        }
    //    }
    //}

    //[TestClass]
    //public class UnitTest1
    //{
    //    public MAP2 map2;
    //    [TestMethod]
    //    [DataRow(null)]
    //    public void TestMethod2(string msg)
    //    {
    //        map2 = new MAP2();
    //        string expected = "HAPPY";
    //        string value = map2.analysemood(msg);
    //        Assert.AreEqual(expected, value);
    //    }
    //}

    //[TestClass]
    //public class UnitTest1
    //{
    //    public MAP3 map3;
    //    [TestMethod]
    //    public void EmptyMsg()
    //    {
    //        map3 = new MAP3();
    //        try
    //        {
    //            string msg = "";
    //            string value = map3.analysemood(msg);
    //        }
    //        catch (MoodAnalysisException e)
    //        {
    //            Assert.AreEqual("Empty Value", e.Message);
    //        }
    //    }
    //    [TestMethod]
    //    public void NullMsg()
    //    {
    //        map3 = new MAP3();
    //        try
    //        {
    //            string msg = null;
    //            string value = map3.analysemood(msg);
    //        }
    //        catch (MoodAnalysisException e)
    //        {
    //            Assert.AreEqual("Null Value", e.Message);
    //        }
    //    }
    //}

    [TestClass]
    public class rf1
    {
        public RF1 rf;
        [TestMethod]
        public void TM1()
        {
            string expected = "SAD";
            string msg = "I Am SAD";
            rf = new RF1(msg);
            string value = rf.analysemood();
            Assert.AreEqual(expected, value);
        }
        [TestMethod]
        public void TM11()
        {
            string expected = "HAPPY";
            string msg = "I Am HAPPY";
            rf = new RF1(msg);
            string value = rf.analysemood();
            Assert.AreEqual(expected, value);
        }
    }
}