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

    //[TestClass]
    //public class rf1
    //{
    //    public RF1 rf;
    //    [TestMethod]
    //    public void TM1()
    //    {
    //        string expected = "SAD";
    //        string msg = "I Am SAD";
    //        rf = new RF1(msg);
    //        string value = rf.analysemood();
    //        Assert.AreEqual(expected, value);
    //    }
    //    [TestMethod]
    //    public void TM11()
    //    {
    //        string expected = "HAPPY";
    //        string msg = "I Am HAPPY";
    //        rf = new RF1(msg);
    //        string value = rf.analysemood();
    //        Assert.AreEqual(expected, value);
    //    }
    //}

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC3.1
        public void Given_NULL_Mood_Should_Throw_MoodAnalyszerCustomException()
        {
            try
            {
                string message = null;
                MoodAnalyzerBuilder moodAnalyzer = new MoodAnalyzerBuilder(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        //TC3.2
        public void Given_Empyt_Mood_Should_Throw_MoodAnalyszerCustomException()
        {
            try
            {
                string message = "";
                MoodAnalyzerBuilder moodAnalyzer = new MoodAnalyzerBuilder(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        //TC4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyzerBuilder(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder");
            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);

        }
        //TC4.2
        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuildera", "MoodAnalyzerBuildera");
            }
            catch (MoodAnalyszerCustomException e)
            {
                //Assert.AreEqual(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS.ToString(), objFactory);
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        //TC4.3
        [TestMethod]
        public void GivenClassWhenConstructorNotProperShouldThrowException()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuildera");
            }
            catch (MoodAnalyszerCustomException e)
            {
                //Assert.AreEqual(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS.ToString(), objFactory);
                Assert.AreEqual("Constructor is not found", e.Message);
            }

        }

        //TC5.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzerBuilder("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder", "SAD");
            expected.Equals(obj);
            //Assert.AreEqual(expected,obj);
        }
        //TC5.2
        [TestMethod]
        public void GivenClassNameWhenImproper_ShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuildera", "MoodAnalyzerBuildera", "SAD");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        //TC5.3
        [TestMethod]
        public void GivenClassWhenConstructorNotProperShouldThrowException_UsingParameterizedConstructor()
        {
            try
            {
                object objFactory = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuildera", "SAD");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }
        }
        //TC6.1
        [TestMethod]
        public void InvokeMethod_GivenHappy_ReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyserFactory.InvokeMethod("AnalyseMood", "HAPPY");
            Assert.AreEqual(expected, actual);
        }
        //6.2
        [TestMethod]
        public void InvokeMethod_GivenImproperMethod_ReturnException()
        {
            try
            {
                object obj = MoodAnalyserFactory.InvokeMethod("Analysemood", "HAPPY");
            }
            catch (MoodAnalyszerCustomException e)
            {
                Assert.AreEqual("Method is not found", e.Message);
            }
        }

    }
}