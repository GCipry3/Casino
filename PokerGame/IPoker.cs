using System.Collections.Generic;
using System.Drawing;

namespace PokerGame
{
    // This interface represents the functionality of a poker game
    public interface IPoker
    {
        // This property represents the current bet value. It can be set and retrieved
        int BetValue { get; set; }

        // This property provides access to the current images (representing cards) in the game
        Dictionary<string, Image> Images { get; }

        // This method calculates the winnings based on the provided images (representing a poker hand)
        int CalculateWinnings(string[] images);

        // This method adds a card (represented by an image) to the game
        void AddCard(string img, Image image);

        // This method removes a card (represented by an image) from the game
        void RemoveCard(string img);

        // This method returns a random image (representing a card) from the current game
        KeyValuePair<string, Image> GetRandomImage();

        // This method renews the deck (i.e., resets the game state)
        void RenewDeck();
    }
}
