using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoLobby.SlotsGame
{
    internal class Bet
    {
        int betValue;
            
        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }
        public Bet()
        {}

        public int GetThePrize(string firstImg, string secondImg, string thirdImg)
        {
            if (((firstImg == secondImg) && (firstImg == "_7")) || ((secondImg==thirdImg) && (thirdImg == "_7")))
            {
                if(firstImg == thirdImg)
                {
                    betValue *= 25;
                }
                else
                {
                    betValue *= 5;
                }
            }
            else
            {
                if ((firstImg == secondImg) || (secondImg == thirdImg))
                {
                    if (firstImg == thirdImg)
                    {
                        betValue *= 10;
                    }
                    else
                    {
                        betValue *= 2;
                    }
                }
                else
                {
                    betValue = 0;
                }
            }
            return betValue; 
        }
    }
}
