/*
 * Created by: Farcas Cosmin Catalin 
 *
 * Functionality: This class represents the rules of a Dice Game. It handles the rules logic
 * such as changing the game rule and determining the winner based on the current rule. 
 * The game can operate under two rules, the 'higher rule' where the player must roll a total 
 * higher than the House's roll to win and the 'lower rule' where the player must roll a total
 * lower than the House's roll to win.
 *
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesGame
{
    public class GameRule
    {
        // Definition of game rules
        public string higherRule = "Game Rule: You must roll a total higher than the House's roll to win.";
        public string lowerRule = "Game Rule: You must roll a total lower than the House's roll to win.";

        // Constructor initializes the game with the 'higher rule' 
        public GameRule() { 
            CurrentRule= higherRule;
        }

        // Property to hold the current rule
        public string CurrentRule { get; private set; }

        // Method to change the current game rule from 'lower rule' to 'higher rule' and vice versa
        public void ChangeGameRule()
        {
            CurrentRule = CurrentRule == lowerRule? higherRule : lowerRule;
        }

        // Method to determine the winner. If the House's roll and the player's roll are equal, 
        // the result is a tie (returns 0). If the current rule is 'lower rule' and the House's roll is 
        // greater than the player's roll, the House wins (returns 1), otherwise the player wins (returns 2). 
        // If the current rule is 'higher rule' and the House's roll is greater than the player's roll, 
        // the player wins (returns 2), otherwise the House wins (returns 1).
        public int GetWinner(int HouseRollResult, int FaderRollResult)
        {
            // Tie case
            if (HouseRollResult == FaderRollResult)
            {
                return 0;
            }
            // Lower rule case
            else if (CurrentRule == lowerRule)
            {
                return HouseRollResult > FaderRollResult ? 1 : 2;
            }
            // Higher rule case
            else
            {
                return HouseRollResult > FaderRollResult ? 2 : 1;
            }
        }
    }
}
