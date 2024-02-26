using System;
using System.Collections.Generic;
using System.Reflection;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.Scene;

namespace TPDesignPartens.statePatern.State
{
    public class DesctrutableUnit
    {
        public int id { get; set; }
        public Status status { get; set; }
        public Vitals vitals { get; set; }
        public List<IAbility> abilities { get; set; }
        public Location location { get; set; }
        public Stance availableStance { get; set; }


        //use to store the ability being triggered.
        private delegate void runAbility(IAbility ability);

        public DesctrutableUnit(List<IAbility> abilities, Stance availableStance)
        {
            this.abilities = abilities;
            this.availableStance = availableStance;
            runAbility triggeringAbility = new runAbility(doAbility);
            this.vitals = new Vitals();
            this.status = new Status();
        }

        public DesctrutableUnit(Status status, Vitals vitals, List<IAbility> abilities, Location location, Stance availableStance)
        {
            this.status = status;
            this.vitals = vitals;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        private void doAbility(IAbility ability)
        {
            Console.WriteLine("Null Ability triggered");
        }

        public List<IAbility> listAbilities() 
        {
            return new List<IAbility>();
        }

        public void useAbility(IAbility ability) 
        {
            doAbility(ability);
        }

    }
}