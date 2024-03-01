using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.Scene;

namespace TPDesignPartens.statePatern.State
{
    public interface IStance
    {
        void move(ITargetable target);
        void stop(ITargetable owner);
        bool attack(ITargetable target);
        void enterStance(DestructibleUnit owner);

    }
}
