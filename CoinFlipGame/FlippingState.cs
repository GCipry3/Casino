using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public class FlippingState : CoinState
    {
        public FlippingState(CoinFlip coinFlip) : base(coinFlip) { }

        public override void FlipCoin()
        {
            // No operation
        }

        public override void Tick()
        {
            if (coinFlip.currentFrame < coinFlip.coinFrames.Count)
            {
                coinFlip.pictureBoxCoin.Image = coinFlip.coinFrames[coinFlip.currentFrame++];
            }
            else
            {
                coinFlip.timerFlip.Stop();
                coinFlip.flippingFlag = false;
                coinFlip.currentFrame = 0;
                coinFlip.pictureBoxCoin.Image = coinFlip.coin.GetImage();
                coinFlip.UpdateResult();
            }
        }
    }
}
