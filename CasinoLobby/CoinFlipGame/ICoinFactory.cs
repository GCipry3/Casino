using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal interface ICoinFactory
    {
        ICoin CreateCoin();
    }
}
