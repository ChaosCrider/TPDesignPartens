using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Actor;

namespace TPDesignPartens.statePatern.actor.abilities
{
    internal class Fortify: IAbility
    {
        public Fortify() { }

        public override string ToString()
        {
            return "Fortify";
        }
    }
}
