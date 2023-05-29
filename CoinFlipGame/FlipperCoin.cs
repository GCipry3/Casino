/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The FlipperCoin class models a coin that displays an animation during the flip. 
 * The class implements the ICoin interface, defining methods for performing a coin flip, 
 * and retrieving the current image and result of the flip.
 */

using System;
using System.Collections.Generic;
using System.Drawing;

namespace CoinFlipGame
{
    public class FlipperCoin : ICoin
    {
        private readonly List<Image> coinImages;
        private Image imageHead;
        private Image imageTail;
        private Image currentImage;
        private string currentResult;

        // Constructor: Initializes the FlipperCoin with the given coin images and head/tail images
        public FlipperCoin(List<Image> coinImages, Image imageHead, Image imageTail)
        {
            this.coinImages = coinImages;
            this.imageHead = imageHead;
            this.imageTail = imageTail;
        }

        // Performs a coin flip and returns a list of images for animation
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

        // Returns the current image of the coin
        public Image GetImage()
        {
            return currentImage;
        }

        // Returns the current result of the coin flip ("Heads" or "Tails")
        public string GetResult()
        {
            return currentResult;
        }
    }
}
