﻿using System;
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
        public bool isfortified { get; set; }
        public Stance stance { get; set; }

        public Status(IUnitType type, bool isMobile, bool isfortified, Stance stance)
        {
            this.type = type;
            this.isMobile = isMobile;
            this.isfortified = isfortified;
            this.stance = stance;
        }

        public override string ToString()
        {
            string returnString = string.Empty;
            returnString += "Unit Type : " + type + "\r\n";
            returnString += "Mobile : " + isMobile + "\r\n";
            returnString += "Fortified : " + isfortified + "\r\n";
            returnString += "Current Stance : " + stance;
            return returnString;
        }
    }
}