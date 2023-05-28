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
            if (firstImg.Length >= 3)
            {
                firstImg = firstImg.Substring(1, 2);
                first = int.Parse(firstImg);
            }
            else
            {
                return 0;
            }
            if (secondImg.Length >= 3)
            {
                secondImg = secondImg.Substring(1, 2);
                second = int.Parse(secondImg);
            }
            else
            {
                return 0;
            }

            if ((option == "higher") && (first < second))
            {
                betValue *= 5;
            }
            else
            {
                if ((option == "lower") && (first > second))
                {
                    betValue *= 5;
                }
                else
                {
                    if (second == first)
                    {
                        return betValue;
                    }
                    else
                    {
                        betValue = 0;
                    }
                }
            }
            return betValue;
        }
    }
}
