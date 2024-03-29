﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.state
{
    internal class DefensiveStance : Stance,IStance
    {
        public DefensiveStance(string name, DestructibleUnit owner, runAttack a, runUpdate u) : base(name, owner, a, u)
        {
        }

        public bool attack(ITargetable target)
        {
            return doAttack(target);
        }


        public void enterStance(DestructibleUnit owner) 
        {
            owner.status.isFortified = true;
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
