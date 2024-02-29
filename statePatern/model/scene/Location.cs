using System.Drawing;
using System.Reflection;

namespace TPDesignPartens.statePatern.Scene
{
    public class Location: ITargetable
    {
        public Point coordonates{ get; set; }

        public Location(Point coordonates)
        {
            this.coordonates = coordonates;
        }

        public Location(int x, int y) 
        {
            this.coordonates = new Point(x, y);
        }
    }
}