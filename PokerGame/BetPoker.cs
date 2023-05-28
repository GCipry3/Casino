using System;
using System.Linq;

namespace PokerGame
{
    internal class BetPoker : IBetPoker
    {
        private const int RoyalFlushMultiplier = 500;
        private const int StraightFlushMultiplier = 300;
        private const int FlushMultiplier = 200;
        private const int StraightMultiplier = 125;
        private const int FourOfKindMultiplier = 100;
        private const int FullHouseMultiplier = 75;
        private const int ThreeOfKindMultiplier = 50;
        private const int TwoPairsMultiplier = 30;
        private const int PairMultiplier = 2;

        // Property to store the bet value
        public int BetValue { get; set; }

        // Method to calculate the prize based on the hand of cards
        public int GetThePrize(string[] images)
        {
            // Arrays to store the parsed card data
            int[] cards = new int[5];
            string[] colors = new string[5];

            // Parse the image strings into card and color arrays
            ParseImages(images, cards, colors);

            // Check for various winning hand types and calculate prize accordingly
            // The ordering is important here, checking for the most valuable hands first
            if (IsFlush(colors) && IsStraight(cards))
            {
                // Check for royal flush
                return cards[4] == 15 ? BetValue * RoyalFlushMultiplier : BetValue * StraightFlushMultiplier;
            }
            else if (IsFlush(colors))
            {
                return BetValue * FlushMultiplier;
            }
            else if (IsStraight(cards))
            {
                // Check for straight flush
                return cards[4] == 15 ? BetValue * StraightFlushMultiplier : BetValue * StraightMultiplier;
            }
            else if (HasFourOfKind(cards))
            {
                return BetValue * FourOfKindMultiplier;
            }
            else if (HasFullHouse(cards))
            {
                return BetValue * FullHouseMultiplier;
            }
            else if (HasThreeOfKind(cards))
            {
                return BetValue * ThreeOfKindMultiplier;
            }
            else if (HasTwoPairs(cards))
            {
                return BetValue * TwoPairsMultiplier;
            }
            else if (HasPair(cards))
            {
                return BetValue * PairMultiplier;
            }

            // No winning hand
            return 0;
        }

        // Method to parse the image strings into separate arrays for card values and colors
        private void ParseImages(string[] images, int[] cards, string[] colors)
        {
            for (int i = 0; i < images.Length; i++)
            {
                try
                {
                    colors[i] = images[i].Substring(3);
                    cards[i] = int.Parse(images[i].Substring(1, 2));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing card value or suit: " + ex.Message);
                    throw;
                }
            }
        }

        // Check if all cards are of the same color
        private bool IsFlush(string[] colors) =>
            Enumerable.Range(1, colors.Length - 1).All(i => colors[i] == colors[0]);

        // Check if the cards form a continuous sequence
        private bool IsStraight(int[] cards) =>
            Enumerable.Range(1, cards.Length - 1).All(i => cards[i] == cards[i - 1] + 1);

        // Check for four cards of the same value
        private bool HasFourOfKind(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 4);

        // Check for three cards of the same value and two cards of another value
        private bool HasFullHouse(int[] cards) =>
            cards.GroupBy(c => c).Count() == 2 && cards.GroupBy(c => c).Any(g => g.Count() == 3);

        // Check for three cards of the same value
        private bool HasThreeOfKind(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 3);

        // Check for two pairs
        private bool HasTwoPairs(int[] cards) =>
            cards.GroupBy(c => c).Count(g => g.Count() == 2) == 2;

        // Check for a pair
        private bool HasPair(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 2);
    }
}
