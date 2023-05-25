using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLowerGame
{
    internal class BetHigherLower
    {
        int betValue;

        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }
        public BetHigherLower()
        { }

        //this function calculates the prize the player will get
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
                return 11;
            }
            if (secondImg.Length >= 3)
            {
                secondImg = secondImg.Substring(1, 2);
                second = int.Parse(secondImg);
            }
            else
            {
                return 11;
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
