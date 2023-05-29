/*
 * Created by: Galbeaza Ciprian
 *
 * Functionality: 
 * The ICoinFactory interface serves as a contract for creating coin objects in the CoinFlip game. 
 * This is part of the Factory design pattern to ensure the creation process is consistent across different types of coins.
 *
 * Design Pattern: Factory
 *
*/

namespace CoinFlipGame
{
    interface ICoinFactory
    {
        // Method to create a coin object, the type of which is determined by the implementing class
        ICoin CreateCoin();
    }
}
