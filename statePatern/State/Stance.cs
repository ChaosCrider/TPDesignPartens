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
        public DesctrutableUnit owner  { get; set; }

        //needed for units that can attack
        public delegate void runAttack(ITargetable target);
        protected runAttack doAttack = null;

        //needed to update the units implicite statistique and potentical explicit statistique.
        //enterStance is meant to be call everytimethe unit enters the stance
        public delegate void runUpdate(DesctrutableUnit unit);
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


        public Stance(string name, DesctrutableUnit owner, runAttack a, runUpdate u)
        {
            this.name = name;
            this.owner = owner;
            this.doAttack = a;
            this.doUpdate = u;
        }


        public void enterStance(DesctrutableUnit owner)
        {
            doUpdate(owner);
        }

        public void noUpdate(DesctrutableUnit unit)
        {
            throw new NotImplementedException();
        }

        public void noAttack(ITargetable target) 
        {
            throw new NotImplementedException();
        }

        public void attack(ITargetable target)
        {
            doAttack(target);
        }

        public void changeState(IStance stance)
        {
            throw new NotImplementedException();
        }

        public void move(ITargetable target)
        {
            throw new NotImplementedException();
        }

        public void stop(ITargetable owner)
        {
            
        }

        public void updateAttribut(DesctrutableUnit owner)
        {
            doUpdate(owner);
        }


    }
}
