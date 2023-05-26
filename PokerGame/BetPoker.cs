using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class BetPoker
    {
        int betValue;

        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }
        public BetPoker()
        { }

        //this function calculates the prize the player will get
        public int GetThePrize(string firstImg, string secondImg, string thirdImage, string fourthImage, string fifthImage)
        {
            int []cards = new int[5];
            string[] colors = new string[5];
            
            if (firstImg.Length >= 4)
            {
                colors[0] = firstImg.Substring(3);
                firstImg = firstImg.Substring(1, 2);
                cards[0] = int.Parse(firstImg); ;
            }
            if (secondImg.Length >= 4)
            {
                colors[1] = secondImg.Substring(3);
                secondImg = secondImg.Substring(1, 2);
                cards[1] = int.Parse(secondImg);
            }
            if (thirdImage.Length >= 4)
            {
                colors[2] = thirdImage.Substring(3);
                thirdImage = thirdImage.Substring(1, 2);
                cards[2] = int.Parse(thirdImage);
            }
            if (fourthImage.Length >= 4)
            {
                colors[3] = fourthImage.Substring(3);
                fourthImage = fourthImage.Substring(1, 2);
                cards[3] = int.Parse(fourthImage);
            }
            if (fifthImage.Length >= 4)
            {
                colors[4] = fifthImage.Substring(3);
                fifthImage = fifthImage.Substring(1, 2);
                cards[4] = int.Parse(fifthImage);
            }

            Array.Sort(cards);

            if ((colors[0] == colors[1]) && (colors[1] == colors[2]) && (colors[2] == colors[3]) && (colors[3] == colors[4]))
            {
                if ((cards[1] == cards[0] + 1) && (cards[2] == cards[1] + 1) && (cards[3] == cards[2] + 1) && (cards[4] == cards[3] + 1))
                {
                    if (cards[4] == 15)
                    {
                        return betValue * 500;
                    }
                    else
                    {
                        return betValue * 250;
                    }
                }
                else
                {
                    return betValue * 100;
                }
            }
            else
            {
                if ((cards[1] == cards[0] + 1) && (cards[2] == cards[1] + 1) && (cards[3] == cards[2] + 1) && (cards[4] == cards[3] + 1))
                {
                    if (cards[4] == 15)
                    {
                        return betValue * 200;
                    }
                    else
                    {
                        return betValue * 125;
                    }
                }
                else
                {
                    if (((cards[0] == cards[1]) && (cards[1] == cards[2]) && (cards[2] == cards[3])) || ((cards[1] == cards[2]) && (cards[2] == cards[3]) && (cards[3] == cards[4])))
                    {
                        return betValue * 100;
                    }
                    else
                    {
                        if ((((cards[0] == cards[1]) && (cards[1] == cards[2])) && (cards[3] == cards[4])) || (((cards[2] == cards[3]) && (cards[3] == cards[4])) && (cards[0] == cards[1])))
                        {
                            return betValue * 75;
                        }
                        else
                        {
                            if (((cards[0] == cards[1]) && (cards[1] == cards[2])) || ((cards[1] == cards[2]) && (cards[2] == cards[3])) || ((cards[2] == cards[3]) && (cards[3] == cards[4])))
                            {
                                return betValue * 50;
                            }
                            else
                            {
                                if ((cards[0] == cards[1]) || (cards[1] == cards[2]) || (cards[2] == cards[3]) || (cards[3] == cards[4]))
                                {
                                    return betValue * 25;
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
