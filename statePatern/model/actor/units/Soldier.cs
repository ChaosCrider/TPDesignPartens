using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.state;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.Actor
{

    //unit classes are not leveraged for this assignement.

    public class Soldier : DestructibleUnit
    {
        public Soldier(Status status, Vitals vitals, List<IAbility> abilities, Location location, List<IStance> availableStance) : base(status, vitals, abilities, location, availableStance)
        {

        }

        public override void updateAttribut(DestructibleUnit owner)
        {
            Stance stance = owner.status.stance;
            if (stance.GetType() == typeof(DefensiveStance))
            {
                owner.vitals.moveSpeed = 2;
            }
            else
            {
                owner.vitals.moveSpeed = 3;
            }

        }
    }
}
