﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal class CoinFactory : ICoinFactory
    {
        private string _coinType;

        public CoinFactory(string coinType)
        {
            _coinType = coinType;
        }

        public ICoin CreateCoin()
        {
            switch (_coinType)
            {
                case "MockCoin":
                    return new MockCoin(Properties.Resources.coinHeads, Properties.Resources.coinTails);
                case "FlipperCoin":
                    var images = new List<Image> {};
                    for (int i=0; i < 10; i++)
                    {
                        images.Add(Properties.Resources.coinHeads);
                        images.Add(Properties.Resources.coinTails);
                    }
                    return new FlipperCoin(images, Properties.Resources.coinHeads, Properties.Resources.coinTails);

                default:
                    return new MockCoin(Properties.Resources.coinHeads, Properties.Resources.coinTails);
            }
        }
    }
}
