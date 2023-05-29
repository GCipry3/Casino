/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The CoinFactory class is responsible for creating instances of coins, which is a part of the Factory Design Pattern.
 * Depending on the coinType parameter passed, it creates and returns an object of the corresponding coin type.
 */

using System.Collections.Generic;
using System.Drawing;

namespace CoinFlipGame
{
    public class CoinFactory : ICoinFactory
    {
        private string coinType;

        public CoinFactory(string coinType)
        {
            // Coin type to be created
            this.coinType = coinType;
        }

        public ICoin CreateCoin()
        {
            // Load images for the heads and tails of the coin
            Image imageHead = Resources.ResourceManager.GetImage("Resources.Resources.coinHeads.png");
            Image imageTail = Resources.ResourceManager.GetImage("Resources.Resources.coinTails.png");

            // Depending on the coinType, create and return the corresponding coin object
            switch (coinType)
            {
                case "MockCoin":
                    return new MockCoin(imageHead, imageTail);

                case "FlipperCoin":
                    var images = new List<Image> { };
                    for (int i = 0; i < 10; i++)
                    {
                        images.Add(imageHead);
                        images.Add(imageTail);
                    }
                    return new FlipperCoin(images, imageHead, imageTail);

                default:
                    // If coinType is not recognized, return a MockCoin
                    return new MockCoin(imageHead, imageTail);
            }
        }
    }
}
