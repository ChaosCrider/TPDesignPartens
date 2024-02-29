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
        private Military unitType;            // Type of military unit to generate
        private List<IAbility> abilities;      // List of abilities the soldier possesses
        private List<IStance> availableStance; // List of available stances for the soldier

        // Constructor to initialize the SoldierGenerator with unitType, abilities, and availableStance
        public SoldierGenerator(Military unitType, List<IAbility> abilities, List<IStance> availableStance)
        {
            this.unitType = unitType;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        // Method to create a Soldier with specified coordinates (x, y)
        public Soldier CreateSoldier(int x, int y)
        {
            // Create a default defensive stance for the soldier with no owner
            Stance defaultStance = new DefensiveStance("Defensive", null, unitType.runAttack, unitType.runUpdate);

            // Create Vitals for the soldier
            Vitals v = new Vitals(300, 10, 12, 3);

            // Create Status for the soldier with the provided unitType and defaultStance
            Status s = new Status(unitType, true, false, defaultStance);

            // Create Location for the soldier with specified coordinates (x, y)
            Location location = new Location(x, y);

            // Create a Soldier instance with the created Status, Vitals, abilities, location, and available stances
            Soldier soldier = new Soldier(s, v, abilities, location, availableStance);

            // Set the owner of the default stance to the created soldier
            defaultStance.owner = soldier;

            return soldier;  // Return the created Soldier instance
        }
    }

}
