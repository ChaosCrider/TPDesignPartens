﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor
{
    public interface IUnitType
    {
        /*
         * should be controlling Delegates for individual unit type
         */

        void runAttack(ITargetable target);

        void runUpdate(DesctrutableUnit unit);
    }
}