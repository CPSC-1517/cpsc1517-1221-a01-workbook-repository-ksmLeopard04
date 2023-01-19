using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemTestProject
{
    internal class PlayerTest
    {
        [TestMethod]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C)]
        [DataRow(91, "Evander Kane", Position.LW)]
        public void Constructor_ValidData_ShouldPass(int playerNo, string playerName, Position playerPosition)
        {
            // Arrange and Act
            Player currentPlayer = new Player(playerNo, playerName, playerPosition);
            // Assert
            Assert.AreEqual(playerNo, currentPlayer.PlayerNo);
            Assert.AreEqual(playerName, currentPlayer.Name);
            Assert.AreEqual(playerPosition, currentPlayer.Position);

        }

        [TestMethod]
        [DataRow(0, "Connor McDavid", Position.C)]
        [DataRow(99, "Connor McDavid", Position.C)]
        [DataRow(-1, "Connor McDavid", Position.C)]
        [DataRow(100, "Connor McDavid", Position.C)]
        public void PlayerNo_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                // Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "PlayerNo must be between 1 and 98");
                Assert.AreEqual(ex.Message, "PlayerNo must be between 1 and 98");
            }
            catch(Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown");
            }
        }
        [TestMethod]
        [DataRow(93, "Connor McDavid", Position.C)]
        [DataRow(92, "Connor McDavid", Position.C)]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(96, "Connor McDavid", Position.C)]
        public void PlayerName_InvalidValue_ThrowsArgumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                // Arrange and Act
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Name cannot be blank.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown");
            }
        }
    }
}
