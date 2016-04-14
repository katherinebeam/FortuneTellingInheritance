using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class Magic : Service
    {
        // What is at the base of a magical item?
        public virtual bool BlackMagic { get; set; }

        public virtual int PercentEffective { get; set; }

        public override string Name { get; set; }

        protected virtual string Expertise { get; set; }

        //Methods

        //Tells user they are about to begin performing their selected magic type
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }

        //Tell the user the results of the magical service
        public virtual void Show()
        {
            Console.WriteLine("Oh my! The {0} told me something very interesting.", this.Name);
            Console.WriteLine(this.Result);
        }

    }
}
