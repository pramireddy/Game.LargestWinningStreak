using System;

namespace Lab.Game.WinningStreak.BLL.Dice
{
    public class Die : IDie
    {
        private readonly Random _random;

        public Die()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}
