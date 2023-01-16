using NhlSystemClassLibrary;

namespace NhlSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers", "Edmonton", "Rogers Place", Conference.Western, division.Pacific)]
        [DataRow("Flames", "Calgary", "Scotiabank Saddledome", Conference.Western, division.Pacific)]
        [DataRow("Canucks", "Vacouver", "Rogers Arena", Conference.Western, division.Pacific)]
        [DataRow("Maple Leafs", "Toronto", "Scotiabank Arena", Conference.Eastern, division.Atlantic)]
        [DataRow("Senators", "Ottawa", "Canadian Tire Centre", Conference.Eastern, division.Atlantic)]
        [DataRow("Canadiens", "Montreal", "Centre Bell", Conference.Eastern, division.Atlantic)]
        [DataRow("Jets", "Winnipeg", "Canadian Life Centre", Conference.Western, division.Central)]
        public void Name_ValidName_NameSet(string teamName, string city, string arena, Conference conference, division division)
        {
            // Arrange
            // Act
            Team currentTeam = new Team(teamName, city, arena, conference, division);
            // Assert
            Assert.AreEqual(teamName, currentTeam.Name);
            Assert.AreEqual(conference, currentTeam.Conference);
            Assert.AreEqual(division, currentTeam.Division);
            Assert.AreEqual(city, currentTeam.City);
            Assert.AreEqual(arena, currentTeam.Arena);
        }

        //[TestMethod]
        //[DataRow("", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        //[DataRow("     ", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        //public void Name_InvalidName_THrowsArgumentNullException(
        //    string teamName, 
        //    string exceptedErrorMessage,
        //    Conference conference,
        //    Division divison
        //    )
        //{
        //    // Arrange and Act
        //    try
        //    {
        //        Team currentTeam = new Team(teamName, conference, divison);
        //        Assert.Fail("An ArgumentNullException should have been thrown");
        //    }
        //    catch(ArgumentNullException ex)
        //    {
        //        StringAssert.Contains(ex.Message, exceptedErrorMessage);
        //    }
        //}
    }
}