using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal class MockCoin : ICoin
    {
        private Image _imageHead;
        private Image _imageTail;
        private Image _currentImage;
        private string _currentResult;

        public MockCoin()
        {
            _imageHead = Properties.Resources.coinHeads;
            _imageTail = Properties.Resources.coinTails;
        }

        public void Flip()
        {
            Random random = new Random();
            int coinSide = random.Next(0, 2); // 0 for heads, 1 for tails

            if (coinSide == 0)
            {
                _currentImage = _imageHead;
                _currentResult = "Heads";
            }
            else
            {
                _currentImage = _imageTail;
                _currentResult = "Tails";
            }
        }

        public Image GetImage()
        {
            return _currentImage;
        }

        public string GetResult()
        {
            return _currentResult;
        }
    }
}
