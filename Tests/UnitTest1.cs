using Day21MoodAnlayazer;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Day21MoodAnlayazer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Any Mood");


        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}

