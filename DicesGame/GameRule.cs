using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesGame
{
    public class GameRule
    {
        public string higher_rule = "Game Rule: You must roll a total higher than the House's roll to win.";
        public string lower_rule = "Game Rule: You must roll a total lower than the House's roll to win.";
        public GameRule() { 
            CurrentRule= higher_rule;
        }
        public string CurrentRule { get; private set; }

        //changes the game rule
        public void ChangeGameRule()
        {
            CurrentRule = CurrentRule == lower_rule? higher_rule : lower_rule;
        }

        //checks who won
        public int GetWinner(int HouseRollResult, int FaderRollResult)
        {
            if (HouseRollResult == FaderRollResult)
            {
                return 0;
            }
            else if (CurrentRule == lower_rule)
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
