using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal class FlipperCoin : ICoin
    {
        private readonly List<Image> coinImages ;
        private Image imageHead;
        private Image imageTail;
        private Image currentImage;
        private string currentResult;

        public FlipperCoin(List<Image> coinImages, Image imageHead, Image imageTail)
        {
            this.coinImages = coinImages;
            this.imageHead = imageHead;
            this.imageTail = imageTail;
        }

        public List<Image> Flip()
        {
            Random random = new Random();
            int coinSide = random.Next(0, 2); // 0 for heads, 1 for tails

            currentImage = (coinSide == 0) ? imageHead : imageTail;
            currentResult = (coinSide == 0) ? "Heads" : "Tails";

            List<Image> animatedImages = new List<Image>(coinImages);
            animatedImages.Add(currentImage); // Add the final image (head or tail) to the list

            return animatedImages;
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
