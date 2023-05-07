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

        protected Dictionary<string, Image> _images;
        protected Bet _bet;
        protected String _winnings;

        public SlotsMachine()
        {
            _bet = new Bet();

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

        public string Winnings
        {
            get { return _winnings; }
            set { _winnings = value; }
        }

        public int Bet
        {
            get { return _bet.BetValue; }
            set { _bet.BetValue = value; }
        }

        public int CalculateWinnings(string firstImg, string secondImg, string thirdImg)
        {
            return _bet.GetThePrize(firstImg, secondImg, thirdImg);
        }
    }
}
