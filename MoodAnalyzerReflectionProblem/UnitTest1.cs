using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserReflection;

namespace MoodAnalyzerReflectionProblem
{/// <summary>
/// Mood Analyser Test Case
/// </summary>
    [TestClass]
    public class TestingAnalyzer
    { /// <summary>
      /// Use Reflection to Create Mood Analyser with parameterised constructer  constructer
        /// </summary>
        [TestMethod]
        public void GiveMoodAnalyseClassNameShouldReturnMoodAnalyseObject()
        {
            string message = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            object exepected = moodAnalyser.AnalyseMood();
            object obj = MoodAnalyseractory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser","happy");
            exepected.Equals(obj);
        }
    }
}
    

