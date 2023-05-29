/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The MockCoin class is part of the CoinFlip game. It simulates a coin that doesn't actually flip - instead, it instantly shows one of the coin sides (heads or tails). 
 * This class is particularly useful for testing scenarios where a real flipping animation is not necessary or practical.
 * 
*/

using System;
using System.Collections.Generic;
using System.Drawing;

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
