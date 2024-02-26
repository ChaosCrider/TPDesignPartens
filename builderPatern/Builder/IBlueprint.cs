using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.Builder
{
    public interface IBlueprint
    {
        QuantitativeCompo buildHull(int size);
        QuantitativeCompo buildLifeSupport(int size);
        QuantitativeCompo buildPowerGenerator(int size);
        DescriptiveCompo buildWeapons(string description);
        QuantitativeCompo buildCargo(int size);
        QuantitativeCompo buildEngin(int size);
        DescriptiveCompo buildSteering(string description);
    }
}
