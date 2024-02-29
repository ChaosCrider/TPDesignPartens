using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.Builder
{
    internal class WaterBreatherBlueprint : Blueprint, IBlueprint
    {

        //overriders the default Lifesupport creation method
        QuantitativeCompo IBlueprint.buildLifeSupport(int size)
        {
            return new QuantitativeCompo("LifeSuport_Water", size);
        }
    }
}
