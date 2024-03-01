using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Actor;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.actor.abilities
{

    //Ability classes are not truely leveraged for this assignement.


    internal class Fortify: IAbility
    {
        public Fortify() 
        {
        }

        public void use(DestructibleUnit owner) 
        {
            if(owner.status.isFortified == true) 
            {
                Console.WriteLine(owner.GetType().Name + owner.id + " enters fortified position.");
                owner.status.isFortified = false;
                owner.status.stance.enterStance(owner);
            }
            else 
            {
                Console.WriteLine(owner.GetType().Name + owner.id + " leaves fortified position.");
                owner.status.isFortified = true;
                owner.status.stance.enterStance(owner);
            }
        }

        public override string ToString()
        {
            return "Fortify";
        }
    }
}
