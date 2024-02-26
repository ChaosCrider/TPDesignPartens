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
        public string type { get; set; }
        public bool isMobile { get; set; }
        public bool isfortified { get; set; }
        public int HP { get; set; }
        public int tange { get; set; }
        public int lineOfSight { get; set; }
        public int moveSpeed { get; set; }
        public Stance stance { get; set; }
        public List<IAbility> abilities { get; set; }
        public Location location { get; set; }
        public Stance availableStance { get; set; }

        private delegate void runAbility(IAbility ability);

        public DesctrutableUnit(List<IAbility> abilities, Stance availableStance)
        {
            this.abilities = abilities;
            this.availableStance = availableStance;
            runAbility triggeringAbility = new runAbility(doAbility);

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