using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab1
{
    abstract class ThreeDShape
    {
        private string typeOfShape;
       
 

        public string Shape
        {
            get
            {
                return this.typeOfShape;
            }
        }

        public ThreeDShape():this("Not Set")
        {
        }

        public ThreeDShape(string typeOfShapeInput)
        {
            this.typeOfShape = typeOfShapeInput;
        }

        public abstract double calculateVolume();
       
        public override string ToString()
        {
            return "Type of Shape: " +typeOfShape;

        }

     
    }
}
