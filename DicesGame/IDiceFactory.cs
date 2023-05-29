/*
 * Created by: Farcas Cosmin Catalin 
 *
 * Functionality: The IDiceFactory interface defines a method to create an instance of a dice object.
 *
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesGame
{
    internal interface IDiceFactory
    {
        /// <summary>
        /// Creates a new instance of a dice.
        /// </summary>
        IDice CreateDice();
    }
}
