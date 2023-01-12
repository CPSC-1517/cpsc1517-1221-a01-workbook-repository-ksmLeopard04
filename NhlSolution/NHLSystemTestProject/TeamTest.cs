using NhlSystemClassLibrary;

namespace NHLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers", Conference2.Western, division.Pacific)]
        [DataRow("Flames", Conference2.Western, division.Pacific)]
        [DataRow("Canucks", Conference2.Western, division.Pacific)]
        [DataRow("Maple Leafs", Conference2.Eastern, division.Atlantic)]
        [DataRow("Senators", Conference2.Eastern, division.Atlantic)]
        [DataRow("Canadiens", Conference2.Eastern, division.Atlantic)]
        [DataRow("Jets", Conference2.Eastern, division.Central)]
        public void Name_ValidName_NameSet(string teamName, Conference2 Conference, division Division)
        {
            // Arrange
            // Act
            Team currentTeam = new Team(teamName, Conference, Division);
            // Assert
            Assert.AreEqual(teamName, currentTeam.Name);
            Assert.AreEqual(Conference, currentTeam.Conference);
            Assert.AreEqual(Division, currentTeam.Division);
        }

        [TestMethod]
        [DataRow("", "Name cannot be blank.")]
        [DataRow("     ", "Name cannot be blank.")]
        public void Name_InvalidName_ThrowsArgumentNullException(string teamName, string expectedErrorMessage, Conference2 Conference, division Division)
        {
            //Arrange and act
            try
            {
                Team currentTeam = new Team(teamName);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }
    }
}