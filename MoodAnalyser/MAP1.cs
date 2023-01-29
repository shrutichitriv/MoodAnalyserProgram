using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MoodAnalyser
{
    public class MAP1
    {
        public string analysemood(string msg)
        {
            //checking if msg passed contains given value or not
            if (msg.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
    internal class MAPP1
    {
        public static void Main(string[] args)
        {

        }
    }
}