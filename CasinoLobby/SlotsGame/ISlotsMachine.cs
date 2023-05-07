using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasinoLobby.SlotsGame
{
    public interface ISlotsMachine
    {
        int CalculateWinnings(string firstImg, string secondImg, string thirdImg);
    }
}