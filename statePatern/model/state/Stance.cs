using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;

namespace TPDesignPartens.statePatern.State
{
    public class Stance : IStance
    {
        public string name { get; set; }
        public DestructibleUnit owner  { get; set; }

        //needed for units that can attack
        public delegate bool runAttack(ITargetable target);
        protected runAttack doAttack = null;

        //needed to update the units implicite statistique and potentical explicit statistique.
        //enterStance is meant to be call everytimethe unit enters the stance
        public delegate void runUpdate(DestructibleUnit unit);
        protected runUpdate doUpdate = null;

        /* default contructor
        public Stance(string name, DesctrutableUnit owner)
        {
            this.name = name;
            this.owner = owner;
            this.doAttack = new runAttack(noAttack);
            this.doUpdate = new runUpdate(noUpdate);
        }
        */


        public Stance(string name, DestructibleUnit owner, runAttack a, runUpdate u)
        {
            this.name = name;
            this.owner = owner;
            this.doAttack = a;
            this.doUpdate = u;
        }

        public void noUpdate(DestructibleUnit unit)
        {
            throw new NotImplementedException();
        }

        public void noAttack(ITargetable target) 
        {
            throw new NotImplementedException();
        }


        public void enterStance(DestructibleUnit owner)
        {
            //need to be overriden
        }

        public bool attack(ITargetable target)
        {
            return doAttack(target);
        }


        public void move(ITargetable target)
        {
            throw new NotImplementedException();
        }

        public void stop(ITargetable owner)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType()) 
            { 
                Stance stance = (Stance)obj;
                if (stance.name.Equals(this.name)) 
                {
                    return true;
                }
            }

            return false;
        }

    }
}
