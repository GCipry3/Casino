/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The FlippingState class models the flipping state of the coin in the CoinFlip game, 
 * implementing the abstract CoinState class. This class handles coin flipping animation 
 * and its completion.
 * 
 * Design Pattern: State
 */

namespace CoinFlipGame
{
    public class FlippingState : CoinState
    {
        // Constructor: Initializes the FlippingState with a CoinFlip object
        public FlippingState(CoinFlip coinFlip) : base(coinFlip) { }

        // Ignored during the flipping state
        public override void FlipCoin()
        {
            // No operation
        }

        // Handles animation updates and completion
        public override void Tick()
        {
            if (coinFlip.currentFrame < coinFlip.coinFrames.Count)
            {
                // If the animation is not finished, update the coin's image
                coinFlip.pictureBoxCoin.Image = coinFlip.coinFrames[coinFlip.currentFrame++];
            }
            else
            {
                // If the animation is finished, stop the timer, update the result, and reset variables
                coinFlip.currentFrame = 0;
                coinFlip.flippingFlag = false;

                coinFlip.pictureBoxCoin.Image = coinFlip.coin.GetImage();
                coinFlip.timerFlip.Stop();
                coinFlip.UpdateResult();
            }
        }
    }
}
