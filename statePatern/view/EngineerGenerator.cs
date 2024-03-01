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
        private Civilian unitType;             // Type of civilian unit to generate
        private List<IAbility> abilities;       // List of abilities the engineer possesses
        private List<IStance> availableStance;  // List of available stances for the engineer

        // Constructor to initialize the EngineerGenerator with unitType, abilities, and availableStance
        public EngineerGenerator(Civilian unitType, List<IAbility> abilities, List<IStance> availableStance)
        {
            this.unitType = unitType;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        // Method to create an Engineer with specified coordinates (x, y)
        public Engineer createEngineer(int x, int y)
        {
            // Create a default defensive stance for the engineer with no owner
            Stance defaultStance = new DefensiveStance("Defensive", null, unitType.runAttack, unitType.runUpdate);

            // Create Vitals for the engineer
            Vitals v = new Vitals(300, 10, 12, 3);

            // Create Status for the engineer with the provided unitType and defaultStance
            Status s = new Status(unitType, true, false, defaultStance);

            // Create Location for the engineer with specified coordinates (x, y)
            Location location = new Location(x, y);

            // Create an Engineer instance with the created Status, Vitals, abilities, location, and available stances
            Engineer engineer = new Engineer(s, v, abilities, location, availableStance);

            // Set the owner of the default stance to the created engineer
            defaultStance.owner = engineer;

            return engineer;  // Return the created Engineer instance
        }
    }

}
