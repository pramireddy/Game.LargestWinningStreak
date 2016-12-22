using Lab.Game.WinningStreak.BLL;
using Lab.Game.WinningStreak.BLL.Dice;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab.Game.WinningStreak.BLLTest
{
    [TestFixture]
    public class WinningStreakProcessorTest
    {
        private Mock<IDie> _die;

        [OneTimeSetUp]
        public void TestSetup()
        {
            _die = new Mock<IDie>();
        }

        /// <summary>
        ///Input 10
        ///Press ‘Throw’
        ///The application will then simulate the number of throws…
        ///4, 3, 6, 6, 1, 3, 5, 6, 4, 1
        ///A winning streak is the amount of times a six was thrown in a row. 
        /// </summary>
        [Test]
        public void Test_The_Largest_Winning_Streak_For_Scenario_One()
        {
            //Arrage
            _die.SetupSequence(x => x.Roll()).Returns(4).Returns(3).Returns(6).Returns(6)
                .Returns(1).Returns(3).Returns(5).Returns(6).Returns(4).Returns(1);

            IWinningStreakProcessor winningStreakProcessor = new WinningStreakProcessor(_die.Object);

            // Act
            var largestStreak = winningStreakProcessor.LargestWinningStreak(6, 10);

            // Assert
            Assert.IsTrue(largestStreak == 2);

        }

        /// <summary>
        ///Input 20
        ///Press ‘Throw’
        ///The application will then simulate the number of throws…
        ///4, 5, 3, 6, 6, 4, 3, 5, 1, 2, 4, 6, 6, 5, 4, 3, 1, 6, 6, 6
        ///A winning streak is the amount of times a six was thrown in a row. 
        /// </summary>
        [Test]
        public void Test_The_Largest_Winning_Streak_For_Scenario_Two()
        {
            //Arrage
            _die.SetupSequence(x => x.Roll()).Returns(4).Returns(5).Returns(3).Returns(6).Returns(6).Returns(4).Returns(3).Returns(5).Returns(1).Returns(2)
                                             .Returns(4).Returns(6).Returns(6).Returns(5).Returns(4).Returns(3).Returns(1).Returns(6).Returns(6).Returns(6);

            IWinningStreakProcessor winningStreakProcessor = new WinningStreakProcessor(_die.Object);

            // Act
            var largestStreak = winningStreakProcessor.LargestWinningStreak(6, 20);

            // Assert
            Assert.IsTrue(largestStreak == 3);

        }
    }
}
