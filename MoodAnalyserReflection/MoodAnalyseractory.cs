using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{ /// <summary>
  /// Reflection method 
  /// </summary>
    public class MoodAnalyseractory //check the reflection with parameterised constructer
    {
        public static string CreateMoodAnalyse(string message,string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserReflection.MoodAnalyser");
                object moodAnalyserObject = MoodAnalyseractory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser","MoodAnalyser");
                MethodInfo method = type.GetMethod(methodName);
                object mood = method.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch(NullReferenceException)   
            {
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_METHOD, "Method is not found");
            }
        }
    }
}
