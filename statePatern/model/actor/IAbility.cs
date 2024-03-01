using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.Actor
{
    public interface IAbility
    {
        void use(DestructibleUnit owner);
    }
}
