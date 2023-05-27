namespace PokerGame
{
    internal interface IBetPoker
    {
        int BetValue { get; set; }

        int GetThePrize(string[] images);
    }
}