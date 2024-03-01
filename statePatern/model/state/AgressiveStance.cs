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
        public AgressiveStance(string name, DestructibleUnit owner, runAttack a, runUpdate u) : base(name, owner, a, u)
        {
        }

        public void attack(ITargetable target)
        {
            this.doAttack(target);
        }

        public void enterStance(DestructibleUnit owner)
        {
            owner.status.isFortified = false;
            owner.status.stance = this;
        }

        public void move(ITargetable target)
        {
            throw new NotImplementedException();
        }

        public void stop(ITargetable owner)
        {

        }
    }
}
