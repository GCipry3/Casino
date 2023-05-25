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
        string option;
        BetHigherLower _betValue;
        Dictionary<string, Image> _images;

        public HigherLowerGame()
        {
            random = new Random();
            _betValue = new BetHigherLower();
            _images = new Dictionary<string, Image>()
            {
                { "_02trefla", Properties.Resources._2trefla},
                { "_02romb", Properties.Resources._2romb},
                { "_02frunza", Properties.Resources._2frunza },
                { "_02inima", Properties.Resources._2inima },
                { "_03trefla", Properties.Resources._3trefla },
                { "_03romb", Properties.Resources._3romb },
                { "_03frunza", Properties.Resources._3frunza },
                { "_03inima", Properties.Resources._3inima },
                { "_04trefla", Properties.Resources._4trefla },
                { "_04romb", Properties.Resources._4romb },
                { "_04frunza", Properties.Resources._4frunza },
                { "_04inima", Properties.Resources._4inima },
                { "_05trefla", Properties.Resources._5trefla },
                { "_05romb", Properties.Resources._5romb },
                { "_05frunza", Properties.Resources._5frunza },
                { "_05inima", Properties.Resources._5inima },
                { "_06trefla", Properties.Resources._6trefla },
                { "_06romb", Properties.Resources._6romb },
                { "_06frunza", Properties.Resources._6frunza },
                { "_06inima", Properties.Resources._6inima },
                { "_07trefla", Properties.Resources._7trefla },
                { "_07romb", Properties.Resources._7romb },
                { "_07frunza", Properties.Resources._7frunza },
                { "_07inima", Properties.Resources._7inima },
                { "_08trefla", Properties.Resources._8trefla },
                { "_08romb", Properties.Resources._8romb },
                { "_08frunza", Properties.Resources._8frunza },
                { "_08inima", Properties.Resources._8inima },
                { "_09trefla", Properties.Resources._9trefla },
                { "_09romb", Properties.Resources._9romb },
                { "_09frunza", Properties.Resources._9frunza },
                { "_09inima", Properties.Resources._9inima },
                { "_10trefla", Properties.Resources._10trefla },
                { "_10romb", Properties.Resources._10romb },
                { "_10frunza", Properties.Resources._10frunza },
                { "_10inima", Properties.Resources._10inima },
                { "_15trefla", Properties.Resources.atrefla },
                { "_15romb", Properties.Resources.aromb },
                { "_15frunza", Properties.Resources.afrunza },
                { "_15inima", Properties.Resources.ainima },
                { "_12trefla", Properties.Resources.jtrefla },
                { "_12romb", Properties.Resources.jromb },
                { "_12frunza", Properties.Resources.jfrunza },
                { "_12inima", Properties.Resources.jinima },
                { "_13trefla", Properties.Resources.qtrefla },
                { "_13romb", Properties.Resources.qromb },
                { "_13frunza", Properties.Resources.qfrunza },
                { "_13inima", Properties.Resources.qinima },
                { "_14trefla", Properties.Resources.ktrefla },
                { "_14romb", Properties.Resources.kromb },
                { "_14frunza", Properties.Resources.kfrunza },
                { "_14inima", Properties.Resources.kinima }
            };
        }

        public string Option
        {
            get { return option; }
            set { option = value; }
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

        public int CalculateWinnings(string firstImg, string secondImg)
        {
            return _betValue.GetThePrize(firstImg, secondImg, option);
        }
        public void GetItOut(string img)
        {
            if(_images.ContainsKey(img))
            {
                _images.Remove(img);
            }
        }

        public KeyValuePair<string, Image> GetRandomImage()
        {
            int index = random.Next(_images.Count);
            return _images.ElementAt(index);
        }
    }
}
