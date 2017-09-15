using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab2
{
    class Vertex
    {
        private int xCoordinate;
        //private double yCoordinate;

        public int x
        {
            set
            {
                xCoordinate = value;
            }
            get
            {
                return this.xCoordinate;
            }
        }

        //public double y
        //{
        //    set
        //    {
        //        yCoordinate = value;
        //    }
        //    get
        //    {
        //        return this.yCoordinate;
        //    }
        //}
        public int YCoordinate
        { get; set; }

        public Vertex() : this(0, 0)
        {
        }

        public Vertex(int xIn, int yIn)
        {
            this.xCoordinate = xIn;
            this.YCoordinate = yIn;

        }
    }
}
