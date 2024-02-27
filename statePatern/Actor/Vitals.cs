using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.Actor
{
    public class Vitals
    {
        public int HP { get; set; }
        public int range { get; set; }
        public int lineOfSight { get; set; }
        public int moveSpeed { get; set; }

        public Vitals(int hp, int range, int lineOfSight, int moveSpeed)
        {
            HP = hp;
            this.range = range;
            this.lineOfSight = lineOfSight;
            this.moveSpeed = moveSpeed;
        }

        public override string ToString()
        {
            string returnString = string.Empty;
            returnString += "Health Points : " + HP + "\r\n";
            returnString += "range : " + range + "\r\n";
            returnString += "Line of sight : " + lineOfSight + "\r\n";
            returnString += "Movement speed : " + moveSpeed;
            return returnString;
        }

    }
}
