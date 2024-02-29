using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor.unitTypes
{
    public class Civilian : IUnitType
    {
        /*
         * should be controlling Delegates for the Civilian type
         */
        private int weapon;



        public Civilian()
        {
            this.weapon = 30;
        }


        //returns true of false if hit is lethal
        public bool runAttack(ITargetable target)
        {
            if (target is DestructibleUnit)
            {
                DestructibleUnit unit = (DestructibleUnit)target;
                int cover = unit.getCover();
                if (unit.status.isfortified)

                    //gets a percent effect dmg reduction by x100 / ( % x 100 )
                if ( ( unit.vitals.HP -= ( ( weapon*100 ) / cover ) ) <= 0)
                {
                    return true;
                }
            }

            return false;
        }

        //for the sake of the assignment, the update only toggles the isFortified value,
        //this does not reprresent the main use of the state pattern for the assignment.
        public void runUpdate(DestructibleUnit unit)
        {
            if (unit is DestructibleUnit)
            {
                DestructibleUnit u = (DestructibleUnit)unit;
                if (u.status.isfortified == false) { u.status.isfortified = true; }
                else { u.status.isfortified = false; }
            }
        }
        public override string ToString()
        {
            return "Civilian";
        }
    }
}
