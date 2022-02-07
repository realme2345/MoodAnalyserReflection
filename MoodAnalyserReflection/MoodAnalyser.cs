using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message) //Creating a constructer 
        {
            this.message = message;
        }
        public string AnalyseMood() //this mothod is used for to analyse mood of user by using Exception 
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.Equals(string.Empty)) //Custom Exception for user understanding message
                {
                    throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.EMPTY_EXCEPTION, "Message Should not be null");

                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex) //if  null Exception is occured the block of ststement executed and return Happy
            {
                Console.WriteLine(ex.Message);
                //return "happy";
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NULL_EXCEPTION, "Message Should not be null");
            }
        }
    }
}
