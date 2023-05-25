using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace SlotsGame
{
    internal class SlotsMachine : ISlotsMachine
    {

        Random random = new Random();
        Dictionary<string, Image> _images;
        Bet _betValue;

        public SlotsMachine()
        {
            _betValue = new Bet();

            _images = new Dictionary<string, Image>()
            {
                {  "_7",Resources.ResourceManager.GetImage("Resources.Resources.7.jpg")},
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
            get { return _images; }
        }

        public int BetValue
        {
            get { return _betValue.BetValue; }
            set { _betValue.BetValue = value; }
        }

        public int CalculateWinnings(string firstImg, string secondImg, string thirdImg)
        {
            return _betValue.GetThePrize(firstImg, secondImg, thirdImg);
        }

        public KeyValuePair<string, Image> GetRandomImage()
        {
            int index = random.Next(_images.Count);
            return _images.ElementAt(index);
        }
    }
}
