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
            string selectedCoinFace = coinFlip.ComboBoxCoinFace.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCoinFace))
            {
                coinFlip.BunifuLabelResult.Text = "You have to choose the coin face, Heads or Tails";
                return;
            }

            // Flip the coin
            coinFlip.CoinFrames = coinFlip.Coin.Flip();
            coinFlip.FlippingFlag = true;
            coinFlip.BunifuLabelResult.Text = "";
            coinFlip.TimerFlip.Start(); // Start the Timer to handle the animation
        }

        public override void Tick()
        {
            // No operation
        }
    }
}
