using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab3
{
    class Sphere : IHasVolume
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

        public string TypeOfShape
        {
            get;
            set;
        }

        public Sphere() : this("Unknown", 0)
        {
        }
        public Sphere(string typeOfShape, double radiusIn)
        {
            this.radius = radiusIn;
            TypeOfShape = typeOfShape;

        }

        public  double calculateVolume()
        {
            return Math.PI * radius * radius * radius;
        }

        public override string ToString()
        {
            return "Type of Shape: " + TypeOfShape + " Radius: " + radius + " Volume: " + calculateVolume();
        }


    }
}
