using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.CoinFlipGame
{
    internal interface ICoin
    {
        List<Image> Flip(); // Flips the coin
        Image GetImage(); // Returns the current image of the coin
        string GetResult(); // Returns the current result of the coin flip (Heads or Tails)
    }
}
