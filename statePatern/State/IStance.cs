﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;

namespace TPDesignPartens.statePatern.State
{
    public interface IStance
    {

        void changeState(IStance stance);
        void move(ITargetable target);
        void stop(ITargetable owner);
        void attack(ITargetable target);
        void updateAttribut(DesctrutableUnit owner);
        void enterStance(DesctrutableUnit owner);

    }
}
