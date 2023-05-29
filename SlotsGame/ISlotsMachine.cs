/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This interface defines the contract for a slot machine game
 *
*/
using System.Collections.Generic;
using System.Drawing;

namespace SlotsGame
{
    public interface ISlotsMachine
    {
        // Property to get images dictionary, which contains all the symbols that can appear on the slot machine
        Dictionary<string, Image> Images { get; }

        // Property to get or set the current bet value
        int BetValue { get; set; }

        // Method to calculate the winnings based on the symbols that appear
        int CalculateWinnings(string firstImg, string secondImg, string thirdImg);

        // Method to get a random image (symbol) that will appear on the slot machine
        KeyValuePair<string, Image> GetRandomImage();
    }
}
