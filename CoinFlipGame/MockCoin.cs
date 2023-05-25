using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Resources;

namespace CoinFlipGame
{
    public class MockCoin : ICoin
    {
        private Image imageHead;
        private Image imageTail;
        private Image currentImage;
        private string currentResult;
        public MockCoin()
        {
            imageHead = Resources.ResourceManager.GetImage("Resources.Resources.coinHeads.png");
            imageTail = Resources.ResourceManager.GetImage("Resources.Resources.coinTails.png");
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
