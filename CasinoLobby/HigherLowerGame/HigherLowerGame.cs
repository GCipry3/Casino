using CasinoLobby.SlotsGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.HigherLowerGame
{
    internal class HigherLowerGame
    {
        Random random;
        Bet _betValue;
        Dictionary<string, Image> _images;

        public HigherLowerGame()
        {
            random = new Random();
            _betValue = new Bet();
            _images = new Dictionary<string, Image>()
            {
                { "_2trefla", Properties.Resources._2trefla},
                { "_2romb", Properties.Resources._2romb},
                { "_2frunza", Properties.Resources._2frunza },
                { "_2inima", Properties.Resources._2inima },
                { "_3trefla", Properties.Resources._3trefla },
                { "_3romb", Properties.Resources._3romb },
                { "_3frunza", Properties.Resources._3frunza },
                { "_3inima", Properties.Resources._3inima },
                { "_4trefla", Properties.Resources._4trefla },
                { "_4romb", Properties.Resources._4romb },
                { "_4frunza", Properties.Resources._4frunza },
                { "_4inima", Properties.Resources._4inima },
                { "_5trefla", Properties.Resources._5trefla },
                { "_5romb", Properties.Resources._5romb },
                { "_5frunza", Properties.Resources._5frunza },
                { "_5inima", Properties.Resources._5inima },
                { "_6trefla", Properties.Resources._6trefla },
                { "_6romb", Properties.Resources._6romb },
                { "_6frunza", Properties.Resources._6frunza },
                { "_6inima", Properties.Resources._6inima },
                { "_7trefla", Properties.Resources._7trefla },
                { "_7romb", Properties.Resources._7romb },
                { "_7frunza", Properties.Resources._7frunza },
                { "_7inima", Properties.Resources._7inima },
                { "_8trefla", Properties.Resources._8trefla },
                { "_8romb", Properties.Resources._8romb },
                { "_8frunza", Properties.Resources._8frunza },
                { "_8inima", Properties.Resources._8inima },
                { "_9trefla", Properties.Resources._9trefla },
                { "_9romb", Properties.Resources._9romb },
                { "_9frunza", Properties.Resources._9frunza },
                { "_9inima", Properties.Resources._9inima },
                { "_10trefla", Properties.Resources._10trefla },
                { "_10romb", Properties.Resources._10romb },
                { "_10frunza", Properties.Resources._10frunza },
                { "_10inima", Properties.Resources._10inima },
                { "atrefla", Properties.Resources.atrefla },
                { "aromb", Properties.Resources.aromb },
                { "afrunza", Properties.Resources.afrunza },
                { "ainima", Properties.Resources.ainima },
                { "jtrefla", Properties.Resources.jtrefla },
                { "jromb", Properties.Resources.jromb },
                { "jfrunza", Properties.Resources.jfrunza },
                { "jinima", Properties.Resources.jinima },
                { "qtrefla", Properties.Resources.qtrefla },
                { "qromb", Properties.Resources.qromb },
                { "qfrunza", Properties.Resources.qfrunza },
                { "qinima", Properties.Resources.qinima },
                { "ktrefla", Properties.Resources.ktrefla },
                { "kromb", Properties.Resources.kromb },
                { "kfrunza", Properties.Resources.kfrunza }
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
