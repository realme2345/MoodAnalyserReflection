using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{/// <summary>
/// Reflection method 
/// </summary>
    public class MoodAnalyseractory //to check the reflection with parameterised constructer
    {
        public static object CreateMoodAnalyse(string className,string constructerName,string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className)||type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructerName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance= ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_METHOD, "Constructer is not found");
                }
            }
            else
            {
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_CLASS, "Class not found");

            }
        }
    }
}
