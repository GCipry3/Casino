using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CoinFlipGame
{
    public class CoinFactory : ICoinFactory
    {
        private string coinType;

        public CoinFactory(string coinType)
        {
            this.coinType = coinType;
        }

        public ICoin CreateCoin()
        {
            Image imageHead = Resources.ResourceManager.GetImage("Resources.Resources.coinHeads.png");
            Image imageTail = Resources.ResourceManager.GetImage("Resources.Resources.coinTails.png");
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
                    return new MockCoin(imageHead, imageTail);
            }
        }
    }
}
