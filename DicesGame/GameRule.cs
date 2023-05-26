using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesGame
{
    internal class GameRule
    {
        public string CurrentRule { get; private set; }

        public void ChangeGameRule()
        {
            if (CurrentRule == "Game Rule: Lesser Than: You must roll a total lower than the House's roll to win.")
            {
                CurrentRule = "Game Rule: Greater Than: You must roll a total higher than the House's roll to win.";
            }
            else
            {
                CurrentRule = "Game Rule: Lesser Than: You must roll a total lower than the House's roll to win.";
            }
        }

        public int GetWinner(int HouseRollResult, int FaderRollResult)
        {
            if (HouseRollResult == FaderRollResult)
            {
                return 0;
            }
            else if (CurrentRule == "Game Rule: Lesser Than: You must roll a total lower than the House's roll to win.")
            {
                if (HouseRollResult > FaderRollResult)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (HouseRollResult > FaderRollResult)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
