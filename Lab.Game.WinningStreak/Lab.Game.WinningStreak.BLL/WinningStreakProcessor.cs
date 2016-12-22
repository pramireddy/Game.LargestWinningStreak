using Lab.Game.WinningStreak.BLL.Dice;

namespace Lab.Game.WinningStreak.BLL
{
    public class WinningStreakProcessor : IWinningStreakProcessor
    {
        private IDie _die;

        public WinningStreakProcessor(IDie die)
        {
            _die = die;
        }

        /// <summary>
        /// Method to calculate the largest winning streak
        /// </summary>
        /// <param name="winningNumber"> Taget winning nunmber: for example: 6 or 4 </param>
        /// <param name="throws">The amount of times to throw a single die</param>
        /// <returns></returns>
        public int LargestWinningStreak(int winningNumber,int throws)
        {
            var largestStreak = 0;
            var templargestStreak = 0;

            for (var i = 0; i < throws; i++)
            {
                var number = _die.Roll();

                if (number == winningNumber)
                    templargestStreak++;
                else
                    templargestStreak = 0;

                if (largestStreak >= templargestStreak) continue;
                largestStreak = templargestStreak;

            }

            return largestStreak > 1 ? largestStreak: 0;
        }
    }
}
