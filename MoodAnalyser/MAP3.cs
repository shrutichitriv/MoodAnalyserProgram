using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysisException : Exception
    {
        //to differentiate Mood Analysis Error
        public enum ExceptionType
        {
            Null, Empty
        }

        public readonly ExceptionType type;

        //creating Custom Exception
        public MoodAnalysisException(ExceptionType type, string msg)
        : base(msg)
        {
            this.type = type;
        }
    }
    public class MAP3
    {
        public string analysemood(string msg)
        {
            //Exception handled using try catch
            try
            {
                //checking if msg passed is empty or not
                if (msg.Equals(string.Empty))
                {
                    //thows Exception If Empty Value
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty, "Empty Value");
                }
                //checking if msg passed contains given value
                if (msg.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                //thows Exception If Null Value
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Null, "Null Value");
            }
        }
    }
    internal class MAPP3
    {
        public static void Main(string[] args)
        {

        }
    }
}
