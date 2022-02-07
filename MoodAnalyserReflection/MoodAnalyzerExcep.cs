using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{
    public class MoodAnalyzerExcep:Exception
    {/// <summary>
    /// Custom Exception 
    /// </summary>
        public ExceptionType type;
        public enum ExceptionType//declaring the Custom Exception
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public MoodAnalyzerExcep(ExceptionType type, string message) : base(message) //this method using for catching the Exception
        {
            this.type = type;
        }
    }
}
