using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.BuilderPatern;

namespace TPDesignPartens
{
    internal class MainInterFace
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Select with 1 or 2");
            Console.WriteLine("1. Builder Patern");
            Console.WriteLine("2. State Patern");

            switch(Console.ReadLine())
            {
                case "1":
                    BuilderMain.run();
                    break;
                case "2":
                    StateMain.run();
                    break;
            }


        }

    }
}
