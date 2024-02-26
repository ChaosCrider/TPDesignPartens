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
    internal class Engineer : DesctrutableUnit
    {
        public Engineer(Status status, Vitals vitals, List<IAbility> abilities, Location location, Stance availableStance) : base(status, vitals, abilities, location, availableStance)
        {
        }
    }
}
