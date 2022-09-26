using Day21MoodAnlayazer;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Day21MoodAnlayazer.MoodAnalyzer moodAnalyzer = new MoodAnalyzer();


        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";

            //Act
            string actual = moodAnalyzer.AnalyzeMood("I am in Sad Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyzeMood("I am in Any Mood");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}

