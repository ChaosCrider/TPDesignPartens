using System.Drawing;
using System.Reflection;

namespace TPDesignPartens.statePatern.Scene
{
    public class Location
    {
        public Point coordonates{ get; set; }

        public Location(Point coordonates)
        {
            this.coordonates = coordonates;
        }
    }
}