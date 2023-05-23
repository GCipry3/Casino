using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.SlotsGame
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
                {  "_7",Properties.Resources._7},
                { "bananas", Properties.Resources.bananas},
                { "cherries",Properties.Resources.cherries},
                { "lemon",Properties.Resources.lemon},
                { "orange",Properties.Resources.orange},
                { "plum",Properties.Resources.plum},
                { "strawberry",Properties.Resources.strawberry},
                { "watermelon", Properties.Resources.watermelon}
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

        public KeyValuePair<string,Image> GetRandomImage()
        {
            int index = random.Next(_images.Count);
            return _images.ElementAt(index);
        }
    }
}
