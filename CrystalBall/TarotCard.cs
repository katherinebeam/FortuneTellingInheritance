using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class TarotCard : Magic
    {
        //Initialized dictionary of tarot cards as the keys with their associated meanings/descriptions as the values
        private Dictionary<string,string> TarotCards { get; set; } = new Dictionary<string, string>() {
            {"Death Card",
                "Death signifies intense change, and most people do not welcome change. In its most positive guise, Death heralds a chance to start over, a second chance in relationships, or a time of major growth. If viewed with a negative outlook, Death can indicate the unexpected, and deep rooted fears of the unknown. When you accept change as it comes and grow from it, you can release that which has gone before and get on with what is yet to come. Discoveries, opportunities, and new cycles await you. Rather than resisting out of habit, embrace them, and your worries will fade away."
            },
            {"Justice Card",
                "Justice urges you to examine your past, and how the actions of your past have brought you to your present. In doing this, you realize how what you do right now will influence who you become in the future. You must accept that your present situation is one you helped create. In doing so, you can cut through the illusion of events to the wisdom you should be gaining from them."
            },
            {
                "Fool Card",
                "You must make a leap of faith, taking only the baggage that benefits you, with the ultimate trust that you will make it alright. The Fool encourages you to go beyond your boundaries, to work past your fears, and to believe that anything is possible."
            }
        };

        //Name of magic service type
        public override string Name { get; set; } = "Tarot Cards";

        //Method for accessing the name of the random card selected
        private string GetCard()
        {
            //Make a list of all the keys in the dictionary (the card names)
            List<string> listOfCardNames = new List<string>(TarotCards.Keys);
            //Create a random number
            Random rand = new Random();
            //Use random number to access a random card in the key list
            string titleOfCard = listOfCardNames[rand.Next(listOfCardNames.Count)];
            //Returns the card name for the random card selected 
            return titleOfCard;
        }

        //Method for accessing the description of the random card selected
        private string GetFortune()
        {
            //Returns the fortune/description for the random card selected
            return TarotCards[GetCard()];
        }

        //Method for reading the user their fortune
        public void ReadFortune()
        {
            Console.WriteLine("The stars have selected the " + GetCard() + " for you.");
            Console.WriteLine("Your fortune, my dear, is:\n\t\"" + GetFortune() + "\"");
        }

        //Constructors
        public TarotCard()
        {
             this.Price = 45.00m;
             this.PercentEffective = 75;
             this.BlackMagic = false;
             this.Expertise = "medium";
        }
    }
}

