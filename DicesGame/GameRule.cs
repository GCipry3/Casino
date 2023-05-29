using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesGame
{
    public class GameRule
    {
        public string higherRule = "Game Rule: You must roll a total higher than the House's roll to win.";
        public string lowerRule = "Game Rule: You must roll a total lower than the House's roll to win.";
        public GameRule() { 
            CurrentRule= higherRule;
        }
        public string CurrentRule { get; private set; }

        //changes the game rule
        public void ChangeGameRule()
        {
            CurrentRule = CurrentRule == lowerRule? higherRule : lowerRule;
        }

        //checks who won
        public int GetWinner(int HouseRollResult, int FaderRollResult)
        {
            if (HouseRollResult == FaderRollResult)
            {
                return 0;
            }
            else if (CurrentRule == lowerRule)
            {
                return HouseRollResult > FaderRollResult ? 1 : 2;
            }
            else
            {
                return HouseRollResult > FaderRollResult ? 2 : 1;
            }
        }
    }
}
