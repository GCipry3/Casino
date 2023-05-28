using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Resources;

namespace HigherLowerGame
{
    // The HigherLowerGame class represents a higher lower game.
    internal class HigherLowerGame
    {
        // The random number generator used for drawing random images.
        private readonly Random random;

        // The BetHigherLower instance used for calculating winnings.
        private readonly BetHigherLower betValue;

        // The dictionary mapping image names to images.
        private readonly Dictionary<string, Image> images;

        // The option chosen by the player ("higher" or "lower").
        public string Option { get; set; }

        public HigherLowerGame()
        {
            random = new Random();
            betValue = new BetHigherLower();

            // Initialize the images dictionary with the game images.
            images = new Dictionary<string, Image>()
            {
                { "_02trefla", ResourceManager.GetImage("Resources.Resources.2trefla.jpg")},
                { "_02romb", ResourceManager.GetImage("Resources.Resources.2romb.jpg")},
                { "_02frunza", ResourceManager.GetImage("Resources.Resources.2frunza.jpg")},
                { "_02inima", ResourceManager.GetImage("Resources.Resources.2inima.jpg")},
                { "_03trefla", ResourceManager.GetImage("Resources.Resources.3trefla.jpg")},
                { "_03romb", ResourceManager.GetImage("Resources.Resources.3romb.jpg")},
                { "_03frunza", ResourceManager.GetImage("Resources.Resources.3frunza.jpg")},
                { "_03inima", ResourceManager.GetImage("Resources.Resources.3inima.jpg")},
                { "_04trefla", ResourceManager.GetImage("Resources.Resources.4trefla.jpg")},
                { "_04romb", ResourceManager.GetImage("Resources.Resources.4romb.jpg")},
                { "_04frunza", ResourceManager.GetImage("Resources.Resources.4frunza.jpg")},
                { "_04inima", ResourceManager.GetImage("Resources.Resources.4inima.jpg")},
                { "_05trefla", ResourceManager.GetImage("Resources.Resources.5trefla.jpg")},
                { "_05romb", ResourceManager.GetImage("Resources.Resources.5romb.jpg")},
                { "_05frunza", ResourceManager.GetImage("Resources.Resources.5frunza.jpg")},
                { "_05inima", ResourceManager.GetImage("Resources.Resources.5inima.jpg")},
                { "_06trefla", ResourceManager.GetImage("Resources.Resources.6trefla.jpg")},
                { "_06romb", ResourceManager.GetImage("Resources.Resources.6romb.jpg")},
                { "_06frunza", ResourceManager.GetImage("Resources.Resources.6frunza.jpg")},
                { "_06inima", ResourceManager.GetImage("Resources.Resources.6inima.jpg")},
                { "_07trefla", ResourceManager.GetImage("Resources.Resources.7trefla.jpg")},
                { "_07romb", ResourceManager.GetImage("Resources.Resources.7romb.jpg")},
                { "_07frunza", ResourceManager.GetImage("Resources.Resources.7frunza.jpg")},
                { "_07inima", ResourceManager.GetImage("Resources.Resources.7inima.jpg")},
                { "_08trefla", ResourceManager.GetImage("Resources.Resources.8trefla.jpg")},
                { "_08romb", ResourceManager.GetImage("Resources.Resources.8romb.jpg")},
                { "_08frunza", ResourceManager.GetImage("Resources.Resources.8frunza.jpg")},
                { "_08inima", ResourceManager.GetImage("Resources.Resources.8inima.jpg")},
                { "_09trefla", ResourceManager.GetImage("Resources.Resources.9trefla.jpg")},
                { "_09romb", ResourceManager.GetImage("Resources.Resources.9romb.jpg")},
                { "_09frunza", ResourceManager.GetImage("Resources.Resources.9frunza.jpg")},
                { "_09inima", ResourceManager.GetImage("Resources.Resources.9inima.jpg")},
                { "_10trefla", ResourceManager.GetImage("Resources.Resources.10trefla.jpg")},
                { "_10romb", ResourceManager.GetImage("Resources.Resources.10romb.jpg")},
                { "_10frunza", ResourceManager.GetImage("Resources.Resources.10frunza.jpg")},
                { "_10inima", ResourceManager.GetImage("Resources.Resources.10inima.jpg")},
                { "_15trefla", ResourceManager.GetImage("Resources.Resources.atrefla.jpg")},
                { "_15romb", ResourceManager.GetImage("Resources.Resources.aromb.jpg")},
                { "_15frunza", ResourceManager.GetImage("Resources.Resources.afrunza.jpg")},
                { "_15inima", ResourceManager.GetImage("Resources.Resources.ainima.jpg")},
                { "_12trefla", ResourceManager.GetImage("Resources.Resources.jtrefla.jpg")},
                { "_12romb", ResourceManager.GetImage("Resources.Resources.jromb.jpg")},
                { "_12frunza", ResourceManager.GetImage("Resources.Resources.jfrunza.jpg")},
                { "_12inima", ResourceManager.GetImage("Resources.Resources.jinima.jpg")},
                { "_13trefla", ResourceManager.GetImage("Resources.Resources.qtrefla.jpg")},
                { "_13romb", ResourceManager.GetImage("Resources.Resources.qromb.jpg")},
                { "_13frunza", ResourceManager.GetImage("Resources.Resources.qfrunza.jpg")},
                { "_13inima", ResourceManager.GetImage("Resources.Resources.qinima.jpg")},
                { "_14trefla", ResourceManager.GetImage("Resources.Resources.ktrefla.jpg")},
                { "_14romb", ResourceManager.GetImage("Resources.Resources.kromb.jpg")},
                { "_14frunza", ResourceManager.GetImage("Resources.Resources.kfrunza.jpg")},
                { "_14inima", ResourceManager.GetImage("Resources.Resources.kinima.jpg")}
            };
        }
        public Dictionary<string, Image> Images
        {
            get { return images; }
        }

        // Gets or sets the bet value.
        public int BetValue
        {
            get { return betValue.BetValue; }
            set { betValue.BetValue = value; }
        }

        // Calculates the winnings for a round of the game.
        public int CalculateWinnings(string firstImg, string secondImg)
        {
            return betValue.GetThePrize(firstImg, secondImg, Option);
        }

        // Removes a card from the game.
        public void RemoveCard(string img)
        {
            if (images.ContainsKey(img))
            {
                images.Remove(img);
            }
        }

        // Draws a random card.
        // This method uses the random number generator to draw a random card from the remaining cards in the images dictionary.
        public KeyValuePair<string, Image> GetRandomImage()
        {
            int index = random.Next(images.Count);
            return images.ElementAt(index);
        }
    }
}