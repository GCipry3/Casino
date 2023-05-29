/*
 * Created by: Ohriniuc Claudiu-Constantin
 *
 * Functionality: This represents the interface for the bet of the HigherLower game
 *
*/
namespace HigherLowerGame
{
    internal interface IBetHigherLower
    {
        // The value of the current bet.
        int BetValue { get; set; }

        // This function calculates and returns the prize based on the first and second image, and the player's bet option.
        int GetThePrize(string firstImg, string secondImg, string option);
    }
}
