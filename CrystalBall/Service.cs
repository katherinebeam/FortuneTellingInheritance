using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBall
{
    class Service
    {
        //Properties
        //services have costs
        //this should be overrideable
        public virtual decimal Price { get; set; }

        //all services have a name
        public virtual string Name { get; set; }

        //Let's make a property to store a result. A single result - a string.
        public virtual string Result { get; set; }
    }
}
