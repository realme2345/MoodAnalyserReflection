using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{/// <summary>
/// Reflection
/// </summary>
    public class MoodAnalyseractory
    {
        public static object CreateMoodAnalyse(string className,string constructerName)
        {
            string pattern = @"."+constructerName+"$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType=executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_CLASS, "Class not found");    
                }
            }
            else
            {
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_METHOD, "Constructer is not found");
            }
        }
    }
}
