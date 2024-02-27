using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.builderPatern.Builder;
using TPDesignPartens.BuilderPatern.Builders;

namespace TPDesignPartens.BuilderPatern
{
    internal class BuilderMain
    {
        public static void run()
        {
            StarPort starport = new StarPort();

            DefencePoint turret = starport.fabricateDefencePoint(new NonBreatherBlueprint());

            Console.WriteLine();
            Console.WriteLine("~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ");
            Console.WriteLine();

            StarBase capital = starport.fabricateStarBase(new WaterBreatherBlueprint());

            Console.WriteLine();
            Console.WriteLine("~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ");
            Console.WriteLine();

            Spacecraft fighter = starport.fabricateSpaceCraft(new AirBreatherBlueprin());

            turret.describe();

            Console.WriteLine();
            Console.WriteLine("~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ");
            Console.WriteLine();

            capital.describe();

            Console.WriteLine();
            Console.WriteLine("~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ~°~ ");
            Console.WriteLine();

            fighter.describe();

            Console.ReadLine();
        }

    }
}
