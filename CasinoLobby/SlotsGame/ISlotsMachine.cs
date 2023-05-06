using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasinoLobby.SlotsGame
{
    public interface ISlotsMachine
    {
        public int CalculateWinnings(string firstImg, string secondImg, string thirdImg);
    }
}