namespace PokerGame
{
    // This interface represents the functionality of a poker betting game
    internal interface IBetPoker
    {
        // The current bet value. This can be set and retrieved
        int BetValue { get; set; }

        // This method takes an array of card image names, evaluates the resulting hand, 
        // and returns the prize amount based on the current bet and the hand's worth.
        int GetThePrize(string[] images);
    }
}
  