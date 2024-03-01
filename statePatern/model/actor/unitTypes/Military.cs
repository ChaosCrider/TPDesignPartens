using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor.unitTypes
{
    public class Military : IUnitType
    {
        /*
         * should be controlling Delegates for the Civilian type
         */

        private int weapon;
        public int upgrade { get; set; }

        public Military()
        {
            weapon = 50;
            upgrade = 0;
        }





        //returns true of false if hit is lethal
        public bool runAttack(ITargetable target)
        {
            if (target is DestructibleUnit)
            {
                DestructibleUnit unit = (DestructibleUnit)target;
                int cover = unit.getCover();
                if (unit.status.isFortified)

                    //gets a percent effect dmg reduction by x100 / ( % x 100 )
                    if ((unit.vitals.HP -= (((weapon+upgrade) * 100) / cover)) <= 0)
                    {
                        return true;
                    }
            }

            return false;
        }

        //for the sake of the assignment, the update only toggles the isFortified value,
        //this does not reprresent the main use of the state pattern for the assignment.
        //for the soldier also adjusts move speed which I was not able to implement a use for in time.
        public void runUpdate(DestructibleUnit unit)
        {
            if (unit is DestructibleUnit)
            {
                DestructibleUnit u = (DestructibleUnit)unit;
                if (u.status.isFortified == false) { 
                    u.status.isFortified = true;
                    u.vitals.moveSpeed /= 2;
                }
                else {
                    u.status.isFortified = false; 
                    u.vitals.moveSpeed *= 2;
                }
            }
        }

        public override string ToString()
        {
            return "Military";
        }


        // a simple escalation of damage inflicted to reduce simulation length.
        internal void upgradeWeapon()
        {
            Console.WriteLine("Weapon upgraded by 1 for militatry units");
            upgrade++;
        }
    }
}
