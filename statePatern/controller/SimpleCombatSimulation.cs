using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.actor.abilities;
using TPDesignPartens.statePatern.actor.unitTypes;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.state;
using TPDesignPartens.statePatern.State;
using TPDesignPartens.statePatern.view;

namespace TPDesignPartens.statePatern.controller
{
    public class SimpleCombatSimulation
    {
        // variable used only in this process
        private List<DestructibleUnit> team1, team2;
        private CaptureInput ci;
        private Random random;


        //objects used as parametre for creation of other objects.
        Civilian civilian;
        Military military;

        List<IAbility> abilities;
        List<IStance> availableStance;

        public SimpleCombatSimulation()
        {

            //creates two teams and initialise the params for the simulation object.
            team1 = new List<DestructibleUnit>();
            team2 = new List<DestructibleUnit>();
            ci = new CaptureInput();

            civilian = new Civilian();
            military = new Military();

            abilities = new List<IAbility>();
            abilities.Add(new Enrage());
            abilities.Add(new Fortify());
            abilities.Add(new Heal());

            availableStance = new List<IStance>();
            availableStance.Add(new AgressiveStance("Aggressive", null, null, null));
            availableStance.Add(new DefensiveStance("Defence", null, null, null));

            //and a randomiser object to ad variation to unit behavior.
            random = new Random();
        }


        public async void run()
        {

            //has the two teams fight.

            int iturn = 1;
            int i1 = 0;
            int i2 = 0;
            //populate teams as per user input
            Console.WriteLine("-= Creating Team 1 =-");
            populateTeam(team1);
            Console.WriteLine("-= Creating Team 2 =-");
            populateTeam(team2);

            //cycles through each unit, alternating teams on each action
            Console.WriteLine(" - Turn "+iturn+" - ");
            do
            {


                //if a each team action left is less then their team member, next unit acts.


                if (i1 < team1.Count) performTurn(i1, team1, team2);
                if (i2 < team2.Count) performTurn(i2, team2, team1);





                //verify for end turn an
                i1++;
                i2++;
                if (i1 > team1.Count && i2 > team2.Count) 
                {
                    i1 = 0;
                    i2 = 0;
                    iturn++;
                    //increase soldier upgrade at end of each turn.
                    military.upgradeWeapon();
                    await Task.Delay(500);
                    Console.WriteLine(" - Turn " + iturn + " - ");
                }


                //repeat until one team contain 0 unit alive.
            } while (team1.Count > 0 && team2.Count > 0);
            //declare winner.
            if (team1.Count < 0) { Console.WriteLine("Team 2 wins"); }
            else { Console.WriteLine("Team 1 wins"); }
        }

        public void performTurn(int i, List<DestructibleUnit> attacker, List<DestructibleUnit> target)
        {
            //choose between attack or fortify randomly
            try { 
            if (random.Next(2) == 0)
            {
                Console.WriteLine(attacker[i].GetType().Name+attacker[i].id + " uses Fortify.");
                attacker[i].status.type.runUpdate(attacker[i]);
            }
            else
            {
                //choose attack taget randomly from other team.
                DestructibleUnit defender = target[random.Next(target.Count)];
                Console.WriteLine(attacker[i].GetType().Name + attacker[i].id + " attacks " + defender.GetType().Name + defender.id + ".");
                if (attacker[i].status.stance.attack((ITargetable)defender))
                {
                    //remove unit from team of dead.
                    Console.WriteLine(defender.GetType().Name + defender.id + " dies.");
                    target.Remove(defender);
                }

            }
            }catch (ArgumentOutOfRangeException e)
            {
                //handles exceptions where the array hasa shorten from units dying but the index for the loop has'nt caugh up to.
            }
            
        }

        public void populateTeam(List<DestructibleUnit> team)
        {
            generateSoldiers(team);
            generateEngineer(team);
        }

        public void generateEngineer(List<DestructibleUnit> team)
        {
            //asks for how many then adds the amount requested to the team.
            EngineerGenerator eg = new EngineerGenerator(civilian, abilities, availableStance);
            int count = ci.CaptureInt("please select an amount between 0 and 10 of Enginneers to add to the " + nameof(team), 0, 10);
            for (int i = 0; i < count; i++) 
            { team.Add(eg.createEngineer(0,0)); }
        }

        public void generateSoldiers(List<DestructibleUnit> team)
        {
            //asks for how many then adds the amount requested to the team.
            SoldierGenerator sg = new SoldierGenerator(military, abilities, availableStance);
            int count = ci.CaptureInt("please select an amount between 0 and 10 of Soldiers to add to the " + nameof(team), 0, 10);
            for (int i = 0; i < count; i++)
            { team.Add(sg.createSoldier(0, 0)); }

        }
    }
}

