using System;

namespace HigherLowerGame
{
    // Represents a betting system in a higher lower game.
    internal class BetHigherLower : IBetHigherLower
    {
        // Current bet value.
        private int betValue;
        const int WinningMultiplier = 5;

        // Gets or sets the current bet value.
        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }

        public BetHigherLower()
        { }

        // Calculates the prize based on the bet, two images' values, and chosen option.
        public int GetThePrize(string firstImg, string secondImg, string option)
        {
            int first = int.Parse(firstImg.Substring(1, 2));
            int second = int.Parse(secondImg.Substring(1, 2));

            if ((option == "higher" && first < second) || (option == "lower" && first > second))
            {
                return betValue * WinningMultiplier;
            }
            else if (second != first)
            {
                return 0;
            }

            return betValue;
        }
    }
}
