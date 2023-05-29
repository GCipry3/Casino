using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace SlotsGame
{
    // The class implementing the ISlotsMachine interface
    public class SlotsMachine : ISlotsMachine
    {
        // Random generator for selecting images
        readonly Random random = new Random();

        // Dictionary to store image names and corresponding images
        Dictionary<string, Image> images;

        // Represents the current bet value
        Bet betValue;

        // The constructor for the SlotsMachine class
        public SlotsMachine()
        {
            // Instantiate a new Bet object
            betValue = new Bet();

            // Load images into the images dictionary
            images = new Dictionary<string, Image>()
            {
                { "_7",Resources.ResourceManager.GetImage("Resources.Resources.7.jpg")},
                { "bananas", Resources.ResourceManager.GetImage("Resources.Resources.bananas.jpg")},
                { "cherries",Resources.ResourceManager.GetImage("Resources.Resources.cherries.jpg")},
                { "lemon",Resources.ResourceManager.GetImage("Resources.Resources.lemon.jpg")},
                { "orange",Resources.ResourceManager.GetImage("Resources.Resources.orange.jpg")},
                { "plum",Resources.ResourceManager.GetImage("Resources.Resources.plum.jpg")},
                { "strawberry",Resources.ResourceManager.GetImage("Resources.Resources.strawberry.jpg")},
                { "watermelon", Resources.ResourceManager.GetImage("Resources.Resources.watermelon.jpg")}
            };
        }

        // Property to get the images dictionary
        public Dictionary<string, Image> Images
        {
            get { return images; }
        }

        // Property to get and set the bet value
        public int BetValue
        {
            get { return betValue.BetValue; }
            set { betValue.BetValue = value; }
        }

        // Calculate the winnings based on the first, second and third image
        public int CalculateWinnings(string firstImg, string secondImg, string thirdImg)
        {
            return betValue.GetThePrize(firstImg, secondImg, thirdImg);
        }

        // Get a random image from the images dictionary
        public KeyValuePair<string, Image> GetRandomImage()
        {
            // Generate a random index based on predefined probabilities
            int index = random.Next(1, 37);

            // Return an image based on the generated index
            if (index == 1)
            {
                return images.ElementAt(0);
            }
            else if (index >= 2 && index <= 3)
            {
                return images.ElementAt(1);
            }
            else if (index >= 4 && index <= 6)
            {
                return images.ElementAt(2);
            }
            else if (index >= 7 && index <= 10)
            {
                return images.ElementAt(3);
            }
            else if (index >= 11 && index <= 15)
            {
                return images.ElementAt(4);
            }
            else if (index >= 16 && index <= 21)
            {
                return images.ElementAt(5);
            }
            else if (index >= 22 && index <= 28)
            {
                return images.ElementAt(6);
            }
            else if (index >= 29 && index <= 36)
            {
                return images.ElementAt(7);
            }

            // Default return value in case no condition is met (although this will not happen in current setup)
            return images.ElementAt(7);
        }
    }
}
