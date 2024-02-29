using System;
using TPDesignPartens.statePatern.controller;

namespace TPDesignPartens
{
    internal class StateMain
    {
        internal static void run()
        {

            Console.WriteLine("=== Test Combat ===");

            SimpleCombatSimulation battle = new SimpleCombatSimulation();
            battle.run();
            Console.ReadLine();
        }
    }
}