using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Reflection");//Method for getting assembles 
            MoodAnalyseractory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser","MoodAnalyser");
        }
    }
}
