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

        //UC5
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyzerBuilder);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }

        //UC6
        public static string InvokeMethod(string methodName, string message)
        {
            Type type = typeof(MoodAnalyzerBuilder);
            try
            {
                object methodObject = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyzerBuilder", "MoodAnalyzerBuilder", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                if (methodInfo == null)
                {
                    throw new MoodAnalyszerCustomException(MoodAnalyszerCustomException.ExceptionType.NO_SUCH_METHOD, "Method is not found");
                }
                string method = (string)methodInfo.Invoke(methodObject, null);
                return method;
            }
            catch (MoodAnalyszerCustomException ex)
            {
                return ex.Message;
            }
        }
    }
}
