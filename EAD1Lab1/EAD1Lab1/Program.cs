
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere t1 = new Sphere();
            Sphere t2 = new Sphere("Sphere", 25);

            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.ReadLine();
        }
    }
}


//public int Id
//{
//    set
//    {
//        if (value >= 0)
//        {
//            _id = value;
//        }

//    }
//    get
//    {
//        return this._id;

//    }
//}
//public string Email
//{
//    get;
//    set;
//}
