using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SlotsGame
{
    public interface ISlotsMachine
    {
        Dictionary<string, Image> Images { get; }
        int BetValue { get; set; }

        int CalculateWinnings(string firstImg, string secondImg, string thirdImg);

        KeyValuePair<string, Image> GetRandomImage();
    }
}
