﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        //public static object CreateMoodAnalyse(string className, string constructorName)
        //{
        //    string pattern = @"." + constructorName + "$";
        //    Match result = Regex.Match(className, pattern);
        //    if (result.Success)
        //    {
        //        try
        //        {

        //            Assembly executing = Assembly.GetExecutingAssembly();
        //            Type moodAnalyseType = executing.GetType(className);
        //            return Activator.CreateInstance(moodAnalyseType);
        //        }
        //        catch (ArgumentNullException)
        //        {
        //            throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

        //        }
        //    }
        //    else
        //    {
        //        throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
        //    }
        //}

        //UC4
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }


            }
            else
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
    }
}
