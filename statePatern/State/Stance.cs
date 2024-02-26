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
        delegate void runAttack(ITargetable target);
        runAttack doAttack = null;

        //needed to update the units implicite statistique and potentical explicit statistique.
        delegate void runUpdate(DesctrutableUnit unit);
        runUpdate doUpdate = null;

        public Stance(string name, DesctrutableUnit owner)
        {
            this.name = name;
            this.owner = owner;
            doAttack = new runAttack(noAttack);
            doUpdate = new runUpdate(noUpdate);
        }

        private void noUpdate(DesctrutableUnit unit)
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
