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
            if (target is DesctrutableUnit)
            {
                DesctrutableUnit unit = (DesctrutableUnit)target;
                int cover = unit.getCover();
                if (unit.status.isfortified)

                    //gets a percent effect dmg reduction by x100 / ( % x 100 )
                    if ((unit.vitals.HP -= (((weapon+upgrade) * 100) / cover)) <= 0)
                    {
                        return true;
                    }
            }

            return false;
        }

        public void runUpdate(DesctrutableUnit unit)
        {
            if (unit is DesctrutableUnit)
            {
                DesctrutableUnit u = (DesctrutableUnit)unit;
                if (u.status.isfortified == false) { 
                    u.status.isfortified = true;
                    u.vitals.moveSpeed /= 2;
                }
                else {
                    u.status.isfortified = false; 
                    u.vitals.moveSpeed *= 2;
                }
            }
        }

        public override string ToString()
        {
            return "Military";
        }
    }
}
