using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.actor.abilities;
using TPDesignPartens.statePatern.actor.units;
using TPDesignPartens.statePatern.actor.unitTypes;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.scene;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.state;
using TPDesignPartens.statePatern.State;
using static TPDesignPartens.statePatern.State.Stance;

namespace TPDesignPartens.statePatern.view
{
    public class SoldierGenerator
    {

        //move all these static field into private variables populated through the constructor.
        //move all object creation to the the controller.
        /*
        private Military unitType = new Military();
        private runAttack attack = new runAttack(runAttack);
        private runUpdate update = new runUpdate(runUpdate);
        private Stance defaultStance = new DefensiveStance("Soldier", null, attack, update);
        private List<IAbility> abilities = new List<IAbility>{ 
            new Enrage(),
            new Fortify(),
            new Heal()
            };
        */


        private Military unitType;
        private List<IAbility> abilities;
        private List<IStance> availableStance;

        public SoldierGenerator(Military unitType, List<IAbility> abilities, List<IStance> availableStance)
        {
            this.unitType = unitType;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        public Soldier createSoldier(int x, int y)
        {
            Stance defaultStance = new DefensiveStance("Defencive", null, unitType.runAttack, unitType.runUpdate);
            Vitals v = new Vitals(300, 10, 12, 3);
            Status s = new Status(unitType, true, false, defaultStance);
            Location location = new Location(x, y);
            Soldier soldier = new Soldier(s, v, abilities, location, availableStance);
            defaultStance.owner = soldier;
            return soldier;
        }
    }
}
