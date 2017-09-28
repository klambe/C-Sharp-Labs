using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Sphere t1 = new Sphere();
            Sphere t2 = new Sphere("Sphere", 25);

            EAD1Lab3.IHasVolume[] collection;
            collection = new IHasVolume[5];

            collection[0] = t1;
            collection[1] = t2;


            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());

            Console.WriteLine("************** Array Printout ************");

            foreach (IHasVolume s in collection)
            {
                Console.WriteLine(s + " volume: " + s.calculateVolume());
            }

            Console.ReadLine();
        }
    }
}
