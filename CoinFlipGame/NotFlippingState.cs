/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The NotFlippingState class represents the state where the coin in the CoinFlip game is not flipping.
 * It's part of the State design pattern implementation and defines the specific behaviors for the "not flipping" state.
 * In this state, you can initiate a coin flip. If the coin is flipping, no operation is done on tick event.
 * 
 * Design Pattern: State
 * 
*/

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
