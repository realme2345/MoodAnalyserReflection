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
      /// /Use Reflection to Create Mood Analyser with default constructer
        /// </summary>
        [TestMethod]
        public void GiveMoodAnalyseClassNameShouldReturnMoodAnalyseObject()
        {
                //string message = null;
                object exepected = new MoodAnalyser();
                object obj = MoodAnalyseractory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser");
                exepected.Equals(obj);
        }

    }
}
    

