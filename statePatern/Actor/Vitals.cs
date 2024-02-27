using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDesignPartens.statePatern.Actor
{
    public class Vitals
    {
        public int HP { get; set; }
        public int range { get; set; }
        public int lineOfSight { get; set; }
        public int moveSpeed { get; set; }

        public Vitals(int hP, int range, int lineOfSight, int moveSpeed)
        {
            HP = hP;
            this.range = range;
            this.lineOfSight = lineOfSight;
            this.moveSpeed = moveSpeed;
        }
    }
}
