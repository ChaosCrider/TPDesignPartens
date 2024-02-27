using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.scene
{
    internal class Player
    {
        public string name { get; set; }
        public HashSet<DesctrutableUnit> unitList { get;}

        public Player(string name)
        {
            this.name = name;
            this.unitList = new HashSet<DesctrutableUnit>();
        }
    }
}
