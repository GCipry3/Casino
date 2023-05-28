using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PokerGame.Properties;

namespace PokerGame
{
    public class Poker : IPoker
    {
        // Random generator for getting random cards from the deck
        readonly Random random;

        // Instance of BetPoker to manage the bet value
        readonly IBetPoker betValue;

        // Dictionary to store the card images
        Dictionary<string, Image> images;

        public Poker()
        {
            random = new Random();
            betValue = new BetPoker();

            // Populate the deck of cards
            RenewDeck();
        }

        // Method to refresh the deck of cards
        public void RenewDeck()
        {
            // Populate the images dictionary with card image resources
            // The key is the card name and the value is the associated image
            // This essentially forms the deck of cards
            images = new Dictionary<string, Image>()
            {
                // Cards are represented as "_rank_suit"
                // For example, "_02trefla" represents the 2 of Clubs
                { "_02trefla", Resources.ResourceManager.GetImage("Resources.Resources.2trefla.jpg")},
                { "_02romb", Resources.ResourceManager.GetImage("Resources.Resources.2romb.jpg")},
                { "_02frunza", Resources.ResourceManager.GetImage("Resources.Resources.2frunza.jpg")},
                { "_02inima", Resources.ResourceManager.GetImage("Resources.Resources.2inima.jpg")},
                { "_03trefla", Resources.ResourceManager.GetImage("Resources.Resources.3trefla.jpg")},
                { "_03romb", Resources.ResourceManager.GetImage("Resources.Resources.3romb.jpg")},
                { "_03frunza", Resources.ResourceManager.GetImage("Resources.Resources.3frunza.jpg")},
                { "_03inima", Resources.ResourceManager.GetImage("Resources.Resources.3inima.jpg")},
                { "_04trefla", Resources.ResourceManager.GetImage("Resources.Resources.4trefla.jpg")},
                { "_04romb", Resources.ResourceManager.GetImage("Resources.Resources.4romb.jpg")},
                { "_04frunza", Resources.ResourceManager.GetImage("Resources.Resources.4frunza.jpg")},
                { "_04inima", Resources.ResourceManager.GetImage("Resources.Resources.4inima.jpg")},
                { "_05trefla", Resources.ResourceManager.GetImage("Resources.Resources.5trefla.jpg")},
                { "_05romb", Resources.ResourceManager.GetImage("Resources.Resources.5romb.jpg")},
                { "_05frunza", Resources.ResourceManager.GetImage("Resources.Resources.5frunza.jpg")},
                { "_05inima", Resources.ResourceManager.GetImage("Resources.Resources.5inima.jpg")},
                { "_06trefla", Resources.ResourceManager.GetImage("Resources.Resources.6trefla.jpg")},
                { "_06romb", Resources.ResourceManager.GetImage("Resources.Resources.6romb.jpg")},
                { "_06frunza", Resources.ResourceManager.GetImage("Resources.Resources.6frunza.jpg")},
                { "_06inima", Resources.ResourceManager.GetImage("Resources.Resources.6inima.jpg")},
                { "_07trefla", Resources.ResourceManager.GetImage("Resources.Resources.7trefla.jpg")},
                { "_07romb", Resources.ResourceManager.GetImage("Resources.Resources.7romb.jpg")},
                { "_07frunza", Resources.ResourceManager.GetImage("Resources.Resources.7frunza.jpg")},
                { "_07inima", Resources.ResourceManager.GetImage("Resources.Resources.7inima.jpg")},
                { "_08trefla", Resources.ResourceManager.GetImage("Resources.Resources.8trefla.jpg")},
                { "_08romb", Resources.ResourceManager.GetImage("Resources.Resources.8romb.jpg")},
                { "_08frunza", Resources.ResourceManager.GetImage("Resources.Resources.8frunza.jpg")},
                { "_08inima", Resources.ResourceManager.GetImage("Resources.Resources.8inima.jpg")},
                { "_09trefla", Resources.ResourceManager.GetImage("Resources.Resources.9trefla.jpg")},
                { "_09romb", Resources.ResourceManager.GetImage("Resources.Resources.9romb.jpg")},
                { "_09frunza", Resources.ResourceManager.GetImage("Resources.Resources.9frunza.jpg")},
                { "_09inima", Resources.ResourceManager.GetImage("Resources.Resources.9inima.jpg")},
                { "_10trefla", Resources.ResourceManager.GetImage("Resources.Resources.10trefla.jpg")},
                { "_10romb", Resources.ResourceManager.GetImage("Resources.Resources.10romb.jpg")},
                { "_10frunza", Resources.ResourceManager.GetImage("Resources.Resources.10frunza.jpg")},
                { "_10inima", Resources.ResourceManager.GetImage("Resources.Resources.10inima.jpg")},
                { "_15trefla", Resources.ResourceManager.GetImage("Resources.Resources.atrefla.jpg")},
                { "_15romb", Resources.ResourceManager.GetImage("Resources.Resources.aromb.jpg")},
                { "_15frunza", Resources.ResourceManager.GetImage("Resources.Resources.afrunza.jpg")},
                { "_15inima", Resources.ResourceManager.GetImage("Resources.Resources.ainima.jpg")},
                { "_12trefla", Resources.ResourceManager.GetImage("Resources.Resources.jtrefla.jpg")},
                { "_12romb", Resources.ResourceManager.GetImage("Resources.Resources.jromb.jpg")},
                { "_12frunza", Resources.ResourceManager.GetImage("Resources.Resources.jfrunza.jpg")},
                { "_12inima",Resources.ResourceManager.GetImage("Resources.Resources.jinima.jpg")},
                { "_13trefla", Resources.ResourceManager.GetImage("Resources.Resources.qtrefla.jpg")},
                { "_13romb", Resources.ResourceManager.GetImage("Resources.Resources.qromb.jpg")},
                { "_13frunza", Resources.ResourceManager.GetImage("Resources.Resources.qfrunza.jpg")},
                { "_13inima", Resources.ResourceManager.GetImage("Resources.Resources.qinima.jpg")},
                { "_14trefla", Resources.ResourceManager.GetImage("Resources.Resources.ktrefla.jpg")},
                { "_14romb", Resources.ResourceManager.GetImage("Resources.Resources.kromb.jpg")},
                { "_14frunza", Resources.ResourceManager.GetImage("Resources.Resources.kfrunza.jpg")},
                { "_14inima", Resources.ResourceManager.GetImage("Resources.Resources.kinima.jpg")}
            };
        }

        // Property to access the deck of cards
        public Dictionary<string, Image> Images
        {
            get { return images; }
        }

        // Property to access and modify the bet value
        public int BetValue
        {
            get { return betValue.BetValue; }
            set { betValue.BetValue = value; }
        }

        // Method to calculate the winnings based on the final set of images (cards)
        public int CalculateWinnings(string[] images)
        {
            // Return the prize money based on the final set of cards
            return betValue.GetThePrize(images);
        }

        // Method to remove a card from the deck
        public void RemoveCard(string img)
        {
            // If the deck contains the card, remove it
            if (images.ContainsKey(img))
            {
                images.Remove(img);
            }
        }

        // Method to add a card back to the deck
        public void AddCard(string img, Image image)
        {
            // If the deck does not contain the card, add it
            if (!images.ContainsKey(img))
            {
                images.Add(img, image);
            }
        }

        // Method to get a random card image from the deck
        public KeyValuePair<string, Image> GetRandomImage()
        {
            // Generate a random index
            int index = random.Next(images.Count);

            // Return the card at the generated index
            return images.ElementAt(index);
        }
    }
}
