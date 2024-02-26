using System;
using TPDesignPartens.builderPatern.Builder;
using TPDesignPartens.builderPatern.product;

namespace TPDesignPartens.BuilderPatern.Builders
{
    public class Spacecraft : Structure,IStructure
    {
        public Spacecraft(string name) : base(name)
        {
        }

        public QuantitativeCompo hull { get; set; }
        public QuantitativeCompo lifeSupport { get; set; }
        public QuantitativeCompo powerGenerator { get; set; }
        public DescriptiveCompo weapons { get; set; }
        public QuantitativeCompo cargo { get; set; }
        public QuantitativeCompo engin { get; set; }
        public DescriptiveCompo steering { get; set; }

        public void describe()
        {
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine("<============================>");
            Console.WriteLine("Hull : {0}", hull);
            Console.WriteLine("Life Support : {0}", lifeSupport);
            Console.WriteLine("Power Generator : {0}", powerGenerator);
            Console.WriteLine("Weapons : {0}", weapons);
            Console.WriteLine("Cargo : {0}", cargo);
            Console.WriteLine("Engin : {0}", engin);
            Console.WriteLine("Steering : {0}", steering);
            Console.WriteLine("<============================>");
        }
    }
}