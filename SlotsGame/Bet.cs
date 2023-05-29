using System.Collections.Generic;

namespace SlotsGame
{
    // This class represents a Bet in the Slot Game.
    internal class Bet
    {
        const int TwoOfAKind = 20;
        const int ThreeOfAKind = 60;
        // The value of the bet.
        int betValue;

        // The property to get and set the Bet value.
        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }

        // This method returns the rarity value of a given image.
        public int GetRarity(string img)
        {
            // Rarity values for different images.
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

            // Returns the rarity of the given image, or the maximum rarity (8) if the image is not found in the dictionary.
            return rarities.ContainsKey(img) ? rarities[img] : 8;
        }

        // This method calculates the prize based on the images shown in the slots.
        public int GetThePrize(string firstImg, string secondImg, string thirdImg)
        {
            // Get the rarity values of the images.
            int firstRarity = GetRarity(firstImg);
            int secondRarity = GetRarity(secondImg);
            int thirdRarity = GetRarity(thirdImg);

            // Initial bet value assumed to be 1.
            int betValue = 1;

            // If all three images are the same, the prize is 25 divided by the rarity of the image.
            if (firstImg == secondImg && secondImg == thirdImg)
            {
                betValue *= (ThreeOfAKind / firstRarity);
            }
            // If two images are the same, the prize is 10 divided by the average rarity of the images.
            else if (firstImg == secondImg || secondImg == thirdImg)
            {
                int avgRarity = (firstRarity + secondRarity + thirdRarity) / 3;
                betValue *= (TwoOfAKind / avgRarity);
            }
            // If no images match, the prize is zero.
            else
            {
                betValue = 0;
            }

            // Returns the calculated prize.
            return betValue;
        }
    }
}
