using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class Crystalball : Magic
    {
        //Properties
        //Create random property for use in generating a random fortune from the crystal ball
        private Random random = new Random();

        //List of potential phrases/fortunes that the crystal ball may deliver to the user
        protected List<string> Phrases { get; set; } = new List<string>();

        //Name of the magic service
        public override string Name { get; set; } = "Crystall Ball";

        //Runs the crystal ball service by selecting a random phrase and setting it as the result
        public override void Work()
        {
            base.Work();
            this.Result = GetPhrase();
        }

        //Adding phrases to the crystal ball's arsenal of fortunes
        protected void CreatePhrases()
        {
            Phrases.Add("Night time is a dark place for you.");
            Phrases.Add("I see shiny objects in your near future.");
            Phrases.Add("The decorating around you needs some help.");
        }

        //Overloaded method for adding phrases to the crystal ball. Accepts the new phrase to be added as an argument.
        internal void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        //Chooses a fortune at random from the crystal ball
        private string GetPhrase()
        {
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }

        //Constructor
        public Crystalball()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            CreatePhrases();
        }
    }
}
