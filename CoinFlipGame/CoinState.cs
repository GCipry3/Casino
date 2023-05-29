using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public abstract class CoinState
    {
        protected CoinFlip coinFlip;

        public CoinState(CoinFlip coinFlip)
        {
            this.coinFlip = coinFlip;
        }

        public abstract void FlipCoin();
        public abstract void Tick();
    }
}
