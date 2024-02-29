using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.actor.abilities;
using TPDesignPartens.statePatern.actor.units;
using TPDesignPartens.statePatern.actor.unitTypes;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.state;
using TPDesignPartens.statePatern.State;
using TPDesignPartens.statePatern.view;

namespace TPDesignPartens.statePatern.controller
{
    internal class TestUnitCreationService
    {

        public static void run()
        {

            //Simple creation of one unit of each type and then prints them to console.
            //not used in this assignment and more related to testing.

            //created dummy dependency injection objects
            Civilian civilian = new Civilian();
            Military military = new Military();
            
            List<IAbility> abilities = new List<IAbility>();
            abilities.Add(new Enrage());
            abilities.Add(new Fortify());
            abilities.Add(new Heal());

            List<IStance> availableStance = new List<IStance>();
            availableStance.Add(new AgressiveStance("Aggressive", null, null, null));
            availableStance.Add(new DefensiveStance("Defence", null, null, null));


            //Generate the two units.
            EngineerGenerator eg = new EngineerGenerator(civilian, abilities, availableStance);
            Engineer engineer1 = eg.createEngineer(0, 0);

            SoldierGenerator sg = new SoldierGenerator(military, abilities, availableStance);
            Soldier soldier1 = sg.createSoldier(0, 1);

            //prints them to console
            Console.WriteLine("============================================");
            Console.WriteLine(engineer1);

            Console.WriteLine();

            Console.WriteLine("============================================");
            Console.WriteLine(soldier1);


            Console.WriteLine("Press any key to continue:");
            Console.ReadLine();
        }

    }
}
