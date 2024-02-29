using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDesignPartens.statePatern.actor;
using TPDesignPartens.statePatern.State;

namespace TPDesignPartens.statePatern.Actor
{
    public class Status
    {
        public IUnitType type { get; set; }
        public bool isMobile { get; set; }
        public bool isFortified { get; set; }
        public Stance stance { get; set; }

        // parametered ctor, intended for usage.
        public Status(IUnitType type, bool isMobile, bool isfortified, Stance stance)
        {
            this.type = type;
            this.isMobile = isMobile;
            this.isFortified = isfortified;
            this.stance = stance;
        }

        //no-arg ctor, not intended for usage.
        public override string ToString()
        {
            string returnString = string.Empty;
            returnString += "Unit Type : " + type + "\r\n";
            returnString += "Mobile : " + isMobile + "\r\n";
            returnString += "Fortified : " + isFortified + "\r\n";
            returnString += "Current Stance : " + stance;
            return returnString;
        }
    }
}
