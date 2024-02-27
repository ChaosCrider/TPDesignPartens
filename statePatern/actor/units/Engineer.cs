using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor.units
{
    public  class Engineer : DesctrutableUnit
    {
        public Engineer(Status status, Vitals vitals, List<IAbility> abilities, Location location, List<IStance> availableStance) : base(status, vitals, abilities, location, availableStance)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
