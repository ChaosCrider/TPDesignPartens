using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.Builder
{
    internal class NonBreatherBlueprint : Blueprint, IBlueprint
    {
         QuantitativeCompo IBlueprint.buildLifeSupport(int size)
        {
            return new QuantitativeCompo("LifeSuport_None", 0);
        }
    }
}
