using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab2
{
    class Circle : Shape
    {
        private Vertex center;
        private int radius;

        public Circle(string colour, int x1, int y1, int radiusIn) :base(colour)
        {
            center = new Vertex(x1, y1);
            this.radius = radiusIn;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return base.ToString() + " X1: " + center.x + " Y1: " + center.YCoordinate + " Radius: " + radius + " Area: "+ Area();
        }

        public override void Translate(int x, int y)
        {
            center.x = center.x + x;
            center.YCoordinate = center.YCoordinate + y;
        }
    }
}
