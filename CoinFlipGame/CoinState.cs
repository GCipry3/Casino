/*
 * Created by: Galbeaza Ciprian
 * 
 * Functionality: 
 * The CoinState class is an abstract class that sets up the framework for states in a CoinFlip game.
 * This class is integral to implementing the State Design Pattern, offering methods to flip the coin and perform a tick action.
 */

namespace CoinFlipGame
{
    public abstract class CoinState
    {
        // CoinFlip game instance
        protected CoinFlip coinFlip;

        // Constructor sets the CoinFlip game instance
        public CoinState(CoinFlip coinFlip)
        {
            this.coinFlip = coinFlip;
        }

        // Abstract method to flip the coin - must be implemented by subclasses
        public abstract void FlipCoin();

        // Abstract method to perform a tick action - must be implemented by subclasses
        public abstract void Tick();
    }
}
