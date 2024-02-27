using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.state
{
    internal class AgressiveStance : Stance
    {
        public AgressiveStance(string name, DesctrutableUnit owner, runAttack a, runUpdate u) : base(name, owner, a, u)
        {
        }

        public void attack(ITargetable target)
        {
            this.doAttack(target);
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
            this.doUpdate(owner);
        }
    }
}
