using Lab.Game.WinningStreak.BLL.Dice;
using NUnit.Framework;

namespace Lab.Game.WinningStreak.BLLTest.Dice
{
    [TestFixture]
    public class DieTest
    {
        [Test]
        public void DieFaceValueShouldBeWithinOneAndSixRange()
        {
            // Arrange
            var die = new Die();

            //Act
            var dieFaceValue = die.Roll();

            //Assert
            Assert.IsTrue(dieFaceValue >= 1 && dieFaceValue <= 6);
        }

    }
}
