﻿using System;
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
            if (CurrentRule == "Game Rule: Lesser Than \"You must roll a total lower than the House's roll to win.\"")
            {
                CurrentRule = "Game Rule: Greater Than \"You must roll a total higher than the House's roll to win.\"";
            }
            else
            {
                CurrentRule = "Game Rule: Lesser Than \"You must roll a total lower than the House's roll to win.\"";
            }
        }

        public bool EvaluateRule(int rollResult)
        {
            // depending on your rules, you may need to adjust the logic here
            if (CurrentRule == "Game Rule: Greater Than \n You must roll a total higher than the House's roll to win.")
            {
                return rollResult > 7;
            }
            else if (CurrentRule == "Game Rule: Lesser Than \n You must roll a total lower than the House's roll to win.")
            {
                return rollResult < 6;
            }
            else // "Dubla"
            {
                return rollResult % 2 == 0; // an example for checking for doubles
            }
        }
    }
}
