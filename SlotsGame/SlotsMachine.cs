using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace SlotsGame
{
    internal class SlotsMachine : ISlotsMachine
    {

        readonly Random random = new Random();
        Dictionary<string, Image> images;
        Bet betValue;

        public SlotsMachine()
        {
            betValue = new Bet();

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

        public Dictionary<string, Image> Images
        {
            get { return images; }
        }

        public int BetValue
        {
            get { return betValue.BetValue; }
            set { betValue.BetValue = value; }
        }

        public int CalculateWinnings(string firstImg, string secondImg, string thirdImg)
        {
            return betValue.GetThePrize(firstImg, secondImg, thirdImg);
        }

        public KeyValuePair<string, Image> GetRandomImage()
        {
            int index = random.Next(images.Count);
            return images.ElementAt(index);
        }
    }
}
