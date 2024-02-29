using System;
using System.Collections.Generic;
using System.Reflection;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.Scene;

namespace TPDesignPartens.statePatern.State
{

    public class DestructibleUnit : ITargetable
    {
        public int id { get; set; }
        public Status status { get; set; }
        public Vitals vitals { get; set; }
        public List<IAbility> abilities { get; set; }
        public Location location { get; set; }
        public List<IStance> availableStance { get; set; }

        private static int idCount = 1;

        // Delegate to store the ability being triggered
        private delegate void RunAbility(IAbility ability);

        // Constructor for a DestructibleUnit with initial abilities and stances
        public DestructibleUnit(List<IAbility> abilities, List<IStance> availableStance)
        {
            id = idCount++;
            this.abilities = abilities;
            this.availableStance = availableStance;
            RunAbility triggeringAbility = new RunAbility(DoAbility);
            this.vitals = new Vitals(0, 0, 0, 0);
            this.status = new Status(null, false, false, null);
        }

        // Constructor for a DestructibleUnit with specified status, vitals, abilities, location, and stances
        public DestructibleUnit(Status status, Vitals vitals, List<IAbility> abilities, Location location, List<IStance> availableStance)
        {
            id = idCount++;
            this.status = status;
            this.vitals = vitals;
            this.abilities = abilities;
            this.location = location;
            this.availableStance = availableStance;
        }

        // Method to handle the execution of an ability
        // not implemented

        private void DoAbility(IAbility ability)
        {
            Console.WriteLine("Null Ability triggered");
        }

        // Method to get the name of the DestructibleUnit
        public string GetName()
        {
            return this.GetType().Name + id;
        }

        // Override of ToString() method for better representation
        public override string ToString()
        {
            string returnString = GetName() + "\r\n" + vitals + "\r\n" + status;

            returnString += "\r\nAbilities : ";
            foreach (IAbility ability in abilities)
            {
                returnString += "\r\n";
                returnString += " - " + ability.ToString();
            }

            returnString += "\r\nPossible stances : ";
            foreach (IStance stance in availableStance)
            {
                returnString += "\r\n";
                returnString += " - " + stance.ToString();
            }
            return returnString;
        }

        // Override of Equals and GetHashCode methods
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Method to get the cover percentage based on the unit's status
        public int GetCover()
        {
            if (status.isFortified) return 120;
            return 100;
        }
    }

}