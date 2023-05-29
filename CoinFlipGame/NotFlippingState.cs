using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public class NotFlippingState : CoinState
    {
        public NotFlippingState(CoinFlip coinFlip) : base(coinFlip) { }

        public override void FlipCoin()
        {
            // Check if the user has selected a coin face
            string selectedCoinFace = coinFlip.comboBoxCoinFace.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCoinFace))
            {
                coinFlip.bunifuLabelResult.Text = "You have to choose the coin face, Heads or Tails";
                return;
            }

            // Flip the coin
            coinFlip.coinFrames = coinFlip.coin.Flip();
            coinFlip.flippingFlag = true;
            coinFlip.bunifuLabelResult.Text = "";
            coinFlip.timerFlip.Start(); // Start the Timer to handle the animation

            coinFlip.state = new FlippingState(coinFlip); // State changed to FlippingState when coin starts flipping
        }

        public override void Tick()
        {
            // No operation
        }
    }
}
