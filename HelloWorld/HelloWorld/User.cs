using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class User
    {
        public string name;
        public double salary;
        public int age;


        public User(string nameIn, double salaryIn, int ageIn)
        {
            name = nameIn;
            salary = salaryIn;
            age = ageIn;
        }

        public void printDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("age: " + age);

        }

    }
}
