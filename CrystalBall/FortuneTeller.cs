using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class FortuneTeller
    {
        //Properties
        public string Name { get; set; } = "Professor Trelawney";

        public string ExperienceLevel { get; set; }

        //Methods
        //Method to welcome the user into the game
        public void Greet()
        {
            Console.WriteLine("Hello! Come into my office.");
            Console.WriteLine("Let's see what your future holds.");
        }

        //Method for telling the user the name and cost of the service they selected
        public void StartService(Service service)
        {
            Console.WriteLine("For you, my {0}! Yes, perfect. It only costs {1}.", service.Name, service.Price);
        }

        //Method for saying goodbye to the user
        public void Farewell()
        {
            Console.WriteLine("Stop by again soon!");
        }

        ///<summary>
        ///Create a new fortune teller, giving it a name and experience level
        ///</summary>
        ///<param name="name">The fortune teller's name.</param>
        ///<param name="experienceLevel">A string value(beginner, intermediate, advanced)</param>
        
        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }

        public FortuneTeller()
        {

        }

    }
}
