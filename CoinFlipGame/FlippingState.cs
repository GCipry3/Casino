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
            if (coinFlip.CurrentFrame < coinFlip.CoinFrames.Count)
            {
                coinFlip.PictureBoxCoin.Image = coinFlip.CoinFrames[coinFlip.CurrentFrame++];
            }
            else
            {
                coinFlip.TimerFlip.Stop();
                coinFlip.FlippingFlag = false;
                coinFlip.CurrentFrame = 0;
                coinFlip.PictureBoxCoin.Image = coinFlip.Coin.GetImage();
                coinFlip.UpdateResult();
            }
        }
    }
}
