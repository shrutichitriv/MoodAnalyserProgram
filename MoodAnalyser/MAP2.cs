using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MAP2
    {
        public string analysemood(string msg)
        {
            //exception handled using try catch
            try
            {
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
            catch
            {
                return "HAPPY";
            }
        }
    }
    internal class MAPP2
    {
        public static void Main(string[] args)
        {

        }
    }
}
