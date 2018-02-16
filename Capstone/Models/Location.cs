using System;
namespace Capstone.Models
{
    public abstract class Location
    {
        public readonly int X;
        public readonly int Y;

        public Location(int x,int y)
        {
            X=x;
            Y=y;
        }

        public int GetDistance(int x, int y)
        {
            int yDiff = y - this.Y;
            int xDiff = x - this.X;
            return ((int)System.Math.Sqrt(yDiff^2+xDiff^2));
        }
        //public bool OnMap(Map map) { return (this._x < map._xLim && this._y < map._yLim); }
    }
}
