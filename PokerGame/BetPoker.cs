using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class BetPoker : IBetPoker
    {
        public BetPoker()
        {
        }

        public int BetValue { get; set; }

        public int GetThePrize(string[] images)
        {
            int[] cards = new int[5];
            string[] colors = new string[5];
            ParseImages(images, cards, colors);
            Array.Sort(cards);

            if (IsFlush(colors))
            {
                if (IsStraight(cards))
                {
                    return cards[4] == 15 ? BetValue * 500 : BetValue * 300;
                }
                return BetValue * 200;
            }
            else if (IsStraight(cards))
            {
                return cards[4] == 15 ? BetValue * 200 : BetValue * 125;
            }
            else if (HasFourOfKind(cards))
            {
                return BetValue * 100;
            }
            else if (HasFullHouse(cards))
            {
                return BetValue * 75;
            }
            else if (HasThreeOfKind(cards))
            {
                return BetValue * 50;
            }
            else if (HasTwoPairs(cards))
            {
                return BetValue * 30;
            }
            else if (HasPair(cards))
            {
                return BetValue * 5;
            }

            return 0;
        }

        private void ParseImages(string[] images, int[] cards, string[] colors)
        {
            for (int i = 0; i < images.Length; i++)
            {
                if (images[i].Length >= 4)
                {
                    colors[i] = images[i].Substring(3);
                    cards[i] = int.Parse(images[i].Substring(1, 2));
                }
            }
        }

        private bool IsFlush(string[] colors) =>
            Enumerable.Range(1, colors.Length - 1).All(i => colors[i] == colors[0]);

        private bool IsStraight(int[] cards) =>
            Enumerable.Range(1, cards.Length - 1).All(i => cards[i] == cards[i - 1] + 1);

        private bool HasFourOfKind(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 4);

        private bool HasFullHouse(int[] cards) =>
            cards.GroupBy(c => c).Count() == 2 && cards.GroupBy(c => c).Any(g => g.Count() == 3);

        private bool HasThreeOfKind(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 3);

        private bool HasTwoPairs(int[] cards) =>
            cards.GroupBy(c => c).Count(g => g.Count() == 2) == 2;

        private bool HasPair(int[] cards) =>
            cards.GroupBy(c => c).Any(g => g.Count() == 2);
    }
}
