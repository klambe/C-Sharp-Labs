using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab1
{
    class Sphere : ThreeDShape
    {
        private double radius;

        public double shapeRadius
        {
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 0;
                }

            }
            get
            {
                return this.radius;
            }
        }

        public Sphere() : this("Unknown", 0)
        {
        }
        public Sphere(string typeOfShape, double radiusIn) : base(typeOfShape)
        {
            this.radius = radiusIn;
        }

        public override double calculateVolume()
        {
            return Math.PI * radius * radius * radius;
        }

        public override string ToString()
        {
            return "Type of Shape: " + Shape + " Radius: " + radius + " Volume: " + calculateVolume();
        }


    }
}
