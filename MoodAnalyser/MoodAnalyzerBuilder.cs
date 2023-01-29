using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzerBuilder
    {
        //public string message;


        //public MoodAnalyzerBuilder(string message)
        //{
        //    this.message = message;
        //}
        //public MoodAnalyzerBuilder()
        //{
        //}
        //public string AnalyseMood()
        //{

        //    try
        //    {
        //        if (this.message.Equals(string.Empty))
        //        {
        //            throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
        //        }
        //        if (this.message.Contains("sad"))
        //            return "SAD";
        //        else
        //            return "HAPPY";
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
        //    }
        //}

        public string msg;
        public MoodAnalyzerBuilder() 
        { 
        }

        public MoodAnalyzerBuilder(string msg)
        {
            this.msg = msg;
        }

        public string AnalyseMood(string msg)
        {
            if (msg.Contains("Sad", StringComparison.OrdinalIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return null;
        }
        public string AnalyseMood()
        {
            if (this.msg.Contains("Happy", StringComparison.OrdinalIgnoreCase))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return null;
        }
    }
}
