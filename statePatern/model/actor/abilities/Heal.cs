﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Actor;

namespace TPDesignPartens.statePatern.actor.abilities
{

    //Ability classes are not truely leveraged for this assignement.

    public class Heal : IAbility
    {
        public Heal() { }

        public override string ToString()
        {
            return "Heal";
        }
    }
}
