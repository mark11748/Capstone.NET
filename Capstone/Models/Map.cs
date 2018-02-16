using System;
using System.Collections;

namespace Capstone.Models
{
    public class Map
    {
        public readonly int xLim;
        public readonly int yLim;


        public Map()
        {
            xLim = 16;
            yLim = 16;
        }
        public Map(int len = 16, int wid = 16)
        {
            xLim = len;
            yLim  = wid;
        }

        public bool OnMap(Location point) 
        { return (point.X < this.xLim && point.Y < this.yLim); }
    }
}
