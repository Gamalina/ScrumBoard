using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumBoardLibrary.model;

namespace ScrumBoardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestId1()
        {

            // Arrange
            UserStory us = new UserStory();
            int expectedValue = 1;

            // Act
            us.Id = 1;
            int actualValue = us.Id;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
        [TestMethod]
        [DataRow("Hej")]
        [DataRow("He")]
        [DataRow("HejHejHej")]
        public void TestTitle1()
        {

            // Arrange
            UserStory us = new UserStory();
            int expectedValue = 1;

            // Act
            us.Id = 1;
            int actualValue = us.Id;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
