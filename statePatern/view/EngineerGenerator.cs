using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TPDesignPartens.statePatern.State.Stance;
using TPDesignPartens.statePatern.actor.unitTypes;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;
using TPDesignPartens.statePatern.actor.units;
using TPDesignPartens.statePatern.state;
using System.Threading;

namespace TPDesignPartens.statePatern.view
{
    internal class EngineerGenerator
    {

        private Civilian unitType;
        private List<IAbility> abilities;
        private List<IStance> availableStance;

        public EngineerGenerator(Civilian unitType, List<IAbility> abilities, List<IStance> availableStance)
        {
            this.unitType = unitType;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        public Engineer createEngineer(int x, int y)
        {
            Stance defaultStance = new DefensiveStance("Defencive", null, unitType.runAttack, unitType.runUpdate);
            Vitals v = new Vitals(300, 10, 12, 3);
            Status s = new Status(unitType, true, false, defaultStance);
            Location location = new Location(x, y);
            Engineer engineer = new Engineer(s, v, abilities, location, availableStance);
            defaultStance.owner = engineer;
            return engineer;
        }
    }
}
