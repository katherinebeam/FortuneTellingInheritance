using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    //Class of psychological services
    class Psychlogist : Service
    {
        //Properties
        //Psychologist type/speciality
        public string Type { get; set; }

        //Effectiveness of the type of psychological treatment
        public virtual int PercentEffective { get; set; } = 90; 

        //Name of the psychologist
        public override string Name { get; set; } = "Sigmund Freud"; 

        //How good the psychologist is at his specialty
        protected virtual string Expertise { get; set; } = "Advanced";

        //Methods
        //Menu method for user to select the type of psychological help they need so they can then be properly directed
        public virtual void psycheTypeMenu()
        {
            //Ask user to select the option that applies to them
            Console.WriteLine("Which type of therapy seems like the best match for your needs?\n\t(a) Anxiety/Depression Counseling\n\t(b) Behavioral Counseling\n\t(c) Marital Counseling\n\t(d) Addiction Counseling");
            
            //Get response from user
            string psychType = Console.ReadLine().ToUpper();

            //Set the type equal to the user's selection
            switch(psychType)
            {
                case "A":
                    this.Type = "Anxiety / Depression";
                    MessageFromPsychToClient();
                    break;
                case "B":
                    this.Type = "Behavioral";
                    MessageFromPsychToClient();
                    break;
                case "C":
                    this.Type = "Marriage";
                    MessageFromPsychToClient();
                    break;
                default:
                    this.Type = "General";
                    MessageFromPsychToClient();
                    break;
            }
        }

        //Method to inform user that their request will be responded to by the appropriate psychology specialist soon
        private void MessageFromPsychToClient()
        {
            Console.WriteLine("I will have our " + this.Type + " specialist give you a call soon. Thank you for stopping by!");
        }
    }
}
