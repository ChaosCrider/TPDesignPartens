﻿using System;
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
        public List<IStance> availableStance { get; set; }

        private static int idCount = 1;


        //use to store the ability being triggered.
        private delegate void runAbility(IAbility ability);

        public DesctrutableUnit(List<IAbility> abilities, List<IStance> availableStance)
        {
            id = idCount++;
            this.abilities = abilities;
            this.availableStance = availableStance;
            runAbility triggeringAbility = new runAbility(doAbility);
            this.vitals = new Vitals(0,0,0,0);
            this.status = new Status(null, false, false, null);
        }

        public DesctrutableUnit(Status status, Vitals vitals, List<IAbility> abilities, Location location, List<IStance> availableStance)

        {
            id = idCount++;
            this.status = status;
            this.vitals = vitals;
            this.abilities = abilities;
            this.availableStance = availableStance;
        }

        private void doAbility(IAbility ability)
        {
            Console.WriteLine("Null Ability triggered");
        }

        public void useAbility(IAbility ability) 
        {
            doAbility(ability);
        }

        public override string ToString()
        {
            string returnString = "ID : " + id  + "\r\n" + vitals + "\r\n" + status;

            returnString += "\r\nAbilities : \r\n";
            foreach (IAbility ability in abilities) 
            {
                returnString += ability.ToString();
                returnString += "\r\n";
            }

            returnString += "\r\nPossible stances : \r\n";
            foreach (IStance stance in availableStance) 
            { 
                returnString += stance.ToString();
                returnString += "\r\n";
            }
            return returnString;

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}