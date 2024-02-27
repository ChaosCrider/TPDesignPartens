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
        public void runAttack(ITargetable target)
        {
            throw new NotImplementedException();
        }

        public void runUpdate(DesctrutableUnit unit)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Civilian";
        }
    }
}
