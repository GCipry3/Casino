/*
 * Created by: Farcas Cosmin Catalin 
 *
 * Functionality: Calculates the total value of the current hand
 *
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public class BlackJackBetHandler
    {
        //calculates the total value 
        public int GetScore(List<int> cardsValue)
        {
            int score = 0;
            int aceCount = 0;
            foreach (int cardValue in cardsValue)
            {
                if (cardValue <= 11)
                {
                    if (cardValue == 11)
                        aceCount++;
                    score += cardValue;
                }
                else
                {
                    score += 10;
                }
            }
            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }
            return score;
        }
    }
}
