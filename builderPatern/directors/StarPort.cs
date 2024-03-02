using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TPDesignPartens.builderPatern.Builder;
using TPDesignPartens.builderPatern.product;

namespace TPDesignPartens.BuilderPatern.Builders
{
    public class StarPort
    {

        //Fabricates product, for the sake of this assignement, the input are taken by user input.

        private enum weaponChoices
        {
            Kinetic,
            Energy,
            Antimatter,
            Explosive,
            nanites
        }

        private enum SteeringChoices
        {
            Manual,
            Telepathic,
            automated,
            NeuralInterface
        }



        // fabricateSpaceCraft method takes a Spacecraft Blueprint object and calls its build methods
        public Spacecraft fabricateSpaceCraft(IBlueprint blueprint)
        {
            Console.WriteLine("Please enter the name of this Spacecraft");
            Spacecraft product = new Spacecraft(Console.ReadLine());

            Console.WriteLine("Please enter the hull capacity in integer.");
            product.hull = blueprint.buildHull(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the life support capacity in interger.");
            product.lifeSupport = blueprint.buildLifeSupport(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the generator capacity in interger.");
            product.powerGenerator = blueprint.buildPowerGenerator(int.Parse(Console.ReadLine()));



            string weaponChosen = sectectWeapon();
            product.weapons = blueprint.buildWeapons(weaponChosen);

            Console.WriteLine("Please enter the cargo capacity in interger.");
            product.cargo = blueprint.buildCargo(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the Engin max output in interger.");
            product.engin = blueprint.buildEngin(int.Parse(Console.ReadLine()));

            string steeringChosen = selectSteering();
            product.steering = blueprint.buildSteering(steeringChosen);

            return product;

        }

        // fabricateStarBase method takes a StarBase Blueprint object and calls its build methods
        public StarBase fabricateStarBase(IBlueprint blueprint)
        {
            Console.WriteLine("Please enter the name of this Star base");
            StarBase product = new StarBase(Console.ReadLine());

            Console.WriteLine("Please enter the hull capacity in integer.");
            product.hull = blueprint.buildHull(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the life support capacity in interger.");
            product.lifeSupport = blueprint.buildLifeSupport(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the generator capacity in interger.");
            product.powerGenerator = blueprint.buildPowerGenerator(int.Parse(Console.ReadLine()));

            string weaponChosen = sectectWeapon();
            product.weapons = blueprint.buildWeapons(weaponChosen);

            Console.WriteLine("Please enter the cargo capacity in interger.");
            product.cargo = blueprint.buildCargo(int.Parse(Console.ReadLine()));
            
            return product;
        }

        // fabricateDefencePoint method takes a DefencePoint Blueprint object and calls its build methods
        public DefencePoint fabricateDefencePoint(IBlueprint blueprint)
        {
            Console.WriteLine("Please enter the name of this Defence Point");
            DefencePoint product = new DefencePoint(Console.ReadLine());

            Console.WriteLine("Please enter the hull capacity in integer.");
            product.hull = blueprint.buildHull(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the generator capacity in interger.");
            product.powerGenerator = blueprint.buildPowerGenerator(int.Parse(Console.ReadLine()));

            string weaponChosen = sectectWeapon();
            product.weapons = blueprint.buildWeapons(weaponChosen);

            Console.WriteLine("Please enter the cargo capacity in interger.");
            product.cargo = blueprint.buildCargo(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter the Engin max output in interger.");
            product.engin = blueprint.buildEngin(int.Parse(Console.ReadLine()));
            
            
            product.steering = new DescriptiveCompo("Steering", "Automated");
            
            return product;
        }


        //list the steeringChoices and retreives the chosen string for the creation of the steering component
        private static string selectSteering()
        {
            string steeringChosen;
            do
            {
                Console.WriteLine("Please select a weapon from the follwoing list.");
                int i = 0;
                foreach (var s in Enum.GetValues(typeof(SteeringChoices)))
                {
                    i++;
                    Console.WriteLine("{0}. {1}", i, s);
                }
                int selection = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(SteeringChoices), selection))
                    steeringChosen = ((SteeringChoices)selection).ToString();
                else
                    steeringChosen = null;

            } while (steeringChosen == null);
            return steeringChosen;
        }

        //list the weaponchoices and retreives the chosen string for the creation of the weapon component
        private static string sectectWeapon()
        {
            string weaponChosen;
            do
            {
                Console.WriteLine("Please select a weapon from the follwoing list.");
                int i = 0;
                foreach (var s in Enum.GetValues(typeof(weaponChoices)))
                {
                    i++;
                    Console.WriteLine("{0}. {1}", i, s);
                }
                int selection = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(weaponChoices), selection))
                    weaponChosen = ((weaponChoices)selection).ToString();
                else
                    weaponChosen = null;

            } while (weaponChosen == null);
            return weaponChosen;
        }

    }

}
