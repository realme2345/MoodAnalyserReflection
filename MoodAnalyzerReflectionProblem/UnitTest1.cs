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
      ///Use Reflection to Create Mood Analyser with parameterised constructer  constructer
      /// </summary>
        [TestMethod]
        public void GiveMoodAnalyseClassNameShouldReturnMoodAnalyseObject()
        {
            //string message = "happy";
            //MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string exepected = "happy";
            string obj = MoodAnalyseractory.CreateMoodAnalyse("happy","AnalyseMood");
            Assert.AreEqual(exepected,obj);
        }
    }
}

