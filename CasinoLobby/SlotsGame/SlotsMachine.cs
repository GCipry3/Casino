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

        protected List<Image> _images;
        protected Bet _bet;
        protected String _winnings;

        public SlotsMachine()
        {
            _bet = new Bet();

            _images = new List<Image>()
            {
                Properties.Resources._7,
                Properties.Resources.bananas,
                Properties.Resources.cherries,
                Properties.Resources.lemon,
                Properties.Resources.orange,
                Properties.Resources.plum,
                Properties.Resources.strawberry,
                Properties.Resources.watermelon
            };
        }

        public List<Image> Images
        {
            get { return _images; }
            set { _images = value; }
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
