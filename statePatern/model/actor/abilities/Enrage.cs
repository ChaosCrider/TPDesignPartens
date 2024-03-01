using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor.abilities
{

    //Ability classes are not truely leveraged for this assignement.

    public class Enrage : IAbility
    {
        public Enrage() { }

        public override string ToString()
        {
            return "Enrage";
        }

        public void use(DestructibleUnit owner)
        {
            throw new NotImplementedException();
        }
    }
}
