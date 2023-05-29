/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This interface draws how a HigherLower game should be handled
 *
*/
using System.Collections.Generic;
using System.Drawing;

namespace HigherLowerGame
{
    internal interface IHigherLowerGame
    {
        // The value of the current bet.
        int BetValue { get; set; }

        Dictionary<string, Image> Images { get; }

        // The current option selected by the player, e.g., "higher" or "lower".
        string Option { get; set; }

        // This function calculates the winnings based on the first and second image.
        int CalculateWinnings(string firstImg, string secondImg);

        // This function returns a random image from the available images.
        KeyValuePair<string, Image> GetRandomImage();

        // This function removes a card from the game, given its image name.
        void RemoveCard(string img);
    }
}
