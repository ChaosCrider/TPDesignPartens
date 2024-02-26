using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.builderPatern.Builder
{
    internal class Blueprint : IBlueprint
    {
        QuantitativeCompo IBlueprint.buildCargo(int size)
        {
            return new QuantitativeCompo("Cargo", size);
        }

        QuantitativeCompo IBlueprint.buildEngin(int size)
        {
            return new QuantitativeCompo("Engin", size);
        }

        QuantitativeCompo IBlueprint.buildHull(int size)
        {
            return new QuantitativeCompo("Hull", size);
        }

        QuantitativeCompo IBlueprint.buildLifeSupport(int size)
        {
            return new QuantitativeCompo("LifeSupport", size);
        }

        QuantitativeCompo IBlueprint.buildPowerGenerator(int size)
        {
            return new QuantitativeCompo("PowerGenerator", size);
        }

        DescriptiveCompo IBlueprint.buildSteering(string description)
        {
            return new DescriptiveCompo("Weapon", description);
        }

        DescriptiveCompo IBlueprint.buildWeapons(string description)
        {
            return new DescriptiveCompo("Weapon", description);
        }
    }
}
