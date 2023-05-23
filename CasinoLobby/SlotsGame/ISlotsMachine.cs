using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasinoLobby.SlotsGame
{
    public interface ISlotsMachine
    {
        Dictionary<string, Image> Images { get; }
        int BetValue { get; set; }

        int CalculateWinnings(string firstImg, string secondImg, string thirdImg);

        KeyValuePair<string, Image> GetRandomImage();
    }
}