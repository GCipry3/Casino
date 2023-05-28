using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotsGame
{
    internal class Bet
    {
        int betValue;

        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }
        public Bet()
        { }
        public int GetRarity(string img)
        {
            Dictionary<string, int> rarities = new Dictionary<string, int>()
            {
                { "_7", 1},
                { "bananas", 2},
                { "cherries",3},
                { "lemon", 4},
                { "orange",5},
                { "plum",6},
                { "strawberry", 7},
                { "watermelon", 8}
            };

            return rarities.ContainsKey(img) ? rarities[img] : 8;
        }


        public int GetThePrize(string firstImg, string secondImg, string thirdImg)
        {
            int firstRarity = GetRarity(firstImg);
            int secondRarity = GetRarity(secondImg);
            int thirdRarity = GetRarity(thirdImg);

            int betValue = 1;  // assuming betValue starts from 1

            // Case of three matching images
            if (firstImg == secondImg && secondImg == thirdImg)
            {
                betValue *= (25 / firstRarity);
            }
            // Case of two matching images
            else if (firstImg == secondImg || secondImg == thirdImg)
            {
                int avgRarity = (firstRarity + secondRarity + thirdRarity) / 3;
                betValue *= (10 / avgRarity);
            }
            else // no matching images
            {
                betValue = 0;
            }

            return betValue;
        }

    }
}
