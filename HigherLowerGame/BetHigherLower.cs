using System;

namespace HigherLowerGame
{
    // Represents a betting system in a higher lower game.
    internal class BetHigherLower
    {
        // Current bet value.
        private int betValue;

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
            int first;
            int second;

            firstImg = firstImg.Substring(1, 2);
            first = int.Parse(firstImg);
            secondImg = secondImg.Substring(1, 2);
            second = int.Parse(secondImg);

            // Prize calculation based on the option and the images' values.
            switch (option)
            {
                case "higher" when first < second:
                case "lower" when first > second:
                    betValue *= 5;
                    break;
                case "higher":
                case "lower" when second != first:
                    betValue = 0;
                    break;
            }

            return betValue;
        }
    }
}
