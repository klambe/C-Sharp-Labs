using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 5;
            Console.WriteLine("Hello World" +test);
            Console.WriteLine(test);

            string hello = "this is a string";

            float x = 5;
            float y = 2;
            if (x > y)
            {
                Console.WriteLine(hello + " divide ints");
                Console.WriteLine(x / y);
            }

            if (true)
            {
                Student u1 = new Student("John", 25646.2,25);
                u1.printDetails();

            }
            else
            {
                Console.WriteLine("I guess it's false");
            }
            

            Console.ReadLine();

        }
    }
}
