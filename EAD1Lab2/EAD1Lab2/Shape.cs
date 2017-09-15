using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab2
{
    class Shape
    {
        public string ShapeColour
        { get; set; }

        public Shape() :this("None Set")
        { }

        public Shape(string colourIn)
        {
            this.ShapeColour = colourIn;
        }

        public override string ToString()
        {
            return "Colour: "+ShapeColour;
        }

        public virtual void Translate(int x, int y)
        {            
            
        }
    }
}
