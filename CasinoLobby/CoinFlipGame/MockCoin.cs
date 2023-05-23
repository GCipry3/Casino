using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    public class MockCoin : ICoin
    {
        private Image imageHead;
        private Image imageTail;
        private Image currentImage;
        private string currentResult;
        public MockCoin()
        {
            imageHead = Properties.Resources.coinHeads;
            imageTail = Properties.Resources.coinTails;
        }
        public MockCoin(Image imageHead, Image imageTail)
        {
            this.imageHead = imageHead;
            this.imageTail = imageTail;
        }

        public List<Image> Flip()
        {
            Random random = new Random();
            int coinSide = random.Next(0, 2); // 0 for heads, 1 for tails

            currentImage = (coinSide == 0) ? imageHead : imageTail;
            currentResult = (coinSide == 0) ? "Heads" : "Tails";
            
            return new List<Image> { currentImage };
        }

        public Image GetImage()
        {
            return currentImage;
        }

        public string GetResult()
        {
            return currentResult;
        }
    }
}
