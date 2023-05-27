using System.Collections.Generic;
using System.Drawing;

namespace PokerGame
{
    public interface IPoker
    {
        int BetValue { get; set; }
        Dictionary<string, Image> Images { get; }

        int CalculateWinnings(string[] images);
        void GetItIn(string img, Image image);
        void GetItOut(string img);
        KeyValuePair<string, Image> GetRandomImage();
        void RenewDeck();
    }
}