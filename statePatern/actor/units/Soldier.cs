using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.Actor
{
    internal class Soldier : DesctrutableUnit
    {
        public Soldier(Status status, Vitals vitals, List<IAbility> abilities, Location location, Stance availableStance) : base(status, vitals, abilities, location, availableStance)
        {
        }
    }
}
