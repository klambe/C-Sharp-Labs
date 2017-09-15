using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex v1 = new Vertex();
            Vertex v2 = new Vertex(2,2);
            Console.WriteLine("X: {0} Y: {1}", v1.x, v1.YCoordinate);

            Console.WriteLine("X: {0} Y: {1}", v2.x, v2.YCoordinate);

            Line l1 = new Line(1,1,5,5,"Blue");
            Console.WriteLine(l1.ToString());
            l1.Translate(2, 0);
            Console.WriteLine(l1.ToString());

            Circle c1 = new Circle("Blue", 3,3,7);

            Console.WriteLine(c1.ToString());

            c1.Translate(4, 3);
            Console.WriteLine(c1.ToString());

            Console.WriteLine("*********This is my Collection of Shapes ***************");

            Shape[] myShapes = new Shape[5] ;

            myShapes[0] = new Line(2, 2, 4, 9, "grey");
            myShapes[1] = new Circle("Yellow", 3, 3, 7);
            myShapes[2] = new Line(1, 9, 4, 9, "Orange");
            myShapes[3] = new Circle("Black", 5, 1, 10);
            myShapes[4] = new Line(5, 6, 11, 4, "Purple");

            for (int i = 0; i < myShapes.Length; i++)
            {
                Console.WriteLine("Shape {0} is:", (i+1));
                Console.WriteLine(myShapes[i].ToString());
                myShapes[i].Translate(2, 3);
            }

            Console.WriteLine("***************After Translation of the images****************");

            for (int i = 0; i < myShapes.Length; i++)
            {
                Console.WriteLine("Shape {0} is:", (i + 1));
                Console.WriteLine(myShapes[i].ToString());
            }




            Console.ReadLine();
        }
    }
}
