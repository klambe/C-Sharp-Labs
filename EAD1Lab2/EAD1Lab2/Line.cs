using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab2
{
    class Line :Shape
    {
        private Vertex v1;
        private Vertex v2;
        public Line(int pointOneXAxis, int pointOneyAxis, int pointTwoXAxis, int pointTwoYAxis, string shapeColour):base(shapeColour)
        {
            v1 = new Vertex(pointOneXAxis, pointOneyAxis);
            v2 = new Vertex(pointTwoXAxis, pointTwoYAxis);
        }

        public override string ToString()
        {          
            return base.ToString() + " X1: " + v1.x + " Y1: " + v1.YCoordinate + " X2: " + v2.x + " Y2: " + v2.YCoordinate;
        }

        public override void Translate(int x, int y)
        {
            v1.x = v1.x + x;
            v1.YCoordinate = v1.YCoordinate + y;

            v2.x = v2.x + x;
            v2.YCoordinate = v2.YCoordinate + y;
        }
    }
}
